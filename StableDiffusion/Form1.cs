using StableDiffusion.Properties;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using File = System.IO.File;

namespace StableDiffusion
{
    public partial class Form1 : Form
    {



        Process newProcess = null;
        ProcessStartInfo psi = new ProcessStartInfo();

        Bitmap DrawArea = new Bitmap(512,512);

        string AnacondaPath = "S:\\Python\\anaconda3";
        string envName = "ldm";
        string envpath = "S:\\Python\\anaconda3\\envs\\ldm";

        string txt2imgPath = "scripts/txt2img.py";
        string img2imgPath = "scripts/img2img.py";
        string imgs2imgsPath = "scripts/imgs2imgs.py";
        string inpaintPath = "scripts/inpaint.py";


        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(1040, 735);
            AnacondaPath = iniAccess.LoadAnacondaPath();
            envName = iniAccess.LoadEnvName();

            envpath = AnacondaPath + "\\envs\\" + envName;

            txt2imgPath = iniAccess.LoadTxt2imgPath();
            img2imgPath = iniAccess.LoadImg2imgPath();
            inpaintPath= iniAccess.LoadInpaintPath();

            textBoxSeed.Text = iniAccess.LoadSeed();

            trackBarIteration.Value = iniAccess.LoadIteration();
            trackBarN_iter.Value = iniAccess.LoadN_iter();
            trackBarN_samples.Value = iniAccess.LoadN_samples();
            trackBarStrength.Value = iniAccess.LoadStrength();


            listBoxStyle.Items.Clear();
            string[] Styles = iniAccess.LoadStyles();
            if (Styles[0].Length > 0)
            {
                for (int i = 0; i < Styles.Length; i++)
                {
                    listBoxStyle.Items.Add(Styles[i]);
                }
            }

            SelectedPanelTab = panelTabPrompt;


            using (Graphics graph = Graphics.FromImage(DrawArea))
            {
                Rectangle ImageSize = new Rectangle(0, 0, 512, 512);
                graph.FillRectangle(Brushes.Black, ImageSize);
            }

            pictureBox1.Image = DrawArea;



            Color c = Color.Gray;
            Graphics g = panelGradiant.CreateGraphics();


            LinearGradientBrush linearGradientBrush =
               new LinearGradientBrush(panelGradiant.ClientRectangle, Color.Black, Color.White, 0.0);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Black, c, Color.White };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            g.FillRectangle(linearGradientBrush, panelGradiant.ClientRectangle);






            this.pictureBox1.MouseWheel += new MouseEventHandler(pictureBox1_MouseWheel);
            this.pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseWheel);


            pictureBox1.Image = DrawArea;




            String Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages";
            var filters = new String[] { "jpg", "jpeg", "png", "tiff", "bmp" };
            String[] FileNames = GetFilesFrom(Path, filters, false);


            string[] subdirs = Directory.GetDirectories(Path);

            foreach (string dir in subdirs)
            {

                string new_string = dir.Split('\\').Last();
                listBoxInitImages.Items.Add(new_string);
            }


            /*
            foreach (string file in FileNames)
            {
                string new_string = file.Remove(file.LastIndexOf('.'));
                new_string = new_string.Split('\\').Last();
                listBoxInitImages.Items.Add(new_string);
            }
            */

            labelIteration.Text = (trackBarIteration.Value * 25).ToString();
            labelN_iter.Text = (trackBarN_iter.Value).ToString();
            labelN_samples.Text = (trackBarN_samples.Value).ToString();
            labelStrength.Text = ((float)trackBarStrength.Value / 20).ToString();




            listViewInitImages.View = View.Details;


            //populateInitImages();



        }



        private void populateInitImages(string folderName)
        {

           // listViewInitImages.Columns.Clear();

            listViewInitImages.Items.Clear();


            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages\\"+ folderName;
            var filters = new String[] { "jpg", "jpeg", "png", "tiff", "bmp" };
            string[] paths = GetFilesFrom(Path, filters, false);


            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            try
            {
                foreach(string path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch { }

            listViewInitImages.SmallImageList = imgs;


            String[] FileNames = GetFilesFrom(Path, filters, false);


            for(int i = 0; i < FileNames.Length; i++)
            {
                //string new_string = FileNames[i].Remove(FileNames[i].LastIndexOf('.'));
                //new_string = new_string.Split('\\').Last();

                listViewInitImages.Items.Add(FileNames[i], i);

            }






        }








        bool TabPrompt = true;
        bool TabImage = false;
        bool TabSequence = false;

        Panel SelectedPanelTab = new Panel();



        private void buttonTabPrompt_Click(object sender, EventArgs e)
        {
            TabPrompt = true;
            TabImage = false;
            TabSequence = false;

            switchTab(buttonTabPrompt, TabPrompt);
            switchTab(buttonTabImage, TabImage);
            switchTab(buttonTabSequence, TabSequence);
            
            switchTabPosition(SelectedPanelTab, panelTabPrompt);

            SelectedPanelTab = panelTabPrompt;

        }

        private void buttonTabImage_Click(object sender, EventArgs e)
        {
            TabPrompt = false;
            TabImage = true;
            TabSequence = false;

            switchTab(buttonTabPrompt, TabPrompt);
            switchTab(buttonTabImage, TabImage);
            switchTab(buttonTabSequence, TabSequence);

            switchTabPosition(SelectedPanelTab, panelTabImages);

            SelectedPanelTab = panelTabImages;
        }

        private void buttonTabSequence_Click(object sender, EventArgs e)
        {
            TabPrompt = false;
            TabImage = false;
            TabSequence = true;

            switchTab(buttonTabPrompt, TabPrompt);
            switchTab(buttonTabImage, TabImage);
            switchTab(buttonTabSequence, TabSequence);

            switchTabPosition(SelectedPanelTab, panelTabSequence);

            SelectedPanelTab = panelTabSequence;
        }





        private void switchTab(System.Windows.Forms.Button btn, bool enabled)
        {
            if (enabled)
                btn.BackColor = Color.FromArgb(20, 60, 30);
            else
            {
                btn.BackColor = Color.FromArgb(45, 35, 55);
            }

        }

        private void switchTabPosition(System.Windows.Forms.Panel panel1, System.Windows.Forms.Panel panel2)
        {
            Point panel1pos = panel1.Location;
            Point panel2pos = panel2.Location;

            panel1.Location = new Point(panel2pos.X, panel2pos.Y);
            panel2.Location = new Point(panel1pos.X, panel1pos.Y);

        }






        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }



        int brushSize = 4;

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
                if (e.Delta>0)
                {
                    brushSize = brushSize+2 ;
                }
                else
                {
                    brushSize = brushSize - 2;
                    if (brushSize<4)
                    { brushSize = 4; }
                }
        }






            bool Launched = false;
        int sec = 0;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Launched = !Launched;

            if (Launched)
            {
                sec = 0;
                timerSec.Start();
                buttonStart.BackColor = Color.FromArgb(20, 60, 30);
                buttonStart.Image = Resources.stop_button;
                buttonStart.Text = sec.ToString();

                if (clearImage)
                {
                    startText2Image();
                }
                else
                {
                    startImage2Image();
                }
            }
            else
            {
                timerSec.Stop();
                buttonStart.BackColor = Color.FromArgb(45, 35, 55);
                buttonStart.Image = Resources.play_button;
                buttonStart.Text = "";
                KillProcessAndChildrens(newProcess.Id);
                //newProcess.Kill();
            }

        }



        bool IsDigitsOnly(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        /// <summary>
        /// //////////////////////////////////// Start
        /// 
        private void startText2Image()
        {
            if (newProcess != null && !newProcess.HasExited)
                KillProcessAndChildrens(newProcess.Id);


            textBox1.Text = Regex.Replace(textBox1.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            File.WriteAllLines("text.txt", textBox1.Lines);
            string drive = envpath.Substring(0, 1);
            // string dir = "\"outputs\\inpainting\"";
            // string gen = "python scripts/inpaint.py --indir "+dir;

            string seed = " --seed " + textBoxSeed.Text;
            if (!IsDigitsOnly(textBoxSeed.Text))
            {
                seed = " --seed 404";
                textBoxSeed.Text = "404";
            }

            string text = textBox1.Text;

            string style = "";
            foreach (var item in listBoxStyle.SelectedItems)
            {
                //style = style+ "|" + item +":" + textBoxFXScale.Text;
                style = style + " | " + item;
            }
            foreach (var item in listBoxSubStyle.SelectedItems)
            {
                //style = style+ "|" + item +":" + textBoxFXScale.Text;
                style = style + " | " + item;
            }
            foreach (var item in listBoxStyleGeneric.SelectedItems)
            {
                //style = style+ "|" + item +":" + textBoxFXScale.Text;
                style = style + " | " + item;
            }

            text = text + style;
            text = " --prompt \"" + text + "\"";


            string iteration = " --ddim_steps " + trackBarIteration.Value * 25;

            string n_iter = " --n_iter " + trackBarN_iter.Value;
            string n_samples = " --n_samples " + trackBarN_samples.Value;


            string gen = "python "+ txt2imgPath+ " --skip_grid " + text + seed + iteration + n_iter + n_samples + " --plms";


            psi.UseShellExecute = true;
            psi.Verb = "runas";
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = @" %windir%\System32\cmd.exe /K " + AnacondaPath + "\\Scripts\\activate.bat " + AnacondaPath + "&conda activate " + envName + "&" + drive + ":&cd " + envpath + "&" + gen;
            try
            {


                newProcess = Process.Start(psi);


            }
            catch (Exception) { }



        }

        private void startImage2Image()
        {



            if (newProcess != null && !newProcess.HasExited)
                KillProcessAndChildrens(newProcess.Id);



            textBox1.Text = Regex.Replace(textBox1.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            File.WriteAllLines("text.txt", textBox1.Lines);
            string drive = envpath.Substring(0, 1);

            string seed = " --seed " + textBoxSeed.Text;
            if (!IsDigitsOnly(textBoxSeed.Text))
            {
                seed = " --seed 404";
                textBoxSeed.Text = "404";
            }

            string text = textBox1.Text;

            string style = "";
            foreach (var item in listBoxStyle.SelectedItems)
            {
                //style = style+ "|" + item +":" + textBoxFXScale.Text;
                style = style + " | " + item;
            }
            foreach (var item in listBoxSubStyle.SelectedItems)
            {
                //style = style+ "|" + item +":" + textBoxFXScale.Text;
                style = style + " | " + item;
            }
            foreach (var item in listBoxStyleGeneric.SelectedItems)
            {
                //style = style+ "|" + item +":" + textBoxFXScale.Text;
                style = style + " | " + item;
            }

            text = text + style;
            text = " --prompt \"" + text + "\"";


            string n_iter = " --n_iter " + trackBarN_iter.Value;
            string n_samples = " --n_samples " + trackBarN_samples.Value;


            //string size = " --W " + numericUpDownX.Value + "  --H " + numericUpDownY.Value;
            string iteration = " --ddim_steps " + trackBarIteration.Value * 25;


            string str = " --strength " + ((float)trackBarStrength.Value / 20).ToString(CultureInfo.InvariantCulture);


            string applicationDirectory = Application.ExecutablePath;

            String imgpath = envpath + "\\current.png";
            string initImage = "  --init-img " + imgpath;

            string gen = "python "+img2imgPath+" --skip_grid " + text + seed + initImage + iteration + str + n_iter + n_samples;
            //string gen = "python scripts/img2img.py --skip_grid " + text + seed + initImage + iteration + str + n_iter + n_samples;


            psi.UseShellExecute = true;
            psi.Verb = "runas";
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = @" %windir%\System32\cmd.exe /K "+AnacondaPath+ "\\Scripts\\activate.bat " + AnacondaPath + "&conda activate "+envName+"&" + drive + ":&cd " + envpath + "&" + gen;
            try
            {


                newProcess = Process.Start(psi);


            }
            catch (Exception) { }

        }


        private void startInpaint()
        {

            if (newProcess != null && !newProcess.HasExited)
                KillProcessAndChildrens(newProcess.Id);


            string drive = envpath.Substring(0, 1);

            string iteration = " --steps " + trackBarIteration.Value * 25;


            string gen = "python " + inpaintPath + " --indir inputs/inpainting/  --outdir outputs/inpainting_results" + iteration;

            Clipboard.SetText(gen);

            psi.UseShellExecute = true;
            psi.Verb = "runas";
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = @" %windir%\System32\cmd.exe /K " + AnacondaPath + "\\Scripts\\activate.bat " + AnacondaPath + "&conda activate " + envName + "&" + drive + ":&cd " + envpath + "&" + gen;
            try
            {


                newProcess = Process.Start(psi);


            }
            catch (Exception) { }

        }


        /// </summary>








        private void buttonOutFolder_Click(object sender, EventArgs e)
        {
            if (clearImage)
            {
                System.Diagnostics.Process.Start("explorer.exe", envpath + "\\outputs\\txt2img-samples\\samples");
            }
            else
            {
                System.Diagnostics.Process.Start("explorer.exe", envpath + "\\outputs\\img2img-samples\\samples");
            }
        }




        /// <summary>
        ///                     Clear Output Folder                                 ///
        /// </summary>
        private void buttonClearOutputFolder_Click(object sender, EventArgs e)
        {
            if (clearImage)
            {
                clearFolder(envpath + "\\outputs\\txt2img-samples\\samples");
            }
            else
            {
                clearFolder(envpath + "\\outputs\\img2img-samples\\samples");
            }
        }

        public static void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }





        Bitmap bmap = new Bitmap(512, 512);
        bool drw;
        int beginX, beginY;
        Color DrawColor = Color.White;
        Color PickColor = Color.White;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            drw = true;
            beginX = e.X;
            beginY = e.Y;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (isPencilEnabled || isInpainting)
            {
                Bitmap new_Image = new Bitmap(512, 512, PixelFormat.Format24bppRgb);
                new_Image = DrawArea;
                Graphics g = Graphics.FromImage(new_Image);

                using (SolidBrush brush = new SolidBrush(DrawColor))
                {
                    FillCircle(g, brush, e.X, e.Y, brushSize);

                    pictureBox1.Image = DrawArea;

                    g.Dispose();

                }
            }



            drw = false;
            if (!isInpainting)
            {
                var i = new Bitmap(DrawArea);
                i.Save(envpath + "\\current.png");
            }

            setClearImage(false);

        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPencilEnabled || isInpainting)
            {
                Bitmap new_Image = new Bitmap(512, 512, PixelFormat.Format24bppRgb);
                new_Image = DrawArea;
                Graphics g = Graphics.FromImage(new_Image);

                if (drw == true)
                {
                    using (SolidBrush brush = new SolidBrush(DrawColor))
                    {
                        FillCircle(g, brush, e.X, e.Y, brushSize);

                        pictureBox1.Image = DrawArea;

                        g.Dispose();


                    }
                    beginX = e.X;
                    beginY = e.Y;
                }
                pictureBox1.Refresh();
            }


        }


        public static void FillCircle(Graphics g, Brush brush,
                              float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }





        public Color LerpColor(Color s, Color t, float k)
        {
            var bk = (1 - k);
            var a = s.A * bk + t.A * k;
            var r = s.R * bk + t.R * k;
            var g = s.G * bk + t.G * k;
            var b = s.B * bk + t.B * k;
            return Color.FromArgb(cClamp((int)a), cClamp((int)r), cClamp((int)g), cClamp((int)b));
        }

        private int cClamp(int value)
        {
            return Math.Clamp(value, 0, 255);
        }

        double gradiantX = 0;
        private void panelGradiant_MouseMove(object sender, MouseEventArgs e)
        {
            if (GradiantClick)
                updateGradiant(sender, e);

            panelGradiant.Refresh();
        }

        private void updateGradiant(object sender, MouseEventArgs e)
        {
            if (GradiantClick)
            {
                gradiantX = (float)e.X / panelGradiant.Width;

                //MessageBox.Show(gradiantX.ToString());
                double Alpha = 0;

                if (gradiantX >= 0.5)
                {
                    Alpha = (gradiantX -0.5) *2;
                    DrawColor = LerpColor(PickColor, Color.White, (float)gradiantX);
                }
                else
                {
                    Alpha = gradiantX * 2;
                    DrawColor = LerpColor(Color.Black, PickColor, (float)gradiantX);
                }

                panelCpick.BackColor = DrawColor;
            }
        }

        bool GradiantClick = false;
        private void panelGradiant_MouseDown(object sender, MouseEventArgs e)
        {
            GradiantClick = true;
            updateGradiant(sender, e);
        }
        private void panelGradiant_MouseUp(object sender, MouseEventArgs e)
        {
            GradiantClick = false;
        }




        private void panelGradiant_Paint(object sender, PaintEventArgs e)
        {
            Color c =  PickColor;
            Graphics g = panelGradiant.CreateGraphics();


            LinearGradientBrush linearGradientBrush =
               new LinearGradientBrush(panelGradiant.ClientRectangle, Color.Black, Color.White, 0.0);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Black, c, Color.White };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            Point local = panelGradiant.PointToClient(Cursor.Position);
            Pen blackPen = new Pen(Color.Black, 3);

            g.FillRectangle(linearGradientBrush, panelGradiant.ClientRectangle);
            g.DrawLine(blackPen, local.X, local.Y - 100, local.X, local.Y + 100);


        }



        bool clearImage = true;
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxInitImages.ClearSelected();
            listViewInitImages.Items.Clear();

            using (Graphics graph = Graphics.FromImage(DrawArea))
            {
                Rectangle ImageSize = new Rectangle(0, 0, 512, 512);
                graph.FillRectangle(Brushes.Black, ImageSize);
            }

            pictureBox1.Image = DrawArea;

            setClearImage(true);
        }













        private void buttonImage_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            //Filter
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.webp;*.tif;...";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                
                Bitmap bm = OpenImage(fd.FileName);
                int w = (bm.Width / 8) * 8;
                int h = (bm.Height / 8) * 8;

                bm = (Bitmap)ResizeImage(bm, new Size(512, 512), false);
                pictureBox1.Image = bm;

                Bitmap i = bm;
                DrawArea = i;
                i.Save(envpath + "\\current.png");
                setClearImage(false);
                //pictureBox1.Dispose();

            }

        }

        public void setClearImage(bool value)
        {
            clearImage = value;

            buttonStrength.Enabled = !value;
            trackBarStrength.Enabled = !value;

        }


        public static Image ResizeImage(Image image, Size size, bool preserveAspectRatio = true)
        {
            int newWidth;
            int newHeight;

            if (preserveAspectRatio)
            {
                var originalWidth = image.Width;
                var originalHeight = image.Height;
                var percentWidth = size.Width / (float)originalWidth;
                var percentHeight = size.Height / (float)originalHeight;
                var percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }

            Image newImage = new Bitmap(newWidth, newHeight);

            using (var graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.SmoothingMode = SmoothingMode.HighQuality;
                graphicsHandle.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }



        private void buttonImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }




        public static Bitmap LoadBitmap(string path)
        {
            //Open file in read only mode
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            //Get a binary reader for the file stream
            using (BinaryReader reader = new BinaryReader(stream))
            {
                //copy the content of the file into a memory stream
                var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                //make a new Bitmap object the owner of the MemoryStream
                return new Bitmap(memoryStream);
            }
        }






        private void listBoxInitImages_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxInitImages.SelectedItems.Count > 0)
            populateInitImages(listBoxInitImages.SelectedItem.ToString());

            /*
            if (listBoxInitImages.SelectedItems.Count > 0)
            {
                String path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages\\" + listBoxInitImages.SelectedItem.ToString() + ".jpg";


                DrawArea = LoadBitmap(path);
                pictureBox1.Image = DrawArea;
                DrawArea.Save(envpath + "\\current.png");

                setClearImage(false);
            }
            */

        }



        bool seedBool = true;
        private void buttonSeed_Click(object sender, EventArgs e)
        {
            seedBool = !seedBool;
            if (seedBool)
            {
                textBoxSeed.Text = "777";
            }
            else
            {
                Random rnd = new Random();
                int randomSeed = rnd.Next(1, 100000000);
                textBoxSeed.Text = randomSeed.ToString();
            }
        }

        private void buttonIteration_Click(object sender, EventArgs e)
        {
            trackBarIteration.Value = 2;
        }

        private void buttonN_iter_Click(object sender, EventArgs e)
        {
            trackBarN_iter.Value = 1;
        }

        private void buttonN_samples_Click(object sender, EventArgs e)
        {
            trackBarN_samples.Value = 4;
        }

        private void buttonStrength_Click(object sender, EventArgs e)
        {
            trackBarStrength.Value = 16;
        }

        private void textBoxSeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }



        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            var ctrl = sender as Control;

            if (sender == trackBarIteration)
            {
                string value = (trackBarIteration.Value * 25).ToString();
                labelIteration.Text = value;
            }
            else if (sender == trackBarN_iter)
            {
                string value = (trackBarN_iter.Value).ToString();
                labelN_iter.Text = value;
            }
            else if (sender == trackBarN_samples)
            {
                string value = (trackBarN_samples.Value).ToString();
                labelN_samples.Text = value;
            }
            else if (sender == trackBarStrength)
            {
                string value = ((float)trackBarStrength.Value / 20).ToString();
                labelStrength.Text = value;
            }
        }

        private void timerSec_Tick(object sender, EventArgs e)
        {
            buttonStart.Text = sec.ToString();
            buttonStart.Image = Resources.stop_button;
            sec++;

            if (!IsRunning(newProcess))
            {
                timerSec.Stop();
                buttonStart.BackColor = Color.FromArgb(45, 35, 55);
                buttonStart.Text = "";
                buttonStart.Image = Resources.play_button;
                Launched = false;

            }
        }


        public static bool IsRunning(Process process)
        {
            if (process == null)
                throw new ArgumentNullException("process");

            try
            {
                Process.GetProcessById(process.Id);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }



        private void buttonSave_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:

                    iniAccess.SaveSeed(textBoxSeed.Text);
                    iniAccess.SaveIteration(trackBarIteration.Value);
                    iniAccess.SaveN_iter(trackBarN_iter.Value);
                    iniAccess.SaveN_samples(trackBarN_samples.Value);
                    iniAccess.SaveStrength(trackBarStrength.Value);

                    System.Media.SystemSounds.Hand.Play();
                    break;

                case MouseButtons.Right:
                    OpenWithDefaultProgram("Settings.ini");
                    break;
            }
        }





        public static void OpenWithDefaultProgram(string path)
        {
            using Process fileopener = new Process();

            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + path + "\"";
            fileopener.Start();
        }

        private void listBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBoxSubStyle.Items.Clear();
            string[] SubStyles = iniAccess.LoadSubStyles(listBoxStyle.SelectedItem.ToString());
            if (SubStyles[0].Length > 0)
            {
                for (int i = 0; i < SubStyles.Length; i++)
                {
                    listBoxSubStyle.Items.Add(SubStyles[i]);
                }
            }



        }

        bool isInpainting = false;

        Color lastDrawColor = Color.White;
        int lastbrushSize = 4;

        private void buttonInpaint_Click(object sender, EventArgs e)
        {
            isInpainting = !isInpainting;

            string inpaintingpath = envpath + "\\inputs\\inpainting\\";

            System.IO.Directory.CreateDirectory(inpaintingpath);
            System.IO.Directory.CreateDirectory(envpath + "\\outputs\\inpainting_results");

            if (isInpainting)
            {

                lastDrawColor = DrawColor;
                lastbrushSize = brushSize;

                buttonInpaint.BackColor = Color.FromArgb(20, 60, 30);
                DrawColor = Color.FromArgb(0, 255, 0);


                clearFolder(inpaintingpath);


                using (Bitmap bmp = new Bitmap(DrawArea))
                {
                    bmp.Save(inpaintingpath + "\\current.png", ImageFormat.Png);
                }


            }
            else
            {
                buttonInpaint.BackColor = Color.FromArgb(45, 35, 55);
                Bitmap mask = new Bitmap(ChangeToColor(DrawArea));

                DrawArea = LoadBitmap(inpaintingpath + "\\current.png");
                pictureBox1.Image = DrawArea;


                mask.Save(inpaintingpath + "\\current_mask.png");

                System.Diagnostics.Process.Start("explorer.exe", envpath + "\\outputs\\inpainting_results");
                
                startInpaint();

                DrawColor = lastDrawColor;
                brushSize = lastbrushSize;

            }



        }

        private Bitmap OpenImage(string path)
        {
            FileStream bmp = new FileStream(path, FileMode.Open, FileAccess.Read);
            Bitmap img = new Bitmap(bmp);
            bmp.Close();
            return img;
        }

        Bitmap ChangeToColor(Bitmap bmp)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            int width = bmp2.Width;
            int height = bmp2.Height;

            // Processing one pixel at a time is slow, but easy to understand
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int R = bmp.GetPixel(x,y).R;
                    int G = bmp.GetPixel(x, y).G;
                    int B = bmp.GetPixel(x, y).B;

                    if (R < 10 && G > 245 && B < 10)
                    {
                        bmp2.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                        bmp2.SetPixel(x, y, Color.FromArgb(0, 0, 0));

                }
            }
            return bmp2;
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isPencilEnabled || isInpainting)
            {
                Point local = pictureBox1.PointToClient(Cursor.Position);

                using (SolidBrush brush = new SolidBrush(DrawColor))
                {
                    e.Graphics.FillEllipse(brush, local.X - brushSize, local.Y - brushSize, brushSize * 2, brushSize * 2);
                }
            }





        }

        private void listViewInitImages_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewInitImages.SelectedItems.Count > 0)
            {
                string path = listViewInitImages.SelectedItems[0].SubItems[0].Text;
                pictureBox1.Image = System.Drawing.Image.FromFile(path);


                //String path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages\\" + listViewInitImages.SelectedItems[0].SubItems[0].Text + ".jpg";

                DrawArea = LoadBitmap(path);
                pictureBox1.Image = DrawArea;
                DrawArea.Save(envpath + "\\current.png");

                setClearImage(false);


            }

            foreach (ListViewItem i in listViewInitImages.SelectedItems)
            {
                i.Selected = false;
            }


            //string selected = listViewInitImages.SelectedItems[0].SubItems[0].Text;
        }

        private void buttonImage_DragDrop(object sender, DragEventArgs e)
        {
            List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".JPE", ".BMP", ".GIF", ".PNG" };

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var f in files)
            {
                if (ImageExtensions.Contains(Path.GetExtension(f).ToUpperInvariant()))
                {
                    MessageBox.Show(f);
                    DrawArea = new Bitmap(f);
                    pictureBox1.Image = DrawArea;
                    DrawArea.Save(envpath + "\\current.png");
                    break;
                }
            }
        }

        private void panelC_MouseClick(object sender, MouseEventArgs e)
        {
            Color c = (sender as Panel).BackColor;
            Graphics g = panelGradiant.CreateGraphics();


            LinearGradientBrush linearGradientBrush =
               new LinearGradientBrush(panelGradiant.ClientRectangle, Color.Black, Color.White, 0.0);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Black, c, Color.White };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            g.FillRectangle(linearGradientBrush, panelGradiant.ClientRectangle);

            PickColor = c;
            DrawColor = c;
            panelCpick.BackColor = c;
        }


        bool isPencilEnabled = false;
        private void buttonPencil_Click(object sender, EventArgs e)
        {
            isPencilEnabled = !isPencilEnabled;

            if (isPencilEnabled)
            {
                buttonPencil.BackColor = Color.FromArgb(20, 60, 30);
            }
            else
            {
                buttonPencil.BackColor = Color.FromArgb(45, 35, 55);
            }

        }






























        private static void KillProcessAndChildrens(int pid)
        {
            ManagementObjectSearcher processSearcher = new ManagementObjectSearcher
              ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection processCollection = processSearcher.Get();

            try
            {
                Process proc = Process.GetProcessById(pid);
                if (!proc.HasExited) proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }

            if (processCollection != null)
            {
                foreach (ManagementObject mo in processCollection)
                {
                    KillProcessAndChildrens(Convert.ToInt32(mo["ProcessID"])); //kill child processes(also kills childrens of childrens etc.)
                }
            }
        }




    }
}