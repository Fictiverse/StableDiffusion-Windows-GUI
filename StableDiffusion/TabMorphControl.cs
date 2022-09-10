using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StableDiffusion.myFunctions;


namespace StableDiffusion
{
    public partial class TabMorphControl : UserControl
    {
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
            }
        }


        public Bitmap Drawing
        {
            set
            {
                DrawArea = value;
                pictureBox1.Image = Drawing;
            }
            get { return DrawArea; }
        }

        public string TX
        {
            get{ return labelTx.Text; }
        }

        public string TY
        {
            get { return labelTy.Text; }
        }

        public string Zoom
        {
            get { return labelZoom.Text.Replace(",", "."); }
        }

        public string Angle
        {
            get { return labelAngle.Text.Replace(",", "."); ; }
        }


        int tx = 256;
        int ty = 256;
        float zoom = 1.0f;
        float angle = 0.0f;
        bool sinX = false;
        bool sinY = false;
        bool sinAngle = false;


        public TabMorphControl()
        {
            InitializeComponent();
        }

        private void buttonZoom_Click(object sender, EventArgs e)
        {
            trackBarZoom.Value = 10;
            labelZoom.Text = ""+1;
        }

        private void buttonAngle_Click(object sender, EventArgs e)
        {
            trackBarAngle.Value = 10;
            labelAngle.Text = ""+0;
        }

        private void buttonTx_Click(object sender, EventArgs e)
        {
            labelTx.Text = ""+256;
        }

        private void buttonTy_Click(object sender, EventArgs e)
        {
            labelTy.Text = ""+256;
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            labelZoom.Text = ((float)(trackBarZoom.Value-10)*0.025 + 1).ToString();
        }

        private void trackBarAngle_Scroll(object sender, EventArgs e)
        {
            labelAngle.Text = ((float)(trackBarAngle.Value - 10) * 0.25).ToString();
        }







        /// <summary> /////////////////////////////////////////////////////////////////////////////
        ///                          Drawing on picturebox1
        /// </summary>/////////////////////////////////////////////////////////////////////////////

        Bitmap DrawArea = new Bitmap(512, 512);
        Bitmap Previous = new Bitmap(512, 512);
        int brushSize = 4;
        bool isDrawing;
        Color DrawColor = Color.White;
        Color PickColor = Color.White;

        List<Bitmap> undoDrawArea = new List<Bitmap>();


        // painting
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Previous = (Bitmap)DrawArea.Clone();
            isDrawing = true;


        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            Bitmap new_Image = (Bitmap)Previous.Clone();
            Graphics g = Graphics.FromImage(new_Image);
            Point local = pictureBox1.PointToClient(Cursor.Position);

            Pen penBlack = new Pen(Brushes.Black);
            penBlack.Width = 3.0F;

            using (SolidBrush brush = new SolidBrush(DrawColor))
            {
                g.DrawLine(penBlack, 0, local.Y, this.Width, local.Y);
                g.DrawLine(penBlack, local.X, 0, local.X, this.Height);
                g.DrawLine(Pens.White, 0, local.Y, this.Width, local.Y);
                g.DrawLine(Pens.White, local.X, 0, local.X, this.Height);
                pictureBox1.Image = new_Image;
                g.Dispose();
            }

            
            isDrawing = false;

            labelTx.Text = e.X.ToString();
            labelTy.Text = e.Y.ToString();


        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

                pictureBox1.Refresh();

                // prevent heavy Ram usage;
                ClearMemory();


        }
    }
}
