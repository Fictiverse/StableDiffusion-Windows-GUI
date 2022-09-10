using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace StableDiffusion
{
    public partial class FormScreenShot : Form
    {


        /// <summary>
        /// Struct representing a point.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <see>See MSDN documentation for further information.</see>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        public static Point GetCursorPosition()
        {

            POINT lpPoint;
            GetCursorPos(out lpPoint);
            // NOTE: If you need error handling
            // bool success = GetCursorPos(out lpPoint);
            // if (!success)

            return lpPoint;
        }



        public FormScreenShot()
        {
            InitializeComponent();

            // mousewheel events
            this.MouseWheel += new MouseEventHandler(form_MouseWheel);
            this.MouseMove += new MouseEventHandler(form_MouseWheel);



            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(OnTick);
            timer.Start();
        }

        void OnTick(object sender, EventArgs e)
        {
            Point point = GetCursorPosition();

            point.X = point.X-this.Width/2;
            point.Y = point.Y-this.Height/2;

            this.Location = point;
        }

        int formSize = 32;
        // change brush size
        private void form_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta != 0)
            {
                //MessageBox.Show("f");
                if (e.Delta > 0)
                {
                    formSize = formSize + 2;
                }
                else
                {
                    formSize = formSize - 2;
                    if (formSize < 2)
                    { formSize = 2; }
                }
            }


            this.Size = new Size(formSize*16, formSize*16);
        }


        private void FormScreenShot_Click(object sender, EventArgs e)
        {
            Point point = GetCursorPosition();
            point.X = point.X - this.Width / 2;
            point.Y = point.Y - this.Height / 2;

            Bitmap bmpScreenshot = new Bitmap(this.Width, this.Height);

            Graphics g = Graphics.FromImage(bmpScreenshot);

            this.Opacity = 0;
            g.CopyFromScreen(point.X, point.Y, 0, 0, new Size(this.Width, this.Height));


            Form1 parent = (Form1)this.Owner;
            parent.ScreenshotTaken(bmpScreenshot);

            Clipboard.SetImage(bmpScreenshot);
            //bmpScreenshot.Save("image.jpg", ImageFormat.Jpeg);
            this.Close();
        }
    }
}
