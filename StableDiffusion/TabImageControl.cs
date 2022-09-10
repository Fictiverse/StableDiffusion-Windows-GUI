using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StableDiffusion.iniAccess;
using static StableDiffusion.myFunctions;

namespace StableDiffusion
{
    public partial class TabImageControl : UserControl
    {
        public enum EnumDrawMod { Pencil, ColorPick, Fill, Inpaint, Face }


        bool isVisible = true;
        public bool IsVisible
        {
            get
            {
                return isVisible;
            }
            set
            {
                isVisible = value;
                this.Visible = value;
                this.Enabled = value;
            }
        }


        Bitmap initImage = new Bitmap(512, 512);

        int brushSize = 32;
        bool isDrawing;
        Color DrawColor = Color.White;
        Color PickColor = Color.White;


        Point footerVisibleLocation = new Point(0,0);
        Point footerHiddenLocation = new Point(0,0);
        List<Bitmap> undoinitImage = new List<Bitmap>();
        bool isDrawingClear = true;

        public event EventHandler ImageClearEvent;
        public event EventHandler ImageLoadedEvent;

        string envPath;
        public string environmentPath
        {
            set { envPath = value; }
        }



        public Bitmap InitImage
        {
            set 
            {

                initImage = value;
                pictureBox1.Image = value;
                initImage.Save(envPath + "\\current.png");
                isDrawingClear = false;
                ImageLoadedEvent(this, e);


            }
            get { return initImage; }
        }

        public bool isClear
        {
            get { return isDrawingClear; }
        }

        public bool isFaceRectangleSet
        {
            get { return faceRectangleSet; }
        }

        public TabImageControl()
        {
            InitializeComponent();


            footerVisibleLocation = panelColorPickGradiant.Location;
            footerHiddenLocation = panelBrowseInpaint.Location;
            // init drawing area
            using (Graphics graph = Graphics.FromImage(initImage))
            {
                Rectangle ImageSize = new Rectangle(0, 0, 512, 512);
                graph.FillRectangle(Brushes.Black, ImageSize);
            }
            pictureBox1.Image = initImage;
            AddToUndoList(initImage);

            // init Gradiant
            Color c = Color.Gray;
            Graphics gr = panelGradiant.CreateGraphics();
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(panelGradiant.ClientRectangle, Color.Black, Color.White, 0.0);
            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Black, c, Color.White };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };
            linearGradientBrush.InterpolationColors = cblend;
            gr.FillRectangle(linearGradientBrush, panelGradiant.ClientRectangle);



            // init images folders
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages");
            String path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages";

            var initImageList = new DirectoryInfo(path).GetDirectories().OrderBy(f => f.LastWriteTime).ToList();
            foreach (DirectoryInfo dir in initImageList)
            {
                listBoxInitImages.Items.Add(dir.Name);
            }

            listViewInitImages.View = View.Details;


            // mousewheel events
            this.pictureBox1.MouseWheel += new MouseEventHandler(pictureBox1_MouseWheel);
            this.pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseWheel);

            ChangeTab(buttonPencil, true);
        }




        public void RefreshInitImagesList()
        {
            listBoxInitImages.Items.Clear();

            // init images folders
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages");
            String path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages";

            var initImageList = new DirectoryInfo(path).GetDirectories().OrderBy(f => f.LastWriteTime).ToList();
            foreach (DirectoryInfo dir in initImageList)
            {
                listBoxInitImages.Items.Add(dir.Name);
            }

            listBoxInitImages.SelectedIndex = listBoxInitImages.Items.Count - 1;
        }

        bool isMouseInsideinitImage = false;

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            isMouseInsideinitImage = true;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            isMouseInsideinitImage = false;
            pictureBox1.Refresh();
        }


        EnumDrawMod DrawMod;


        private void buttonPencil_Click(object sender, EventArgs e)
        {
            SwitchTab(EnumDrawMod.Pencil);

            panelBrowseInpaint.Location = footerHiddenLocation;
            panelColorPickGradiant.Location = footerVisibleLocation;
            timer1.Enabled = false;
        }

        private void buttonPickColor_Click(object sender, EventArgs e)
        {
            SwitchTab(EnumDrawMod.ColorPick);

            panelBrowseInpaint.Location = footerHiddenLocation;
            panelColorPickGradiant.Location = footerVisibleLocation;
            timer1.Enabled = false;
        }

        private void buttonFillColor_Click(object sender, EventArgs e)
        {
            SwitchTab(EnumDrawMod.Fill);

            panelBrowseInpaint.Location = footerHiddenLocation;
            panelColorPickGradiant.Location = footerVisibleLocation;
            timer1.Enabled = false;
        }

        private void buttonFace_Click(object sender, EventArgs e)
        {
            SwitchTab(EnumDrawMod.Face);

            panelBrowseInpaint.Location = footerVisibleLocation;
            panelColorPickGradiant.Location = footerHiddenLocation;

            timer1.Enabled = true;

        }

        private void SwitchTab(EnumDrawMod mod)
        {
            DrawMod = mod;
            ChangeTab(buttonPencil, DrawMod == EnumDrawMod.Pencil);
            ChangeTab(buttonPickColor, DrawMod == EnumDrawMod.ColorPick);
            ChangeTab(buttonFillColor, DrawMod == EnumDrawMod.Fill);
            ChangeTab(buttonFace, DrawMod == EnumDrawMod.Face);
        }




        private void ChangeTab(System.Windows.Forms.Button btn, bool enabled)
        {
            pictureBox1.Refresh();
            if (enabled)
            {
                btn.BackColor = Color.FromArgb(20, 60, 30);
            }
            else
            {
                btn.BackColor = Color.FromArgb(40, 30, 50);
            }

        }










        /// <summary> /////////////////////////////////////////////////////////////////////////////
        ///                          Drawing on picturebox1
        /// </summary>/////////////////////////////////////////////////////////////////////////////

        bool faceRectangleSet = false;
        Rectangle faceRectangle = new Rectangle(0, 0, 512, 512);


        // painting
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            switch (DrawMod)
            {
                case EnumDrawMod.Pencil:
                    if(isMouseInsideinitImage)
                    {
                        Point local = pictureBox1.PointToClient(Cursor.Position);

                        if (smoothPencil)
                        {
                            FillSmoothCircle(e.Graphics, DrawColor, local.X, local.Y, brushSize);

                        }
                        else
                        {

                            using (SolidBrush brush = new SolidBrush(DrawColor))
                            {
                                FillCircle(e.Graphics, brush, local.X, local.Y, brushSize, false);
                            }
                        }
                    }

                    break;
                case EnumDrawMod.ColorPick:

                    break;
                case EnumDrawMod.Fill:

                    break;
                case EnumDrawMod.Face:

                    Rectangle r = new Rectangle();




                    if (isMouseInsideinitImage)
                    {
                        Point local = pictureBox1.PointToClient(Cursor.Position);
                        local = ClampPoint(local, brushSize);

                        r.Location = new Point(local.X - brushSize, local.Y - brushSize);
                        r.Height = brushSize * 2;
                        r.Width = brushSize * 2;
  

                        using (SolidBrush brush = new SolidBrush(DrawColor))
                            {                           
                                DrawSquare(e.Graphics, r);
                            }

                    }
                    if (faceRectangleSet)
                    {
                        using (SolidBrush brush = new SolidBrush(DrawColor))
                        {
                            DrawSquare(e.Graphics, faceRectangle);
                        }


                    }
                    break;
            }

            //Clipboard.SetImage(initImage);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {


            // save for undo
            AddToUndoList(initImage);

            isDrawing = true;

            // prevent heavy Ram usage;
            ClearMemory();
            Clipboard.SetImage(initImage);
        }

        public void AddToUndoList(Bitmap image)
        {
            // save for undo
            undoinitImage.Add((Bitmap)image.Clone());

            if (undoinitImage.Count > 33)
            {

                undoinitImage.RemoveAt(0);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (DrawMod)
            {
                case EnumDrawMod.Pencil:

                    if (smoothPencil)
                    {
                        Graphics g = Graphics.FromImage(initImage);
                        FillSmoothCircle(g, DrawColor, e.X, e.Y, brushSize);
                    }
                    else
                    {

                        try
                        {
                            Graphics g = Graphics.FromImage(initImage);

                            int dX = e.X;
                            int dY = e.Y;

                            if (initImage.Width < 512)
                            {
                                dX = e.X - ((512 - initImage.Width) / 2);
                            }
                            if (initImage.Height < 512)
                            {
                                dY = e.Y - ((512 - initImage.Height) / 2);
                            }

                            using (SolidBrush brush = new SolidBrush(DrawColor))
                            {
                                FillCircle(g, brush, dX, dY, brushSize);
                                pictureBox1.Image = initImage;
                            }

                            g.Dispose();
                        }
                        catch (OutOfMemoryException oome)
                        {
                        }
                    }

                  
                    isDrawingClear = false;
                    ImageLoadedEvent(this, e);
                    break;
                case EnumDrawMod.ColorPick:
                    if (e.X >= 0 && e.Y >= 0 && e.X < initImage.Width - 1 && e.Y < initImage.Height - 1)
                    {
                        Color c = ((Bitmap)pictureBox1.Image).GetPixel(e.X, e.Y);
                        PickColor = c;
                        DrawColor = c;
                        panelCpick.BackColor = c;
                        panelGradiant.Refresh();
                    }

                    break;
                case EnumDrawMod.Fill:

                    FloodFill(initImage, e.X, e.Y, DrawColor);

                    isDrawingClear = false;
                    ImageLoadedEvent(this, e);
                    break;

                case EnumDrawMod.Face:

                    Point local = new Point(e.X, e.Y);
                    local = ClampPoint(local, brushSize);


                    faceRectangle.Location = new Point(local.X- brushSize, local.Y- brushSize);
                    faceRectangle.Height = brushSize * 2;
                    faceRectangle.Width = brushSize * 2;

                    //Bitmap cropedImage = new Bitmap(faceRectangle.Width, faceRectangle.Height);
                    Bitmap cropedImage = initImage.Clone(new System.Drawing.Rectangle(faceRectangle.X, faceRectangle.Y, faceRectangle.Width, faceRectangle.Height), initImage.PixelFormat);


                    //cropedImage = CropFaceFromImage(initImage, faceRectangle);
                    ResizeImage(cropedImage, new Size(512,512)).Save("croped.png");

                    faceRectangleSet = true;

                    break;
            }

            pictureBox1.Refresh();
            //var i = new Bitmap(initImage);
            initImage.Save(envPath + "\\current.png");


            isDrawing = false;

            // prevent heavy Ram usage;
            ClearMemory();
            Clipboard.SetImage(initImage);
        }
        bool smoothPencil = true;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            switch (DrawMod)
            {
                case EnumDrawMod.Pencil:

                    if (isDrawing == true)
                    {
                        if (smoothPencil)
                        {
                            Graphics g = Graphics.FromImage(initImage);
                            FillSmoothCircle(g, DrawColor, e.X, e.Y, brushSize);
                        }
                        else
                        {
                            try
                            {
                                Graphics g = Graphics.FromImage(initImage);

                                int dX = e.X;
                                int dY = e.Y;

                                if (initImage.Width < 512)
                                {
                                    dX = e.X - ((512 - initImage.Width) / 2);
                                }
                                if (initImage.Height < 512)
                                {
                                    dY = e.Y - ((512 - initImage.Height) / 2);
                                }

                                using (SolidBrush brush = new SolidBrush(DrawColor))
                                {
                                    FillCircle(g, brush, dX, dY, brushSize);

                                }
                                g.Dispose();

                            }
                            catch (OutOfMemoryException oome)
                            {
                            }

                            pictureBox1.Refresh();
                        }
                       
                    }

                    break;
                case EnumDrawMod.ColorPick:
                    if (isDrawing == true)
                    {
                        if (e.X >= 0 && e.Y >= 0 && e.X < initImage.Width - 1 && e.Y < initImage.Height - 1)
                        {
                            Color c = ((Bitmap)pictureBox1.Image).GetPixel(e.X, e.Y);
                            PickColor = c;
                            DrawColor = c;
                            panelCpick.BackColor = c;
                            panelGradiant.Refresh();
                        }

                    }
                    break;
                case EnumDrawMod.Fill:
                    if (isDrawing)
                    {
                       // FloodFill(initImage, e.X, e.Y, DrawColor);
                        pictureBox1.Refresh();
                    }

                    break;
     
            }

        }



        private void buttonUndo_Click(object sender, EventArgs e)
        {

            if (undoinitImage.Count > 0)
            {
                initImage = (Bitmap)undoinitImage[undoinitImage.Count - 1].Clone();
                pictureBox1.Image = initImage;
                undoinitImage.RemoveAt(undoinitImage.Count - 1);

            }
            ClearMemory();
        }





        // change brush size
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
                if (e.Delta > 0)
                    brushSize = brushSize + 4;
                else
                    brushSize = brushSize - 4;

            brushSize = Math.Clamp(brushSize, 8, 255);
            pictureBox1.Refresh();
        }


        // gradiant bar
        double gradiantX = 0;
        bool isGradiantUpdating = false;

        private void panelGradiant_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panelGradiant.CreateGraphics();

            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(panelGradiant.ClientRectangle, Color.Red, Color.White, 0.0);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Black, PickColor, Color.White };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            Point local = panelGradiant.PointToClient(Cursor.Position);
            Pen blackPen = new Pen(Color.Black, 3);

            g.FillRectangle(linearGradientBrush, panelGradiant.ClientRectangle);
            g.DrawLine(blackPen, local.X, local.Y - 100, local.X, local.Y + 100);

        }

        private void panelGradiant_MouseMove(object sender, MouseEventArgs e)
        {
           // if (isGradiantUpdating)
            //    updateGradiant(e.X);
//
            //panelGradiant.Refresh();
        }


        private void panelGradiant_MouseDown(object sender, MouseEventArgs e)
        {
            gradiantX = (float)e.X / panelGradiant.Width;

            Color[] colorList = new Color[3] { Color.Black, PickColor, Color.White };
            DrawColor = InterpolateColor(colorList, gradiantX);

            panelCpick.BackColor = DrawColor;
            panelGradiant.Refresh();
            if (DrawMod == EnumDrawMod.ColorPick)
            {
                SwitchTab(EnumDrawMod.Pencil);
            }
        }




        public void ClearImage()
        {

            // reseting selected image
            listBoxInitImages.ClearSelected();
            //listViewInitImages.Items.Clear();

            // draw black square
            using (Graphics graph = Graphics.FromImage(initImage))
            {
                Rectangle ImageSize = new Rectangle(0, 0, 512, 512);
                graph.FillRectangle(Brushes.Black, ImageSize);
            }

            pictureBox1.Image = initImage;

            isDrawingClear= true;
            ImageClearEvent(this,e);
            
        }


        // Load image from file to drawing area
        private void buttonOpenImage_Click(object sender, EventArgs e)
        {

            buttonOpenImage.BackColor = Color.FromArgb(20, 60, 30);


            //StopInpaint();
            var fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif;...";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                // save for undo
                AddToUndoList(initImage);
                Bitmap bm = (Bitmap)FixedSize((Image)OpenImage(fd.FileName), 512, 512);


                // resize image
                if (bm.Height > bm.Width)
                {
                    float ratio = (float)bm.Width / (float)bm.Height;
                    double w = (512 * ratio);
                    w = (Math.Round(w / 64)) * 64;
                    bm = (Bitmap)ResizeImage(bm, new Size((int)w, 512), false);
                }
                else
                {
                    float ratio = bm.Width / bm.Height;

                    double h = (512 * ratio);
                    h = (Math.Round(h / 64)) * 64;
                    bm = (Bitmap)ResizeImage(bm, new Size(512, (int)h), false);
                }

                //bm = (Bitmap)ResizeImage(bm, new Size(512, 512), false);
                pictureBox1.Image = bm;

                initImage = bm;
                bm.Save(envPath + "\\current.png");
                isDrawingClear = false ;
                ImageLoadedEvent(this, e);
            }
            buttonOpenImage.BackColor = Color.FromArgb(55, 45, 65);
            // prevent heavy Ram usage;
            ClearMemory();
        }


        private void buttonOpenImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }


        private void buttonOpenImage_DragDrop(object sender, DragEventArgs e)
        {
            List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".JPE", ".BMP", ".GIF", ".PNG" };

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var f in files)
            {
                if (ImageExtensions.Contains(Path.GetExtension(f).ToUpperInvariant()))
                {
                    initImage = new Bitmap(f);
                    pictureBox1.Image = initImage;
                    initImage.Save(envPath + "\\current.png");
                    break;
                }
            }
        }



        private void buttonPastImage_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Bitmap bm = (Bitmap)FixedSize(Clipboard.GetImage(), 512, 512);


                // resize image
                if (bm.Height > bm.Width)
                {
                    float ratio = (float)bm.Width / (float)bm.Height;
                    double w = (512 * ratio);
                    w = (Math.Round(w / 64)) * 64;
                    bm = (Bitmap)ResizeImage(bm, new Size((int)w, 512), false);
                }
                else
                {
                    float ratio = bm.Width / bm.Height;

                    double h = (512 * ratio);
                    h = (Math.Round(h / 64)) * 64;
                    bm = (Bitmap)ResizeImage(bm, new Size(512, (int)h), false);
                }

                //bm = (Bitmap)ResizeImage(bm, new Size(512, 512), false);
                pictureBox1.Image = bm;

                initImage = bm;
                bm.Save(envPath + "\\current.png");
                isDrawingClear = false;
                ImageLoadedEvent(this, e);
            }

        }






        private void listBoxInitImages_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxInitImages.SelectedItems.Count > 0)
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages\\" + listBoxInitImages.SelectedItem.ToString();
                populateImageList(listViewInitImages, path);
            }

        }





        string selectedInitImagePath = null;

        private void listViewInitImages_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewInitImages.SelectedItems.Count > 0)
            {
                selectedInitImagePath = listViewInitImages.SelectedItems[0].SubItems[0].Text;
                undoinitImage.Clear();

                string path = listViewInitImages.SelectedItems[0].SubItems[0].Text;
                pictureBox1.Image = System.Drawing.Image.FromFile(path);

                initImage = LoadBitmap(path);
                pictureBox1.Image = initImage;
                initImage.Save(envPath + "\\current.png");

                isDrawingClear = false;
                ImageLoadedEvent(this, e);


            }
            else
            {
                selectedInitImagePath = null;
            }

            foreach (ListViewItem i in listViewInitImages.SelectedItems)
            {
            //    i.Selected = false;
            }

            // prevent heavy Ram usage;
            ClearMemory();

            //string selected = listViewInitImages.SelectedItems[0].SubItems[0].Text;
        }


        private void panelC_MouseClick(object sender, MouseEventArgs e)
        {
            Color c = (sender as Panel).BackColor;
            Graphics g = panelGradiant.CreateGraphics();


            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(panelGradiant.ClientRectangle, Color.Black, Color.White, 0.0);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Black, c, Color.White };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            g.FillRectangle(linearGradientBrush, panelGradiant.ClientRectangle);

            PickColor = c;
            DrawColor = c;
            panelCpick.BackColor = c;

            if (DrawMod == EnumDrawMod.ColorPick)
            {
                SwitchTab(EnumDrawMod.Pencil);
            }
        }












        // inpainting options

        Color lastDrawColor = Color.White;
        int lastBrushSize = 4;
        private EventArgs e;

        private void buttonInpaint_Click(object sender, EventArgs e)
        {
            /*
            if (!isDrawingClear)
            {
                EnablePencil(false);
                isInpainting = !isInpainting;

                // create output directory if needed
                string inpaintingpath = envPath + "\\inputs\\inpainting\\";
                System.IO.Directory.CreateDirectory(inpaintingpath);
                System.IO.Directory.CreateDirectory(envPath + "\\outputs\\inpainting_results");

                if (isInpainting)
                {
                    buttonInpaint.BackColor = Color.FromArgb(20, 60, 30);

                    // saving current brush
                    lastDrawColor = DrawColor;
                    lastBrushSize = brushSize;

                    // Green color for mask
                    DrawColor = Color.FromArgb(0, 255, 0);

                    clearFolder(inpaintingpath);

                    // saving image to inpaint
                    using (Bitmap bmp = new Bitmap(initImage))
                    {
                        bmp.Save(inpaintingpath + "\\current.png", ImageFormat.Png);
                    }


                }
                else
                {
                    buttonInpaint.BackColor = Color.FromArgb(45, 35, 55);

                    // creating mask image
                    Bitmap mask = new Bitmap(ChangeToColor(initImage));
                    mask.Save(inpaintingpath + "\\current_mask.png");

                    // restoring original Drawing
                    initImage = LoadBitmap(inpaintingpath + "\\current.png");
                    pictureBox1.Image = initImage;

                    // open output folder
                    System.Diagnostics.Process.Start("explorer.exe", envPath + "\\outputs\\inpainting_results");

                    // restore brush
                    DrawColor = lastDrawColor;
                    brushSize = lastBrushSize;

                    // start inpaint script
                    StartInpaint();

                }
            }
            */
        }


        // start inpaint script
        private void StartInpaint()
        {
            /*
            // kill old process
            if (newProcess != null && !newProcess.HasExited)
                KillProcessAndChildrens(newProcess.Id);

            //get env drive letter
            string drive = envpath.Substring(0, 1);

            string iteration = " --steps " + trackBarIteration.Value * 25;

            // making python line
            string gen = "python " + inpaintPath + " --indir inputs/inpainting/  --outdir outputs/inpainting_results" + iteration;

            Clipboard.SetText(gen);

            // start script
            psi.UseShellExecute = true;
            //psi.Verb = "runas";
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = @" %windir%\System32\cmd.exe /K " + AnacondaPath + "\\Scripts\\activate.bat " + AnacondaPath + "&conda activate " + envName + "&" + drive + ":&cd " + envpath + "&" + gen;
            try { newProcess = Process.Start(psi); } catch (Exception) { }*/
        }



        public void StopInpaint()
        {
            buttonInpaint.BackColor = Color.FromArgb(45, 35, 55);

            string inpaintingpath = envPath + "\\inputs\\inpainting\\";

            // restoring original Drawing
            //initImage = LoadBitmap(inpaintingpath + "\\current.png");
            //pictureBox1.Image = initImage;

            // restore brush
            DrawColor = lastDrawColor;
            brushSize = lastBrushSize;
        }

        private void buttonScreenshot_Click(object sender, EventArgs e)
        {
             buttonScreenshot.BackColor = Color.FromArgb(20, 60, 30);

            // save for undo
            AddToUndoList(initImage);

            using (FormScreenShot formSC = new FormScreenShot())
            {
                formSC.ShowDialog(this);
            }

            buttonScreenshot.BackColor = Color.FromArgb(55, 45, 65);

        }

        private void ToolStripMenuItemDeleteI_Click(object sender, EventArgs e)
        {
            if (listViewInitImages.SelectedItems.Count > 0)
            {

                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages\\" + listBoxInitImages.SelectedItem;
                List<string> stringList = new List<string>();
                foreach (ListViewItem itm in listViewInitImages.SelectedItems)
                {
                    stringList.Add(itm.SubItems[0].Text);
                }

                listViewInitImages.Items.Clear();
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();

                for (int i = 0; i < stringList.Count; i++)
                {
                    if (System.IO.File.Exists(stringList[i]))
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(stringList[i], Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        //System.IO.File.Delete(stringList[i]);
                    }
                }


                if (listBoxInitImages.SelectedItems.Count > 0)
                {
                    populateImageList(listViewInitImages, path);
                }

            }

        }

        private void ToolStripMenuItemMoveI_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem item;
            ToolStripMenuItem submenu = (sender as ToolStripMenuItem);

            submenu.DropDownItems.Clear();

            String path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages";

            var initImageList = new DirectoryInfo(path).GetDirectories().OrderBy(f => f.LastWriteTime).ToList();
            foreach (DirectoryInfo dir in initImageList)
            {
                if (listBoxInitImages.SelectedItem.ToString() != dir.Name)
                {
                    item = new ToolStripMenuItem();
                    item.Text = dir.Name;
                    submenu.DropDownItems.Add(item);
                    item.Click += new EventHandler(subToolStripMenuItemMoveI_Click);
                }
            }

            /*
            ListBox itemlist = listBoxInitImages;
            foreach (string preset in itemlist.Items)
            {
                if (listBoxInitImages.SelectedItem.ToString() != preset)
                {
                    item = new ToolStripMenuItem();
                    item.Text = preset;
                    submenu.DropDownItems.Add(item);
                    item.Click += new EventHandler(subToolStripMenuItemMoveI_Click);
                }

            }*/

        }

        private void subToolStripMenuItemMoveI_Click(object sender, EventArgs e)
        {
            string sourceImage = listViewInitImages.SelectedItems[0].SubItems[0].Text;
            string destinationDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages\\" + (sender as ToolStripMenuItem).Text + "\\" + Path.GetFileName(listViewInitImages.SelectedItems[0].Text);

            selectedInitImagePath = listViewInitImages.SelectedItems[0].SubItems[0].Text;
            int selectedIndex = listBoxInitImages.SelectedIndices[0];

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();


            System.IO.File.Copy(sourceImage, destinationDir, true);
            System.IO.File.Delete(sourceImage);
            listBoxInitImages.SelectedItem = (sender as ToolStripMenuItem).Text;

        }

        int cropedResultNbr = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string mainpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Crop\\samples\\";
            var filters = new String[] { "jpg", "jpeg", "png", "bmp" };
            string[] imageDirs = GetFilesFrom(mainpath, filters, false);

            PictureBox[] lists = new PictureBox[]{ pictureBoxInpaint1, pictureBoxInpaint2, pictureBoxInpaint3, pictureBoxInpaint4 };

            if (imageDirs.Length != cropedResultNbr)
            {
                foreach (PictureBox p in lists)
                {
                    if (p.Image != null)
                    {
                        p.Image.Dispose();
                        p.Image = null;
                    }
                }

                for (int i = 0; i < imageDirs.Length; i++)
                {

                    try
                    {
                        FileStream fs = new FileStream(imageDirs[i], FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        lists[i].Image = (Bitmap)System.Drawing.Image.FromStream(fs).Clone();
                        fs.Dispose();
                    }
                    catch { }

                }

                cropedResultNbr = imageDirs.Length;
            }


         }

        private void pictureBoxInpaint1_Click(object sender, EventArgs e)
        {
            AddToUndoList(InitImage);
            string mainpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Crop\\samples\\00000.png";
            Image backImg = initImage;

            Bitmap mrkImg = new Bitmap(faceRectangle.Width, faceRectangle.Height);
            mrkImg = (Bitmap)Image.FromFile(mainpath);
            //Image mrkImg = ResizeImage3(Image.FromFile(mainpath), new Size(faceRectangle.Width,faceRectangle.Width));
            

            Graphics g = Graphics.FromImage(initImage);
            g.DrawImage(mrkImg, faceRectangle.X, faceRectangle.Y);
            pictureBox1.Refresh();
        }
    }
}
