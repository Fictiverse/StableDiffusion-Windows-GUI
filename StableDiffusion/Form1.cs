using StableDiffusion.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static StableDiffusion.iniAccess;
using static StableDiffusion.myFunctions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;



namespace StableDiffusion
{


    public enum EnumTab { Browse, Prompt,Image, Sequence, Morph}

    public enum EnumScript {txt2txt, img2img, imgs2imgs, imgMorph}



    public partial class Form1 : Form
    {

        public EnumTab currentTab;
        public EnumScript currentScript;
        
        TabBrowseControl tabBrowse = new TabBrowseControl();
        TabPromptControl tabPrompt = new TabPromptControl();
        TabImageControl tabImage = new TabImageControl();
        TabSequenceControl tabSequence = new TabSequenceControl();
        TabMorphControl tabMorph = new TabMorphControl();
        


        Process newProcess = null;
        ProcessStartInfo psi = new ProcessStartInfo();

        Bitmap DrawArea = new Bitmap(512,512);

        string AnacondaPath = "";
        string envName = "";
        string envpath = "";

        string txt2imgPath = "scripts/txt2img.py";
        string img2imgPath = "scripts/img2img.py";
        string img2morphPath = "scripts/img2morph.py";
        string imgs2imgsPath = "scripts/imgs2imgs.py";
        string inpaintPath = "scripts/inpaint.py";

        string separator = ", ";
        public Form1()
        {
            InitializeComponent();

            // init form visuals            
            //this.Size = new Size(1043, 823);


            panelMainTab.Visible = false;


            tabBrowse.Location = panelMainTab.Location;
            this.Controls.Add(tabBrowse);

            tabPrompt.Location = panelMainTab.Location;
            this.Controls.Add(tabPrompt);

            tabImage.Location = panelMainTab.Location;
            this.Controls.Add(tabImage);

            tabSequence.Location = panelMainTab.Location;
            this.Controls.Add(tabSequence);

            tabMorph.Location = panelMainTab.Location;
            this.Controls.Add(tabMorph);
            

            SwitchTab(EnumTab.Prompt);

            // init default values

            bool isEnvValid = false;

            envpath = LoadEnvPath();
            while (!isEnvValid)
            {
                isEnvValid = IsEnvPathValid(envpath);
            }

            tabImage.environmentPath = envpath;


            textBoxPrompt.Text = LoadPrompt();

            string seed = LoadSeed();
            if (IsDigitsOnly(seed))
            {
                textBoxSeed.Text = seed;
            }
            else
            {
                isRandomSeed = true;
                buttonSeed.BackColor = Color.FromArgb(20, 60, 30);
                textBoxSeed.Enabled = false;
                textBoxSeed.Text = "Random";
            }

            trackBarIteration.Value = ClampTrackbar(trackBarIteration, LoadIteration());
            trackBarN_iter.Value = ClampTrackbar(trackBarN_iter, LoadIteration());
            trackBarN_samples.Value = ClampTrackbar(trackBarN_samples, LoadIteration());
            trackBarGuidance.Value = ClampTrackbar(trackBarGuidance, LoadIteration());
            trackBarChannels.Value = ClampTrackbar(trackBarChannels, LoadIteration());
            trackBarStrength.Value = ClampTrackbar(trackBarStrength, LoadIteration());

            //MessageBox.Show(trackBarN_samples.Value.ToString());
            labelIteration.Text = (trackBarIteration.Value * 25).ToString();

            if (trackBarN_iter.Value == 0)
            {
                labelN_iter.Text = "∞";
            }
            else
            {
                labelN_iter.Text = trackBarN_iter.Value.ToString();
            }
            labelN_samples.Text = (trackBarN_samples.Value).ToString();
            labelGuidance.Text = ((float)trackBarGuidance.Value / 2).ToString(); 
            labelChannels.Text = ((float)trackBarChannels.Value * 4).ToString();
            labelStrength.Text = ((float)trackBarStrength.Value / 20).ToString();



            tabPrompt.PresetChangedEvent += new EventHandler(PresetChangedEvent);

            tabImage.ImageClearEvent += new EventHandler(ImageClearEvent);
            tabImage.ImageLoadedEvent += new EventHandler(ImageLoadedEvent);

            tabBrowse.SetSelectedStylesFromBrowser += new EventHandler(SetSelectedStylesFromBrowser);
            tabBrowse.SetPromptFromBrowser += new EventHandler(SetPromptFromBrowser);
            tabBrowse.SetSettingsFromBrowser += new EventHandler(SetSettingsFromBrowser); 
            tabBrowse.NewInitImageAdded += new EventHandler(NewInitImageAdded);
        }

        string selectedPreset = "";
        protected void PresetChangedEvent(object sender, EventArgs e)
        {
            selectedPreset=tabPrompt.Preset.ToString();
            tabBrowse.SelectPreset(selectedPreset);
        }

        protected void ImageClearEvent(object sender, EventArgs e)
        {
            if (currentScript == EnumScript.img2img || currentScript == EnumScript.imgMorph)
            {      
                SwitchScriptSelector(EnumScript.txt2txt);
            }
        }

        protected void ImageLoadedEvent(object sender, EventArgs e)
        {
            if (currentTab == EnumTab.Image)
            {
                SwitchScriptSelector(EnumScript.img2img);
            }
            else if (currentTab == EnumTab.Morph)
            {
                SwitchScriptSelector(EnumScript.imgMorph);
            }

        }

        protected void SetPromptFromBrowser(object sender, EventArgs e)
        {

             textBoxPrompt.Text = tabBrowse.Prompt;
        }
        protected void SetSelectedStylesFromBrowser(object sender, EventArgs e)
        {

            tabPrompt.Styles = tabBrowse.SelectedStyles;
        }

        protected void SetSettingsFromBrowser(object sender, EventArgs e)
        {
            string settings = tabBrowse.Settings;
            string seed = "";
            string ddim_steps = "";
            string n_iter = "";
            string n_samples = "";
            string scale = "";


            string[] s = settings.Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == "--seed")
                {
                    seed = s[i + 1];
                    if (IsDigitsOnly(seed))
                    {
                        textBoxSeed.Text = seed;
                        buttonSeed.BackColor = Color.FromArgb(40, 30, 50);
                        textBoxSeed.Enabled = true;
                        isRandomSeed = false;
                    }
                    else
                    {
                        isRandomSeed = true;
                        buttonSeed.BackColor = Color.FromArgb(20, 60, 30);
                        textBoxSeed.Enabled = false;
                        textBoxSeed.Text = "Random";
                    }
                }
                else if (s[i] == "--ddim_steps")
                {
                    ddim_steps = s[i + 1];
                    int value = Convert.ToInt16(Convert.ToDouble(ConvertStringToInt(ddim_steps)) / 25);
                    trackBarIteration.Value = ClampTrackbar(trackBarIteration, LoadIteration());
                }
                else if (s[i] == "--n_iter")
                {
                    n_iter = s[i + 1];
                    int value = (int)ConvertStringToInt(n_iter);
                    trackBarN_iter.Value = ClampTrackbar(trackBarN_iter, LoadIteration());
                }
                else if (s[i] == "--n_samples")
                {
                    n_samples = s[i + 1];
                    int value = Convert.ToInt16(ConvertStringToInt(n_samples));
                    trackBarN_samples.Value = ClampTrackbar(trackBarN_samples, LoadIteration());
                }
                else if (s[i] == "--scale")
                {
                    scale = s[i + 1].Replace(".", ",");
                    int value = Convert.ToInt16(Convert.ToDouble(scale) * 2);
                    trackBarGuidance.Value = ClampTrackbar(trackBarGuidance, LoadIteration());
                }
                else if (s[i] == "--C")
                {
                    scale = s[i + 1];
                    int value = Convert.ToInt16(Convert.ToDouble(scale) * 2);
                    trackBarChannels.Value = ClampTrackbar(trackBarChannels, LoadIteration());
                }
            }




        }
        protected void NewInitImageAdded(object sender, EventArgs e)
        {
            SwitchTab(EnumTab.Image);
            tabImage.RefreshInitImagesList();
        }

        private bool IsEnvPathValid(string path)
        {
            string pth = path;
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Please setup your Stable Diffusion location");
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    pth = fbd.SelectedPath;

                    string envfolder = new DirectoryInfo(System.IO.Directory.GetParent(pth).ToString()).Name;

                    if (envfolder == "envs")
                    {
                        string ename = new DirectoryInfo(pth).Name;
                        envName = ename;
                        AnacondaPath = Directory.GetParent(Directory.GetParent(pth).ToString()).ToString();
                        envpath = pth;
                        SaveEnvPath(envpath);
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
            {
                string envfolder = new DirectoryInfo(System.IO.Directory.GetParent(pth).ToString()).Name;

                if (envfolder == "envs")
                {
                    string ename = new DirectoryInfo(pth).Name;
                    envName = ename;
                    AnacondaPath = Directory.GetParent(Directory.GetParent(pth).ToString()).ToString();
                    envpath = path;
                    return true;
                }
                else
                    return false;
            }
        }


        /// <summary> /////////////////////////////////////////////////////////////////////////////
        ///                          Tabs control
        /// </summary>/////////////////////////////////////////////////////////////////////////////



        private void SwitchTab(EnumTab tab)
        {
            currentTab = tab;

            tabBrowse.IsVisible = currentTab == EnumTab.Browse;
            tabPrompt.IsVisible = currentTab == EnumTab.Prompt;
            tabImage.IsVisible = currentTab == EnumTab.Image;
            tabSequence.IsVisible = currentTab == EnumTab.Sequence;
            tabMorph.IsVisible = currentTab == EnumTab.Morph;

            ChangeTab(buttonTabBrowse, currentTab == EnumTab.Browse, 1);
            ChangeTab(buttonTabPrompt, currentTab == EnumTab.Prompt);
            ChangeTab(buttonTabImage, currentTab == EnumTab.Image);
            ChangeTab(buttonTabSequence, currentTab == EnumTab.Sequence);
            ChangeTab(buttonTabMorph, currentTab == EnumTab.Morph);

        }

        private void ChangeTab(System.Windows.Forms.Button btn, bool enabled, int color =0)
        {

            if (enabled)
            {
                btn.BackColor = Color.FromArgb(20, 60, 30);
            }
            else
            {
                if(color == 0)
                    btn.BackColor = Color.FromArgb(45, 35, 55);
                else if (color == 1)
                    btn.BackColor = Color.FromArgb(35, 45, 65);
            }

        }


        private void buttonTabBrowse_Click(object sender, EventArgs e)
        {
            DrawArea = tabImage.InitImage;
            SwitchTab(EnumTab.Browse);
            tabImage.StopInpaint();
        }

        private void buttonTabPrompt_Click(object sender, EventArgs e)
        {
            DrawArea = tabImage.InitImage;
            SwitchTab(EnumTab.Prompt);
            tabImage.StopInpaint();
            if (!tabImage.isClear)
            {
                SwitchScriptSelector(EnumScript.img2img);
            }
            else
                SwitchScriptSelector(EnumScript.txt2txt);



        }

        private void buttonTabImage_Click(object sender, EventArgs e)
        {
            SwitchTab(EnumTab.Image);
            tabImage.StopInpaint();
            if (!tabImage.isClear)
            {
                tabImage.InitImage = DrawArea;
                SwitchScriptSelector(EnumScript.img2img);
            }
            else
                SwitchScriptSelector(EnumScript.txt2txt);

        }

        private void buttonTabSequence_Click(object sender, EventArgs e)
        {
            DrawArea = tabImage.InitImage;
            SwitchTab(EnumTab.Sequence);
            tabImage.StopInpaint();
            SwitchScriptSelector(EnumScript.imgs2imgs);

        }


        private void buttonTabMorph_Click(object sender, EventArgs e)
        {
            DrawArea = tabImage.InitImage;
            SwitchTab(EnumTab.Morph);
            tabImage.StopInpaint();
            if (!tabImage.isClear)
            {
                tabMorph.Drawing = DrawArea;
                SwitchScriptSelector(EnumScript.imgMorph);
            }
            else
                SwitchScriptSelector(EnumScript.txt2txt);

        }


        
        private void SwitchScriptSelector(EnumScript s)
        {
            currentScript = s;
            switch (s)
            {
                case EnumScript.txt2txt:
                    panelSelectedPrompt.BackColor = Color.FromArgb(20, 60, 30);
                    panelSelectedImage.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedSequence.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedMorph.BackColor = Color.FromArgb(15, 10, 15);
                    break;

                case EnumScript.img2img:
                    panelSelectedPrompt.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedImage.BackColor = Color.FromArgb(20, 60, 30);
                    panelSelectedSequence.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedMorph.BackColor = Color.FromArgb(15, 10, 15);
                    break;

                case EnumScript.imgs2imgs:
                    panelSelectedPrompt.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedImage.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedSequence.BackColor = Color.FromArgb(20, 60, 30);
                    panelSelectedMorph.BackColor = Color.FromArgb(15, 10, 15);
                    break;

                case EnumScript.imgMorph:
                    panelSelectedPrompt.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedImage.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedSequence.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedMorph.BackColor = Color.FromArgb(20, 60, 30);
                    break;

                default:

                    break;
            }
        }




        /// <summary> /////////////////////////////////////////////////////////////////////////////
        ///                          Launch process
        /// </summary>/////////////////////////////////////////////////////////////////////////////


        bool isLaunched = false;
        int sec = 0;

        string lastOutputPath = "";
        // start
        private void buttonStart_Click(object sender, EventArgs e)
        {

            if (!File.Exists(envpath + "\\scripts\\txt2img.py"))
            {
                MessageBox.Show(envpath + "\\scripts\\txt2img.py not found");
                return;
            }
            if (!File.Exists(envpath + "\\scripts\\img2img.py"))
            {
                MessageBox.Show(envpath + "\\scripts\\img2img.py not found");
                return;
            }
            isLaunched = !isLaunched;

            if (isLaunched)
            {
                switch (currentScript)
                {
                    case EnumScript.txt2txt:
                        startText2Image();
                        break;
                    case EnumScript.img2img:
                        startImage2Image();
                        break;
                    case EnumScript.imgs2imgs:
                        startImages2Images();
                        break;
                    case EnumScript.imgMorph:
                        startImage2Morph();
                        break;
                }
                AddToPromptList();
                sec = 0;
                timerSec.Start();
                buttonStart.BackColor = Color.FromArgb(20, 60, 30);
                buttonStart.Image = Resources.stop_button;
                buttonStart.Text = sec.ToString();
            }
            else
            {
                timerSec.Stop();
                buttonStart.BackColor = Color.FromArgb(45, 35, 55);
                buttonStart.Image = Resources.play_button;
                buttonStart.Text = "";
                KillProcessAndChildrens(newProcess.Id);
            }

        }



        // start txt2image script
        private void startText2Image()
        {
            // kill old process
            if (newProcess != null && !newProcess.HasExited)
                KillProcessAndChildrens(newProcess.Id);




            //clean prompt
            textBoxPrompt.Text = Regex.Replace(textBoxPrompt.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Singleline);

            //get env drive letter
            string drive = envpath.Substring(0, 1);


            // seed routine
            string seed = " --seed " + textBoxSeed.Text;

            if (isRandomSeed)
            {
                Random rnd = new Random();
                seed = " --seed " + rnd.Next(1, 100000000);
            }
            else
            {
                if (!IsDigitsOnly(textBoxSeed.Text))
                {
                    seed = " --seed 404";
                    textBoxSeed.Text = "404";
                }
            }
            
            // making prompt with styles
            string text = textBoxPrompt.Text;
            text = text + ", " + tabPrompt.Styles;
            text = " --prompt \"" + text + "\"";

            string size = " --W " + textBoxSizeW.Text + " --H " + textBoxSizeH.Text ;
            string iteration = " --ddim_steps " + labelIteration.Text;

            string n_iter = " --n_iter " + labelN_iter.Text;
            if (trackBarN_iter.Value == 0)
                n_iter = " --n_iter 999999";

            string n_samples = " --n_samples " + labelN_samples.Text;
            string guidance = " --scale " + labelGuidance.Text.Replace(",", "."); ;
            //string channels = " --C " +  labelChannels.Text;
            string channels = "";

            string plms = " --plms";
            if(!isPlmsActivated)
                plms = "";

            string outdir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result";
            System.IO.Directory.CreateDirectory(outdir);
            outdir = outdir + "\\" + tabPrompt.Preset;
            System.IO.Directory.CreateDirectory(outdir);
            outdir = CreateResultDirectory(outdir);
            lastOutputPath = outdir;
            outdir.Replace("\\", "/");
            outdir = " --outdir \"" + outdir + "\"";

            // making python line
            string gen = "python "+ txt2imgPath + text + size + seed + iteration + n_iter + n_samples + guidance + channels + plms + outdir + " --skip_grid ";


            SavePromptInTxtFile(lastOutputPath, textBoxPrompt.Text, tabPrompt.Styles, seed + iteration + n_iter + n_samples + guidance + channels + plms);

            Clipboard.SetText(gen);

            // start script
            psi.UseShellExecute = true;
            //psi.Verb = "runas";
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = @" %windir%\System32\cmd.exe /K " + AnacondaPath + "\\Scripts\\activate.bat " + AnacondaPath + "&conda activate " + envName + "&" + drive + ":&cd " + envpath + "&" + gen;
            try{ newProcess = Process.Start(psi);} catch (Exception) { }

        }

        bool isPlmsActivated = false;
        // start img2image script
        private void startImage2Image()
        {
            //var i = new Bitmap(DrawArea);
            //i.Save(envpath + "\\current.png");

            // kill old process
            if (newProcess != null && !newProcess.HasExited)
                KillProcessAndChildrens(newProcess.Id);

            //clean prompt
            textBoxPrompt.Text = Regex.Replace(textBoxPrompt.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Singleline);

            //get env drive letter
            string drive = envpath.Substring(0, 1);


            // seed routine
            string seed = " --seed " + textBoxSeed.Text;

            if (isRandomSeed)
            {
                Random rnd = new Random();
                seed = " --seed " + rnd.Next(1, 100000000);
            }
            else
            {
                if (!IsDigitsOnly(textBoxSeed.Text))
                {
                    seed = " --seed 404";
                    textBoxSeed.Text = "404";
                }
            }

            // making prompt with styles
            string text = textBoxPrompt.Text;
            text = text + ", " + tabPrompt.Styles;
            text = " --prompt \"" + text + "\"";

            string iteration = " --ddim_steps " + labelIteration.Text;

            string n_iter = " --n_iter " + labelN_iter.Text;
            if (trackBarN_iter.Value == 0)
                n_iter = " --n_iter 999999";

            string n_samples = " --n_samples " + labelN_samples.Text;
            string guidance = " --scale " + labelGuidance.Text.Replace(",", "."); ;
            string channels = " --C " + labelChannels.Text;


            string plms = " --plms";
            if (!isPlmsActivated)
                plms = "";
            string str = " --strength " + ((float)trackBarStrength.Value / 20).ToString(CultureInfo.InvariantCulture);
            string imgpath = envpath + "\\current.png";
            string initImage = "  --init-img " + imgpath;

            string script = img2imgPath;

            string outdir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result";
            System.IO.Directory.CreateDirectory(outdir);
            outdir = outdir + "\\" + tabPrompt.Preset;
            System.IO.Directory.CreateDirectory(outdir);
            outdir = CreateResultDirectory(outdir);
            lastOutputPath = outdir;
            outdir.Replace("\\", "/");
            outdir = " --outdir \"" + outdir + "\"";

            if (tabImage.isFaceRectangleSet)
            {
                imgpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\croped.png";

                initImage = "  --init-img \"" + imgpath + "\"";

                outdir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Crop";
                System.IO.Directory.CreateDirectory(outdir);
                clearFolder(outdir);
                outdir = " --outdir \"" + outdir + "\"";
            }

            // making python line
            string gen = "python "+ script + " --skip_grid " + outdir + text + seed + initImage + iteration + str + n_iter + n_samples + guidance + channels + plms;

            SavePromptInTxtFile(lastOutputPath, textBoxPrompt.Text, tabPrompt.Styles, seed + iteration + n_iter + n_samples + guidance + channels + plms, tabImage.InitImage);

            Clipboard.SetText(gen);

            // start script
            psi.UseShellExecute = true;
            //psi.Verb = "runas";
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = @" %windir%\System32\cmd.exe /K "+AnacondaPath+ "\\Scripts\\activate.bat " + AnacondaPath + "&conda activate "+envName+"&" + drive + ":&cd " + envpath + "&" + gen;
            try{ newProcess = Process.Start(psi);}catch (Exception) { }

        }





        // start imgs2imgs script
        private void startImages2Images()
        {
            // kill old process
            if (newProcess != null && !newProcess.HasExited)
                KillProcessAndChildrens(newProcess.Id);

            //clean prompt
            textBoxPrompt.Text = Regex.Replace(textBoxPrompt.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Singleline);

            //get env drive letter
            string drive = envpath.Substring(0, 1);


            // seed routine
            string seed = " --seed " + textBoxSeed.Text;

            if (isRandomSeed)
            {
                Random rnd = new Random();
                seed = " --seed " + rnd.Next(1, 100000000);
            }
            else
            {
                if (!IsDigitsOnly(textBoxSeed.Text))
                {
                    seed = " --seed 404";
                    textBoxSeed.Text = "404";
                }
            }

            // making prompt with styles
            string text = textBoxPrompt.Text;
            text = text + ", " + tabPrompt.Styles;
            text = " --prompt \"" + text + "\"";

            string iteration = " --ddim_steps " + labelIteration.Text;

            string n_iter = " --n_iter " + labelN_iter.Text;
            if (trackBarN_iter.Value == 0)
                n_iter = " --n_iter 999999";

            string n_samples = " --n_samples " + labelN_samples.Text;
            string guidance = " --scale " + labelGuidance.Text.Replace(",", "."); ;
            string channels = " --C " + labelChannels.Text;

            string plms = " --plms";
            if (!isPlmsActivated)
                plms = "";
            string str = " --strength " + ((float)trackBarStrength.Value / 20).ToString(CultureInfo.InvariantCulture);

            string imgpath = envpath + "\\current.png";
            
            string initImage = "  --init-img " + imgpath.Replace("\\", "/"); 

            //string imgpath = "inputs/sequence/";
            string initDir = "  --inputdir " + imgpath;

            string outdir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result";
            System.IO.Directory.CreateDirectory(outdir);
            outdir = outdir + "\\" + tabPrompt.Preset;
            System.IO.Directory.CreateDirectory(outdir);
            outdir = CreateResultDirectory(outdir);
            lastOutputPath = outdir;
            outdir.Replace("\\", "/");
            outdir = " --outdir \"" + outdir + "\"";

            // making python line
            string gen = "python " + imgs2imgsPath + text + seed + initDir + iteration + str + n_iter + n_samples + guidance + channels + outdir + initImage + plms;

            Clipboard.SetText(gen);

            // start script
            psi.UseShellExecute = true;
            //psi.Verb = "runas";
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = @" %windir%\System32\cmd.exe /K " + AnacondaPath + "\\Scripts\\activate.bat " + AnacondaPath + "&conda activate " + envName + "&" + drive + ":&cd " + envpath + "&" + gen;
            try { newProcess = Process.Start(psi); } catch (Exception) { }

        }



        private void startImage2Morph()
        {
            var i = new Bitmap(DrawArea);
            i.Save(envpath + "\\current.png");

            // kill old process
            if (newProcess != null && !newProcess.HasExited)
                KillProcessAndChildrens(newProcess.Id);

            //clean prompt
            textBoxPrompt.Text = Regex.Replace(textBoxPrompt.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Singleline);

            //get env drive letter
            string drive = envpath.Substring(0, 1);


            // seed routine
            string seed = " --seed " + textBoxSeed.Text;

            if (isRandomSeed)
            {
                Random rnd = new Random();
                seed = " --seed " + rnd.Next(1, 100000000);
            }
            else
            {
                if (!IsDigitsOnly(textBoxSeed.Text))
                {
                    seed = " --seed 404";
                    textBoxSeed.Text = "404";
                }
            }

            // making prompt with styles
            string text = textBoxPrompt.Text;
            text = text + ", " + tabPrompt.Styles;
            text = " --prompt \"" + text + "\"";

            string iteration = " --ddim_steps " + labelIteration.Text;

            string n_iter = " --n_iter 1";
            string n_samples = " --n_samples 1";

            string guidance = " --scale " + labelGuidance.Text.Replace(",", "."); ;
            string channels = " --C " + labelChannels.Text;


            string plms = " --plms";
            if (!isPlmsActivated)
                plms = "";
            string str = " --strength " + ((float)trackBarStrength.Value / 20).ToString(CultureInfo.InvariantCulture);
            string imgpath = envpath + "\\current.png";
            string initImage = "  --init-img " + imgpath;

            string tx = " --tx " + tabMorph.TX;
            string ty = " --ty " + tabMorph.TY;
            string angle = " --angle " + tabMorph.Angle;
            string zoom = " --zoom " + tabMorph.Zoom;

            string script = img2imgPath;


            script = img2morphPath;


            string outdir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result";
            System.IO.Directory.CreateDirectory(outdir);
            outdir = outdir + "\\" + tabPrompt.Preset;
            System.IO.Directory.CreateDirectory(outdir);
            outdir = CreateResultDirectory(outdir);
            lastOutputPath = outdir;
            outdir.Replace("\\", "/");
            outdir = " --outdir \"" + outdir + "\"";

            // making python line
            string gen = "python " + script + " --skip_grid " +tx + ty + angle + zoom + outdir + text + seed + initImage + iteration + str + n_iter + n_samples + guidance + channels + plms;

            SavePromptInTxtFile(lastOutputPath, textBoxPrompt.Text, tabPrompt.Styles, seed + iteration + n_iter + n_samples + guidance + channels + plms, (Bitmap)DrawArea.Clone());

            Clipboard.SetText(gen);

            // start script
            psi.UseShellExecute = true;
            //psi.Verb = "runas";
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = @" %windir%\System32\cmd.exe /K " + AnacondaPath + "\\Scripts\\activate.bat " + AnacondaPath + "&conda activate " + envName + "&" + drive + ":&cd " + envpath + "&" + gen;
            try { newProcess = Process.Start(psi); } catch (Exception) { }

        }




        // Timer
        private void timerSec_Tick(object sender, EventArgs e)
        {
            buttonStart.Text = sec.ToString();
            buttonStart.Image = Resources.stop_button;
            sec++;

            newProcess.Refresh();  // Important
            if (newProcess.HasExited)
            {
                timerSec.Stop();
                buttonStart.BackColor = Color.FromArgb(45, 35, 55);
                buttonStart.Text = "";
                buttonStart.Image = Resources.play_button;
                isLaunched = false;
            }
        }





        // open outputs folder
        private void buttonOutFolder_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(lastOutputPath))
            {
                string outdir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result";
                outdir = outdir + "\\" + tabPrompt.Preset;
                System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", outdir);
            }
            else
            {

                System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", lastOutputPath);
            }


        }


        private void buttonClearImage_Click(object sender, EventArgs e)
        {
            tabImage.ClearImage();
            if (currentTab == EnumTab.Image || currentTab == EnumTab.Morph)
            {
                SwitchScriptSelector(EnumScript.txt2txt);
            }
        }



        bool isRandomSeed = false;
        private void buttonSeed_Click(object sender, EventArgs e)
        {
            isRandomSeed = !isRandomSeed;
            if (isRandomSeed)
            {
                buttonSeed.BackColor = Color.FromArgb(20, 60, 30);
                textBoxSeed.Enabled = false;
                textBoxSeed.Text = "Random";
            }
            else
            {
                buttonSeed.BackColor = Color.FromArgb(40, 30, 50);
                textBoxSeed.Enabled = true;
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


            if (trackBarN_iter.Value == 0)
            {
                trackBarN_iter.Value = trackBarN_iter.Maximum;
            }
            else if (trackBarN_iter.Value == 10)
            {
                trackBarN_iter.Value = 0;
            }
            else
            {
                trackBarN_iter.Value = 0;
            }

        }



        private void buttonN_samples_Click(object sender, EventArgs e)
        {
            trackBarN_samples.Value = 4;
        }

        private void buttonGuidance_Click(object sender, EventArgs e)
        {
            trackBarGuidance.Value = 15;
        }

        private void buttonChannels_Click(object sender, EventArgs e)
        {
            trackBarChannels.Value = 4;
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
                if (trackBarN_iter.Value == 0)
                {
                    labelN_iter.Text = "∞";
                }
                else
                {
                    labelN_iter.Text = trackBarN_iter.Value.ToString();
                }
            }
            else if (sender == trackBarN_samples)
            {
                string value = (trackBarN_samples.Value).ToString();
                labelN_samples.Text = value;
            }
            else if (sender == trackBarGuidance)
            {
                string value = ((float)trackBarGuidance.Value / 2).ToString();
                labelGuidance.Text = value;
            }
            else if (sender == trackBarChannels)
            {
                string value = (trackBarChannels.Value * 4).ToString();
                labelChannels.Text = value;
            }
            else if (sender == trackBarStrength)
            {
                string value = ((float)trackBarStrength.Value / 20).ToString();
                labelStrength.Text = value;
            }
        }



        // save settings
        private void buttonSave_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    SaveSeed(textBoxSeed.Text);
                    SaveIteration(trackBarIteration.Value);
                    SaveN_iter(trackBarN_iter.Value);
                    SaveN_samples(trackBarN_samples.Value);
                    SaveGuidance(trackBarGuidance.Value);
                    SaveChannels(trackBarChannels.Value);
                    SaveStrength(trackBarStrength.Value);

                    SavePrompt(textBoxPrompt.Text);
                    SaveSelectedStyles(tabPrompt.listboxSelected);


                    System.Media.SystemSounds.Hand.Play();
                    break;

                case MouseButtons.Right:
                    //OpenWithDefaultProgram("Settings.ini");
                    break;
            }
        }







        private void buttonSavePrompt_Click(object sender, EventArgs e)
        {
            SavePrompt(textBoxPrompt.Text);

        }

        private void buttonDonate_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.paypal.com/paypalme/Fictiverse");
        }




        private void buttonOpenSettings_Click(object sender, EventArgs e)
        {
            OpenWithDefaultProgram("Settings.ini");
        }



        public void ScreenshotTaken(Bitmap img)
        {
            tabImage.InitImage = (Bitmap)ResizeImage(img, new Size(512, 512));
            //MessageBox.Show("dd");
            // Do whatever you need to do with the string
        }



        private void textBoxPrompt_Validated(object sender, EventArgs e)
        {
            AddToPromptList();
        }

        int iPromptList = 0;
        private void buttonText_Click(object sender, EventArgs e)
        {
            if (promptsList.Count > iPromptList)
            {
                textBoxPrompt.Text = promptsList[iPromptList];
                iPromptList++;
            }
            else
            {
                iPromptList = 0;
                if (promptsList.Count > 0)
                {
                    textBoxPrompt.Text = promptsList[0];
                }


            }

            if (promptsList.Count > 5)
            {
                promptsList.Remove(promptsList[0]);
            }


        }

        private void AddToPromptList()
        {
            if (textBoxPrompt.Text.Any(x => !char.IsLetter(x)))
            {
                promptsList.Add(textBoxPrompt.Text);
                RemoveListDuplicate(promptsList);
            }

        }


        List<string> promptsList = new List<string>();

        private void buttonClearText_Click(object sender, EventArgs e)
        {
            AddToPromptList();
            textBoxPrompt.Clear();
        }











        int shape = 0;
        private void buttonSizeShape_Click(object sender, EventArgs e)
        {
            shape++;

            switch (shape)
            {
                case 0:
                    buttonSizeShape.Image = Resources.rounded_black_square_shapeS_;
                    textBoxSizeW.Text = "512";
                    textBoxSizeH.Text = "512";
                    break;
                case 1:
                    buttonSizeShape.Image = Resources.rounded_rectangleH;
                    textBoxSizeW.Text = "320";
                    textBoxSizeH.Text = "640";
                    break;
                case 2:
                    buttonSizeShape.Image = Resources.rounded_black_square_shapeS_;
                    textBoxSizeW.Text = "512";
                    textBoxSizeH.Text = "512";
                    break;
                case 3:
                    buttonSizeShape.Image = Resources.rounded_rectangleV;
                    textBoxSizeW.Text = "640";
                    textBoxSizeH.Text = "320";
                    break;
                default:
                    buttonSizeShape.Image = Resources.rounded_black_square_shapeS_;
                    textBoxSizeW.Text = "512";
                    textBoxSizeH.Text = "512";
                    shape = 0;
                    break;


            }
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            textBoxSizeW.Text = "512";
            textBoxSizeH.Text = "512";
        }

        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxSize_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            int value = Int32.Parse((sender as System.Windows.Forms.TextBox).Text);

            int factor = 64;
            int nearestMultiple = Math.Max( (int)Math.Round((value / (double)factor),MidpointRounding.AwayFromZero) * factor, factor);
            (sender as System.Windows.Forms.TextBox).Text = nearestMultiple.ToString();
        }


    }
}