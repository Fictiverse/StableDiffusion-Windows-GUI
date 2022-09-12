using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static StableDiffusion.iniAccess;
using static StableDiffusion.myFunctions;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace StableDiffusion
{
    public partial class TabBrowseControl : UserControl
    {


        public event EventHandler SetSelectedStylesFromBrowser;
        public event EventHandler SetPromptFromBrowser;
        public event EventHandler SetSettingsFromBrowser;
        public event EventHandler NewInitImageAdded;

        string selectedStyles;
        string prompt;
        string settings;

        int presetpaths = 0;
        int presetresultpaths = 0;
        int resultimages = 0;

        bool isVisible = false;

        Bitmap tabImage = new Bitmap(512, 512);


        public string SelectedStyles
        {
            get
            {
                return selectedStyles;
            }
        }
        public string Prompt
        {
            get
            {
                return prompt;
            }
        }

        public string Settings
        {
            get
            {
                return settings;
            }
        }


        public bool IsVisible
        {
            get
            {
                return isVisible;
            }
            set
            {
                listBoxPreset.Items.Clear();

                //string[] presetDirs = Directory.GetDirectories(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result");
                var presetDirs = new DirectoryInfo(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result").GetDirectories().OrderBy(f => f.LastWriteTime).ToList();
                foreach (DirectoryInfo dir in presetDirs)
                {
                    listBoxPreset.Items.Add(Path.GetFileName(dir.FullName));
                }
                presetpaths = presetDirs.Count;

                listBoxPreset.SelectedItem = LoadSelectedFolder();
                isVisible = value;
                this.Visible = value;

                timer1.Enabled = value;
                if (value)
                {

                }
                else
                {
                    listViewInitImages.Items.Clear();
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                }
                this.Enabled = value;
            }
        }



        public Bitmap SelectedImage
        {
            get { return tabImage; }
        }

        public TabBrowseControl()
        {
            InitializeComponent();

            listBoxPreset.Items.Clear();

            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result");
            var presetDirs = new DirectoryInfo(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result").GetDirectories().OrderBy(f => f.LastWriteTime).ToList();
            foreach (DirectoryInfo dir in presetDirs)
            {
                listBoxPreset.Items.Add(Path.GetFileName(dir.FullName));
            }
            presetpaths = presetDirs.Count;

            listBoxPreset.SelectedItem = LoadSelectedFolder();

        }



        public void SelectPreset(string preset)
        {
            listBoxPreset.SelectedItem = preset;
        }

        private void listBoxPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewInitImages.Items.Clear();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            listBoxFolderList.Items.Clear();
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                string mainpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\";

                if (Directory.Exists(mainpath + listBoxPreset.SelectedItem))
                {
                    //string[] dirs = Directory.GetDirectories(mainpath + listBoxPreset.SelectedItem);

                    var sortedFiles = new DirectoryInfo(mainpath + listBoxPreset.SelectedItem).GetDirectories()
                                                  .OrderBy(f => f.LastWriteTime)
                                                  .ToList();
                    foreach (DirectoryInfo dir in sortedFiles)
                    {
                        //MessageBox.Show(dir.FullName);
                        listBoxFolderList.Items.Add(Path.GetFileName(dir.FullName));
                    }

                    presetresultpaths = listBoxFolderList.Items.Count;
                    listBoxFolderList.SelectedIndex = listBoxFolderList.Items.Count - 1;
                }
                SaveSelectedFolder(listBoxPreset.SelectedItem.ToString());
            }

        }

        private void listBoxFolderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubFolderSelectedIndex = listBoxFolderList.SelectedIndex;
            string mainpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\";
            string imgspath = mainpath + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem + "\\samples";
            if (listBoxFolderList.SelectedItems.Count > 0)
            {
                populateImageList(listViewInitImages, imgspath);
                resultimages = listViewInitImages.Items.Count;

                if (listViewInitImages.Items.Count > 0)
                {
                    listViewInitImages.Items[0].Selected = true;
                }
            }


            listBoxResultSettings.Items.Clear();
            List<string> list = LoadPromptInTxtFile(mainpath + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem);

            //MessageBox.Show(list[0]);
            foreach (var it in list)
            {
                listBoxResultSettings.Items.Add(it);
            }


        }


        private void listViewInitImages_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewInitImages.SelectedItems.Count > 0)
            {
                string path = listViewInitImages.SelectedItems[0].SubItems[0].Text;

                try
                {
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    tabImage = (Bitmap)System.Drawing.Image.FromStream(fs).Clone();
                    fs.Dispose();
                }
                catch { }
                /*
                using (System.Drawing.Image bmp = System.Drawing.Image.FromFile(path))
                {
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();

                    TabImage = (Bitmap)bmp.Clone();
                }
                */
                pictureBox1.Image = tabImage;
                pictureBox1.Refresh();
                Clipboard.SetImage(tabImage);
            }

            foreach (ListViewItem i in listViewInitImages.SelectedItems)
            {
                // i.Selected = false;
            }

            // prevent heavy Ram usage;
            ClearMemory();

            //string selected = listViewInitImages.SelectedItems[0].SubItems[0].Text;
        }



        int SubFolderSelectedIndex = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            // preset folders

            string mainpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\";
            string[] presetDirs = Directory.GetDirectories(mainpath);

            if (presetDirs.Length != presetpaths)
            {
                listBoxPreset.Items.Clear();

                var sortedFiles = new DirectoryInfo(mainpath).GetDirectories().OrderBy(f => f.LastWriteTime).ToList();
                foreach (DirectoryInfo presetdir in sortedFiles)
                {
                    listBoxPreset.Items.Add(Path.GetFileName(presetdir.FullName));
                }

                if (listBoxPreset.Items.Count > 0)
                {
                    listBoxPreset.SelectedItem = listBoxPreset.Items[listBoxPreset.Items.Count - 1];
                    SubFolderSelectedIndex = listBoxPreset.SelectedIndex;
                }
                
                presetpaths = presetDirs.Length;
            }


            // Sub folders
            if (listBoxPreset.SelectedIndex > -1)
            {
                mainpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\";
                string[] folderDirs = Directory.GetDirectories(mainpath + listBoxPreset.SelectedItem);

                if (folderDirs.Length != presetresultpaths)
                {

                    listBoxFolderList.Items.Clear();
                    var sortedFiles = new DirectoryInfo(mainpath + listBoxPreset.SelectedItem).GetDirectories().OrderBy(f => f.LastWriteTime).ToList();
                    foreach (DirectoryInfo folderdir in sortedFiles)
                    {
                        listBoxFolderList.Items.Add(Path.GetFileName(folderdir.FullName));
                    }

                    if (listBoxFolderList.Items.Count > 0)
                    {
                        listBoxFolderList.SelectedItem = listBoxFolderList.Items[listBoxFolderList.Items.Count - 1];
                        SubFolderSelectedIndex = listBoxFolderList.SelectedIndex;
                    }

                    presetresultpaths = folderDirs.Length;
                }                

            }



            // images
            mainpath = mainpath + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem + "\\samples";
            var filters = new String[] { "jpg", "jpeg", "png", "tiff", "bmp" };
            string[] imageDirs = GetFilesFrom(mainpath, filters, false);

            if (imageDirs.Length != resultimages)
            {
                populateImageList(listViewInitImages, mainpath);

                if (listViewInitImages.Items.Count > 0)
                {
                    listViewInitImages.EnsureVisible(listViewInitImages.Items.Count - 1);
                    listViewInitImages.Items[listViewInitImages.Items.Count - 1].Selected = true;
                }

                resultimages = imageDirs.Length;
            }
 
        }


        private void listBoxResultSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxResultSettings.SelectedItems.Count > 0)
                try { Clipboard.SetText(listBoxResultSettings.SelectedItem.ToString()); } catch { }
        }

        private void listBoxFolderList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listBoxFolderList.SelectedItems.Count > 0)
                {
                    int selectedIndex = listBoxFolderList.SelectedIndices[0];
                    listViewInitImages.Items.Clear();
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
                    if (Directory.Exists(path)) Directory.Delete(path, true);
                    listBoxFolderList.Items.RemoveAt(selectedIndex);
                    if (listBoxFolderList.Items.Count > selectedIndex)
                    {
                        listBoxFolderList.SelectedIndex = selectedIndex;
                    }

                }

            }
            else if (e.KeyCode == Keys.Enter)
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem + "\\samples";
                if (Directory.Exists(path))
                {
                    System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", path);
                }
                else
                {
                    path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
                    if (Directory.Exists(path))
                    {
                        System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", path);
                    }
                }
            }
        }

        private void listViewInitImages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listViewInitImages.SelectedItems.Count > 0)
                {

                    string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
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
                }

            }
        }



        //  MenuStrip  ////////////////////////////////////////////////////////////////////////

        private void ToolStripMenuItemOpenF_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem + "\\samples";
            if (Directory.Exists(path))
            {
                System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", path);
            }
            else
            {
                path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
                if (Directory.Exists(path))
                {
                    System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", path);
                }
            }

        }

        private void ToolStripMenuItemDeleteF_Click(object sender, EventArgs e)
        {
            if (listBoxFolderList.SelectedItems.Count > 0)
            {
                int selectedIndex = listBoxFolderList.SelectedIndex;
                listViewInitImages.Items.Clear();
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
                if (Directory.Exists(path))
                {
                    try
                    {
                        //Directory.Delete(path, true);
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        listBoxFolderList.Items.RemoveAt(selectedIndex);
                        if (listBoxFolderList.Items.Count > selectedIndex)
                        {
                            listBoxFolderList.SelectedIndex = selectedIndex;
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        MessageBox.Show("Deletion aborded");
                    }
                    catch 
                    {
                        MessageBox.Show("Some files are used by another application or user, deletion aborded");
                    }

                }
                presetresultpaths = listBoxFolderList.Items.Count;
            }
        }



        private void ToolStripMenuItemMoveF_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem item;
            ToolStripMenuItem submenu = (sender as ToolStripMenuItem);

            submenu.DropDownItems.Clear();

            foreach (string preset in listBoxPreset.Items)
            {
                if (listBoxPreset.SelectedItem.ToString() != preset)
                {
                    item = new ToolStripMenuItem();
                    item.Text = preset;
                    submenu.DropDownItems.Add(item);
                    item.Click += new EventHandler(subToolStripMenuItemMoveF_Click);
                }

            }

        }

        private void subToolStripMenuItemMoveF_Click(object sender, EventArgs e)
        {
            string sourceDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
            string destinationDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + (sender as ToolStripMenuItem).Text + "\\" + listBoxFolderList.SelectedItem; ;

            if (listBoxFolderList.Items.Count > 0)
            {
                if (listBoxFolderList.SelectedItems.Count > 0)
                {
                    //int selectedIndex = listBoxFolderList.SelectedIndices[0];
                    listViewInitImages.Items.Clear();
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();

                    CopyFilesRecursively(sourceDir, destinationDir);
                }

            }


            /*
            if (selectedIndex > 0)
            {
                listBoxFolderList.SelectedIndex = selectedIndex - 1;
            }
            else if (listBoxFolderList.Items[selectedIndex + 1] != null)
            {
                listBoxFolderList.SelectedIndex = selectedIndex + 1;
            }*/

        }






        private void ToolStripMenuItemRenameF_Click(object sender, EventArgs e)
        {
            if (listBoxFolderList.SelectedItems.Count > 0)
            {
                using (FormEnterText formTxt = new FormEnterText("Please enter the new name", listBoxFolderList.SelectedItems[0].ToString()))
                {
                    if (formTxt.ShowDialog() == DialogResult.OK)
                    {

                        string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
                        string result = formTxt.textResult;
                        DirectoryInfo di = new DirectoryInfo(path);

                        if (di != null && !string.IsNullOrWhiteSpace(result) )
                        {
                            if (!Directory.Exists(Path.Combine(di.Parent.FullName, result)))
                            {
                                listViewInitImages.Items.Clear();

                                System.GC.Collect();
                                System.GC.WaitForPendingFinalizers();
                                di.MoveTo(Path.Combine(di.Parent.FullName, result));
                                listBoxFolderList.Items[listBoxFolderList.SelectedIndex] = result;
                            }
                            else
                            {
                                MessageBox.Show("A folder with this name already exist!");
                            }
                        }

                        //listBoxFolderList.SelectedItem = result;
                        //RefreshListBoxFolderList();
                    }

                }
            }

        }




        private void ToolStripMenuItemCopyAll_Click(object sender, EventArgs e)
        {
            if (listBoxFolderList.SelectedItems.Count > 0)
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
                List<string> savelist = LoadPromptInTxtFile(path);
                prompt = savelist[0];
                selectedStyles = savelist[1];
                settings = savelist[2];
                SetPromptFromBrowser(this, e);
                SetSelectedStylesFromBrowser(this, e);
                SetSettingsFromBrowser(this, e);
            }


        }
        private void ToolStripMenuItemCopyPrompt_Click(object sender, EventArgs e)
        {
            if (listBoxFolderList.SelectedItems.Count > 0)
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
                List<string> savelist = LoadPromptInTxtFile(path);
                prompt = savelist[0];
                SetPromptFromBrowser(this, e);
            }
        }

        private void ToolStripMenuItemCopyStyles_Click(object sender, EventArgs e)
        {
            if (listBoxFolderList.SelectedItems.Count > 0)
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
                List<string> savelist = LoadPromptInTxtFile(path);
                selectedStyles = savelist[1];
                SetSelectedStylesFromBrowser(this, e);
            }
        }

        private void ToolStripMenuItemCopySettings_Click(object sender, EventArgs e)
        {
            if (listBoxFolderList.SelectedItems.Count > 0)
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
                List<string> savelist = LoadPromptInTxtFile(path);
                settings = savelist[2];
                SetSettingsFromBrowser(this, e);
            }
        }






        // preset Menu Strip
        private void ToolStripMenuItemOpenP_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem;
            if (Directory.Exists(path))
            {
                System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", path);
            }
            else
            {
                path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result";
                if (Directory.Exists(path))
                {
                    System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", path);
                }
            }
        }

        private void ToolStripMenuItemRenameP_Click(object sender, EventArgs e)
        {
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                using (FormEnterText formTxt = new FormEnterText("Please enter the new name", listBoxPreset.SelectedItems[0].ToString()))
                {
                    if (formTxt.ShowDialog() == DialogResult.OK)
                    {

                        string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem;
                        string result = formTxt.textResult;
                        DirectoryInfo di = new DirectoryInfo(path);

                        if (di != null && !string.IsNullOrWhiteSpace(result))
                        {
                            if (!Directory.Exists(Path.Combine(di.Parent.FullName, result)))
                            {
                                listViewInitImages.Items.Clear();

                                System.GC.Collect();
                                System.GC.WaitForPendingFinalizers();
                                di.MoveTo(Path.Combine(di.Parent.FullName, result));
                                listBoxPreset.Items[listBoxPreset.SelectedIndex] = result;
                            }
                        }

                        //listBoxFolderList.SelectedItem = result;
                        //RefreshListBoxFolderList();
                    }

                }
            }
        }

        private void ToolStripMenuItemDeleteP_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to delete this Folder and ALL the subfolders ?",
                      "Definitive action", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    if (listBoxPreset.SelectedItems.Count > 0)
                    {
                        int selectedIndex = listBoxPreset.SelectedIndex;
                        listViewInitImages.Items.Clear();
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                        string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem;
                        if (Directory.Exists(path))
                        {
                            try
                            {
                                //Directory.Delete(path, true);
                                Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                                listBoxPreset.Items.RemoveAt(selectedIndex);
                                if (listBoxPreset.Items.Count > selectedIndex)
                                {
                                    listBoxPreset.SelectedIndex = selectedIndex;
                                }
                            }
                            catch (OperationCanceledException)
                            {
                                MessageBox.Show("Deletion aborded");
                            }
                            catch
                            {
                                MessageBox.Show("Some files are used by another application or user, deletion aborded");
                            }
                        }
                        presetpaths = listBoxPreset.Items.Count;
                    }

                    break;
                case DialogResult.No:
                    break;
            }

          
        }





        private void ToolStripMenuItemOpenI_Click(object sender, EventArgs e)
        {
            if(listViewInitImages.SelectedItems.Count > 0)
                OpenWithDefaultProgram(listViewInitImages.SelectedItems[0].Text);
        }

        private void toolStripMenuItemSetInitImage_Click(object sender, EventArgs e)
        {
            if (listViewInitImages.Items.Count > 0 && listViewInitImages.SelectedItems.Count>0)
            {
                string outdir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages";
                System.IO.Directory.CreateDirectory(outdir);
                outdir = outdir + "\\" + listBoxPreset.SelectedItem;
                System.IO.Directory.CreateDirectory(outdir);
                tabImage.Save(outdir + "\\" + listBoxFolderList.SelectedItem + "_" + Path.GetFileName(listViewInitImages.SelectedItems[0].Text));

                NewInitImageAdded(this, e);
            }


           
        }

        private void ToolStripMenuItemDeleteI_Click(object sender, EventArgs e)
        {
            if (listViewInitImages.SelectedItems.Count > 0)
            {

                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result\\" + listBoxPreset.SelectedItem + "\\" + listBoxFolderList.SelectedItem;
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
            }
        }

    }
}
