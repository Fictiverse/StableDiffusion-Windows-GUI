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
    public partial class TabSequenceControl : UserControl
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



        public TabSequenceControl()
        {
            InitializeComponent();
        }

    }
}
