using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StableDiffusion
{
    public partial class FormEnterText : Form
    {
        public FormEnterText(string intro, string defaultText = "")
        {
            InitializeComponent();
            labelMessage.Text = intro;
            textBoxText.Text = defaultText;
            this.ActiveControl = textBoxText;
        }

        public string textResult
        {
            get
            {
                return textBoxText.Text;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //Form1 parent = (Form1)this.Owner;
            //parent.ScreenshotTaken(bmpScreenshot);
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            textBoxText.Text = RemoveSpecialCharacters(textBoxText.Text);
        }

        private void textBoxText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        bool IsValidFilename(string testName)
        {
            Regex containsABadCharacter = new Regex("["
                  + Regex.Escape(new string(System.IO.Path.GetInvalidPathChars())) + "]");
            if (containsABadCharacter.IsMatch(testName)) { return false; };

            // other checks for UNC, drive-path format, etc

            return true;
        }

        private void textBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !"-_#".Contains(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_-]+", "", RegexOptions.Compiled);
        }



    }
}
