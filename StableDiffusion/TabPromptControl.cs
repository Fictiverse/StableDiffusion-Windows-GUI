using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StableDiffusion.iniAccess;
using static StableDiffusion.myFunctions;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StableDiffusion
{


    public partial class TabPromptControl : UserControl
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



        public TabPromptControl()
        {

            InitializeComponent();


        }

        public string Styles
        {
            get 
            {
                string style = "";

                if (listBoxSelectedStyles.Items.Count > 0)
                {
                    style = listBoxSelectedStyles.Items[0].ToString();
                    if (listBoxSelectedStyles.Items.Count > 1)
                    {
                        for (int i = 1; i < listBoxSelectedStyles.Items.Count; i++)
                        {
                            style = style + ", " + listBoxSelectedStyles.Items[i].ToString();
                        }
                    }

                }
               /*
                foreach (var item in listBoxSelectedStyles.Items)
                {
                    style = style + ", " + item;
                }*/
                return style; 
            }
            set
            {
                listBoxSelectedStyles.Items.Clear();
                string[] selectedStyles = Array.ConvertAll(value.Split(','), p => p.Trim());
                foreach (string style in selectedStyles)
                {
                    listBoxSelectedStyles.Items.Add(style);
                }
            }
        }

        public string Preset
        {
            get 
            {
                string r = "";  
                if (listBoxPreset.SelectedItems.Count > 0)
                {
                    r = listBoxPreset.SelectedItem.ToString();
                }
                else
                {
                    r = "NoPreset";
                }
                return r;
            }

            //set { textBox1.Text = value; }
        }

        public ListBox listboxSelected
        {
            get{ return listBoxSelectedStyles;}

            set { listBoxSelectedStyles = value; }
        }


        public event EventHandler PresetChangedEvent;

        private void listBoxPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                textBoxPresetStyle.Enabled = true;
                buttonAddPresetStyle.Enabled = true;
                buttonRemovePresetStyle.Enabled = true;

                listBoxPresetStyles.Items.Clear();
                List<string> subStyles = LoadSubStyles(listBoxPreset.SelectedItem.ToString());
                foreach (var str in subStyles)
                    listBoxPresetStyles.Items.Add(str);
            }
            else
            {
                textBoxPresetStyle.Enabled = false;
                buttonAddPresetStyle.Enabled = false;
                buttonRemovePresetStyle.Enabled = false;
            }

            PresetChangedEvent(this, e);
            SavePreset(listBoxPreset);
        }



        private void buttonAddStyle_Click(object sender, EventArgs e)
        {


            if (sender == buttonAddPreset)
            {
                listBoxPreset.Items.Add(textBoxPreset.Text);
                RemoveDuplicate(listBoxPreset);
                CreatePreset(textBoxPreset.Text);
                SavePreset(listBoxPreset);
                //AddPreset(textBoxPreset.Text);
            }
            else if (sender == buttonAddPresetStyle)
            {
                string[] styles = Array.ConvertAll(textBoxPresetStyle.Text.Split(','), p => p.Trim());
                foreach (string style in styles)
                {
                    listBoxPresetStyles.Items.Add(style);
                }
                RemoveDuplicate(listBoxPresetStyles);
                SaveSubStyles(listBoxPresetStyles, listBoxPreset.SelectedItem.ToString());
            }
            else if (sender == buttonAddGenericStyle)
            {
                string[] styles = Array.ConvertAll(textBoxGenericStyle.Text.Split(','), p => p.Trim());
                foreach (string style in styles)
                {
                    listBoxGenericStyles.Items.Add(style);
                }
                RemoveDuplicate(listBoxGenericStyles);
                SaveGenericStyles(listBoxGenericStyles);
            }




        }

        private void CreatePreset(string preset)
        {
            SavePreset(listBoxPreset);
            SaveSubStyles(listBoxPresetStyles, preset.Replace(" ", "_"));

        }

        private void buttonSavePresets_Click(object sender, EventArgs e)
        {
            SavePreset(listBoxPreset);
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                SaveSubStyles(listBoxPresetStyles, listBoxPreset.SelectedItem.ToString());
            }

        }

        private void buttonSaveGenericStyles_Click(object sender, EventArgs e)
        {
            SaveGenericStyles(listBoxGenericStyles);
        }

        private void buttonSaveSelectedStyles_Click(object sender, EventArgs e)
        {
            SaveSelectedStyles(listBoxSelectedStyles);
        }

        private void TabPromptControl_Load(object sender, EventArgs e)
        {
            listBoxPreset.Items.Clear();
            List<string> presets = LoadPresets();
            foreach (var str in presets)
                listBoxPreset.Items.Add(str);

            listBoxPreset.SelectedItem = LoadSelectedPreset();

            listBoxGenericStyles.Items.Clear();
            List<string> gStyles = LoadGenericStyles();
            foreach (var str in gStyles)
                listBoxGenericStyles.Items.Add(str);

            listBoxSelectedStyles.Items.Clear();
            List<string> sStyles = LoadSelectedStyles();
            foreach (var str in sStyles)
                listBoxSelectedStyles.Items.Add(str);

        }

        private void buttonRemovePreset_Click(object sender, EventArgs e)
        {
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete " + listBoxPreset.SelectedItems[0] + " preset ?", listBoxPreset.SelectedItems[0] + " will be removed !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string preset = listBoxPreset.SelectedItems[0].ToString();
                    listBoxPreset.Items.Remove(preset);
                    IniFile SettingFile = new IniFile("Settings.ini");
                    preset = preset.Replace(" ", "_");
                    SettingFile.DeleteKey(preset, "Styles");
                    listBoxPresetStyles.Items.Clear();
                    SavePreset(listBoxPreset);
                }
                else if (dialogResult == DialogResult.No) { }
            }
        }

        private void buttonRemovePresetStyle_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = listBoxPresetStyles.SelectedItems;
            if (listBoxPresetStyles.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBoxPresetStyles.Items.Remove(selectedItems[i]);
            }
            SavePreset(listBoxPreset);
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                SaveSubStyles(listBoxPresetStyles, listBoxPreset.SelectedItem.ToString());
            }

        }

        private void buttonRemoveGenericStyle_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = listBoxGenericStyles.SelectedItems;
            if (listBoxGenericStyles.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBoxGenericStyles.Items.Remove(selectedItems[i]);
            }
            SaveGenericStyles(listBoxGenericStyles);
        }

        private void buttonRemoveStyles_Click(object sender, EventArgs e)
        {
            listBoxSelectedStyles.Items.Clear();
            SaveSelectedStyles(listBoxSelectedStyles);
        }

        private void buttonRemoveSelectedStyles_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = listBoxSelectedStyles.SelectedItems;
            if (listBoxSelectedStyles.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBoxSelectedStyles.Items.Remove(selectedItems[i]);
            }
            SaveSelectedStyles(listBoxSelectedStyles);
        }

        private void buttonShuffleSelectedStyles_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection list = listBoxSelectedStyles.Items;
            Random rng = new Random();
            int n = list.Count;
            //begin updating
            listBoxSelectedStyles.BeginUpdate();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            listBoxSelectedStyles.EndUpdate();
            listBoxSelectedStyles.Invalidate();
            SaveSelectedStyles(listBoxSelectedStyles);
        }








        private void buttonAddAllSelectedPreset_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxPresetStyles.Items)
            {
                listBoxSelectedStyles.Items.Add(item);
            }


            RemoveDuplicate(listBoxSelectedStyles);
            SaveSelectedStyles(listBoxSelectedStyles);
        }

        private void buttonAddSelectedPreset_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxPresetStyles.SelectedItems)
            {
                listBoxSelectedStyles.Items.Add(item);
            }
            RemoveDuplicate(listBoxSelectedStyles);
            SaveSelectedStyles(listBoxSelectedStyles);
        }

        private void buttonAddGenericToPreset_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxGenericStyles.SelectedItems)
            {
                listBoxPresetStyles.Items.Add(item);
            }
            RemoveDuplicate(listBoxPresetStyles);
            SavePreset(listBoxPreset);
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                SaveSubStyles(listBoxPresetStyles, listBoxPreset.SelectedItem.ToString());
            }
        }

        private void buttonAddSelectedToStyles_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxGenericStyles.SelectedItems)
            {
                listBoxSelectedStyles.Items.Add(item);
            }
            RemoveDuplicate(listBoxSelectedStyles);
            SaveSelectedStyles(listBoxSelectedStyles);
        }

        private void buttonAddSelectedStylesToGeneric_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxSelectedStyles.SelectedItems)
            {
                listBoxGenericStyles.Items.Add(item);
            }
            RemoveDuplicate(listBoxGenericStyles);
            SaveGenericStyles(listBoxGenericStyles);
        }

        private void buttonAddSelectedStylesToPreset_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxSelectedStyles.SelectedItems)
            {
                listBoxPresetStyles.Items.Add(item);
            }
            RemoveDuplicate(listBoxPresetStyles);
            SavePreset(listBoxPreset);
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                SaveSubStyles(listBoxPresetStyles, listBoxPreset.SelectedItem.ToString());
            }
        }
    }
}
