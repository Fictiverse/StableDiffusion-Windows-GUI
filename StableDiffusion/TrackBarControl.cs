using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StableDiffusion
{
    public partial class TrackBarControl : UserControl
    {

        int min = 0;
        int max = 10;
        int steps = 10;
        int value = 0;
        public int Minimum
        {
            get => min;
            set => min = value;
        }
        public int Maximum
        {
            get => max;
            set => max = value;
        }

        public int Value
        {
            get => this.value;
            set { this.value = value; paneltb.Refresh(); }

        }

        public List<int> stepsLocation = new List<int>() { };

        public TrackBarControl()
        {
            InitializeComponent();

            int steps = max - min;

            float dist = (float)((paneltb.Width-20) / steps);
            //MessageBox.Show(paneltb.Width.ToString());
            for (int i = 0; i <= steps; i++)
            {
                stepsLocation.Add((int)((dist*i)+10));
                //MessageBox.Show(((int)((dist * i) + 10)).ToString());
            }
        }

        int w = 50;
        private void paneltb_MouseDown(object sender, MouseEventArgs e)
        {
           activated = true;
            w = e.X;
            //w = ClosestTo(stepsLocation, w);
            paneltb.Refresh();

        }


        private int ClosestTo(IEnumerable<int> collection, int target)
        {
            // NB Method will return int.MaxValue for a sequence containing no elements.
            // Apply any defensive coding here as necessary.
            var closest = int.MaxValue;
            var minDifference = int.MaxValue;
            foreach (var element in collection)
            {
                var difference = Math.Abs((long)element - target);
                if (minDifference > difference)
                {
                    minDifference = (int)difference;
                    closest = element;
                }
            }

            return closest;
        }


        private void paneltb_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;

            Rectangle r = new Rectangle(0, 0, p.Width / 2, p.Height);
            SolidBrush hb = new SolidBrush(Color.FromArgb(40, 30, 50));
            e.Graphics.FillRectangle(hb, w - 10, 1, 20, p.Height-2);

        }

        bool activated = false;
        private void paneltb_MouseMove(object sender, MouseEventArgs e)
        {
            if (activated)
            {
                w = e.X;
                w = ClosestTo(stepsLocation, w);
                paneltb.Refresh();
            }
        }

        private void paneltb_MouseUp(object sender, MouseEventArgs e)
        {
            activated = false;
        }
    }
}
