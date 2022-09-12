using StableDiffusion.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Channels;
using System.Windows.Forms;
using static StableDiffusion.iniAccess;
using static StableDiffusion.myFunctions;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Application = System.Windows.Forms.Application;
using File = System.IO.File;

namespace StableDiffusion
{


    public enum EnumTab {Settings, Browse, Prompt, Image, Sequence, Morph}

    public enum EnumScript {txt2img, img2img, imgs2imgs, imgMorph}



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

        Bitmap initImage = new Bitmap(512, 512);


        string separator = ", ";


        bool isPlmsActivated = false;


        bool showConsole = false;

        public Form1()
        {
            InitializeComponent();

            // init form visuals            
            //this.Size = new Size(1043, 823);


            tabBrowse.Location = tabSettings.Location;
            this.Controls.Add(tabBrowse);

            tabPrompt.Location = tabSettings.Location;
            this.Controls.Add(tabPrompt);

            tabImage.Location = tabSettings.Location;
            this.Controls.Add(tabImage);

            tabSequence.Location = tabSettings.Location;
            this.Controls.Add(tabSequence);

            tabMorph.Location = tabSettings.Location;
            this.Controls.Add(tabMorph);


            SwitchTab(EnumTab.Prompt);

            // init default values

            bool isEnvValid = false;


            textBoxAnacondaPath.Text = LoadAnacondaPath();
            textBoxEnvName.Text = LoadEnvName();
            textBoxEnvPath.Text = LoadEnvPath();

            textBoxTxt2imgScript.Text = LoadTxt2imgPath();
            textBoxImg2imgScript.Text = LoadImg2imgPath();
            textBoxImgs2imgsScript.Text = LoadImgs2imgsPath();
            textBoxImg2MorphScript.Text = LoadImg2morphPath();

            showConsole = LoadShowConsole();

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

            trackBarSteps.Value = ClampTrackbar(trackBarSteps, LoadIteration());
            trackBarN_iter.Value = ClampTrackbar(trackBarN_iter, LoadN_iter());
            trackBarN_samples.Value = ClampTrackbar(trackBarN_samples, LoadN_samples());
            trackBarGuidance.Value = ClampTrackbar(trackBarGuidance, LoadGuidance());
            trackBarChannels.Value = ClampTrackbar(trackBarChannels, LoadChannels());
            trackBarStrength.Value = ClampTrackbar(trackBarStrength, LoadStrength());



            //MessageBox.Show(trackBarN_samples.Value.ToString());
            labelIteration.Text = (trackBarSteps.Value * 25).ToString();

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
            selectedPreset = tabPrompt.Preset.ToString();
            tabBrowse.SelectPreset(selectedPreset);
        }

        protected void ImageClearEvent(object sender, EventArgs e)
        {
            if (currentScript == EnumScript.img2img || currentScript == EnumScript.imgMorph)
            {
                SwitchScriptSelector(EnumScript.txt2img);
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
                    trackBarSteps.Value = ClampTrackbar(trackBarSteps, LoadIteration());
                }
                else if (s[i] == "--n_iter")
                {
                    n_iter = s[i + 1];
                    int value = (int)ConvertStringToInt(n_iter);
                    trackBarN_iter.Value = ClampTrackbar(trackBarN_iter, LoadN_iter());
                }
                else if (s[i] == "--n_samples")
                {
                    n_samples = s[i + 1];
                    int value = Convert.ToInt16(ConvertStringToInt(n_samples));
                    trackBarN_samples.Value = ClampTrackbar(trackBarN_samples, LoadN_samples());
                }
                else if (s[i] == "--scale")
                {
                    scale = s[i + 1].Replace(".", ",");
                    int value = Convert.ToInt16(Convert.ToDouble(scale) * 2);
                    trackBarGuidance.Value = ClampTrackbar(trackBarGuidance, LoadGuidance());
                }
                else if (s[i] == "--C")
                {
                    scale = s[i + 1];
                    int value = Convert.ToInt16(Convert.ToDouble(scale) * 2);
                    trackBarChannels.Value = ClampTrackbar(trackBarChannels, LoadChannels());
                }
            }




        }
        protected void NewInitImageAdded(object sender, EventArgs e)
        {
            SwitchTab(EnumTab.Image);
            tabImage.RefreshInitImagesList();
        }











        private void buttonBrowseAnacondaPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = textBoxAnacondaPath.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxAnacondaPath.Text = fbd.SelectedPath;
                SaveAnacondaPath(textBoxAnacondaPath.Text);
            }
        }

        private void buttonBrowseEnvs_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = textBoxAnacondaPath.Text + "\\envs\\";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxEnvName.Text = new DirectoryInfo(fbd.SelectedPath).Name;
                SaveEnvName(textBoxEnvName.Text);
                if (textBoxEnvPath.Text.Length == 0)
                {
                    textBoxEnvPath.Text = fbd.SelectedPath;
                    SaveEnvPath(textBoxEnvPath.Text);
                }
            }
        }

        private void buttonBrowseEnvPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = textBoxAnacondaPath.Text + "\\envs\\";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxEnvPath.Text = fbd.SelectedPath;
                SaveEnvPath(textBoxEnvPath.Text);
            }
        }


        private void buttonBrowseTxt2imgScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = textBoxEnvPath.Text + "\\Scripts\\";
            fd.Filter = "Python script (*.py)|*.py";
            fd.Title = "Please select the txt2txt.py file";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBoxTxt2imgScript.Text = fd.FileName;
                SaveTxt2imgPath(textBoxTxt2imgScript.Text);
            }

        }

        private void buttonBrowseImg2imgScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = textBoxEnvPath.Text + "\\Scripts\\";
            fd.Filter = "Python script (*.py)|*.py";
            fd.Title = "Please select the txt2txt.py file";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBoxImg2imgScript.Text = fd.FileName;
                SaveImg2imgPath(textBoxImg2imgScript.Text);
            }
        }

        private void buttonBrowseImgs2imgsScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = textBoxEnvPath.Text + "\\Scripts\\";
            fd.Filter = "Python script (*.py)|*.py";
            fd.Title = "Please select the txt2txt.py file";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBoxImgs2imgsScript.Text = fd.FileName;
                SaveImgs2imgsPath(textBoxImgs2imgsScript.Text);
            }
        }

        private void buttonBrowseImg2morphScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = textBoxEnvPath.Text + "\\Scripts\\";
            fd.Filter = "Python script (*.py)|*.py";
            fd.Title = "Please select the txt2txt.py file";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBoxImg2MorphScript.Text = fd.FileName;
                SaveImg2morphPath(textBoxImg2MorphScript.Text);
            }
        }




        /// <summary> /////////////////////////////////////////////////////////////////////////////
        ///                          Tabs control
        /// </summary>/////////////////////////////////////////////////////////////////////////////



        private void SwitchTab(EnumTab tab)
        {
            currentTab = tab;

            tabSettings.Visible = currentTab == EnumTab.Settings;
            tabBrowse.IsVisible = currentTab == EnumTab.Browse;
            tabPrompt.IsVisible = currentTab == EnumTab.Prompt;
            tabImage.IsVisible = currentTab == EnumTab.Image;
            tabSequence.IsVisible = currentTab == EnumTab.Sequence;
            tabMorph.IsVisible = currentTab == EnumTab.Morph;

            ChangeTab(buttonSettings, currentTab == EnumTab.Settings);
            ChangeTab(buttonTabBrowse, currentTab == EnumTab.Browse, 1);
            ChangeTab(buttonTabPrompt, currentTab == EnumTab.Prompt);
            ChangeTab(buttonTabImage, currentTab == EnumTab.Image);
            ChangeTab(buttonTabSequence, currentTab == EnumTab.Sequence);
            ChangeTab(buttonTabMorph, currentTab == EnumTab.Morph);

        }

        private void ChangeTab(System.Windows.Forms.Button btn, bool enabled, int color = 0)
        {

            if (enabled)
            {
                btn.BackColor = Color.FromArgb(20, 60, 30);
            }
            else
            {
                if (color == 0)
                    btn.BackColor = Color.FromArgb(45, 35, 55);
                else if (color == 1)
                    btn.BackColor = Color.FromArgb(35, 45, 65);
            }

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            initImage = tabImage.InitImage;
            SwitchTab(EnumTab.Settings);
        }

        private void buttonTabBrowse_Click(object sender, EventArgs e)
        {
            initImage = tabImage.InitImage;
            SwitchTab(EnumTab.Browse);
        }

        private void buttonTabPrompt_Click(object sender, EventArgs e)
        {
            initImage = tabImage.InitImage;
            SwitchTab(EnumTab.Prompt);
            tabImage.StopInpaint();
            if (!tabImage.isClear)
            {
                SwitchScriptSelector(EnumScript.img2img);
            }
            else
                SwitchScriptSelector(EnumScript.txt2img);



        }

        private void buttonTabImage_Click(object sender, EventArgs e)
        {
            SwitchTab(EnumTab.Image);
            tabImage.StopInpaint();
            if (!tabImage.isClear)
            {
                tabImage.InitImage = initImage;
                SwitchScriptSelector(EnumScript.img2img);
            }
            else
                SwitchScriptSelector(EnumScript.txt2img);

        }

        private void buttonTabSequence_Click(object sender, EventArgs e)
        {
            initImage = tabImage.InitImage;
            SwitchTab(EnumTab.Sequence);
            tabImage.StopInpaint();
            SwitchScriptSelector(EnumScript.imgs2imgs);

        }


        private void buttonTabMorph_Click(object sender, EventArgs e)
        {
            initImage = tabImage.InitImage;
            SwitchTab(EnumTab.Morph);
            tabImage.StopInpaint();
            if (!tabImage.isClear)
            {
                tabMorph.Drawing = initImage;
                SwitchScriptSelector(EnumScript.imgMorph);
            }
            else
                SwitchScriptSelector(EnumScript.txt2img);

        }



        private void SwitchScriptSelector(EnumScript s)
        {
            currentScript = s;
            switch (s)
            {
                case EnumScript.txt2img:
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


        private CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token;
        private async void buttonLaunchAsync_Click(object sender, EventArgs e)
        {
            isLaunched = !isLaunched;
            if (isLaunched)
            {
                sec = 0;

                if (!File.Exists(textBoxAnacondaPath.Text+ "\\Scripts\\activate.bat"))
                {
                    MessageBox.Show(textBoxAnacondaPath.Text + "\\Scripts\\activate.bat not found!\nPlease locate a proper Anaconda/Miniconda directory.", "Invalid Anaconda Path",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SwitchTab(EnumTab.Settings);
                    textBoxAnacondaPath.Focus();
                    isLaunched = false;
                    return;
                }
                if (!System.IO.Directory.Exists(textBoxEnvPath.Text))
                {
                    MessageBox.Show("Stable Diffusion folder not found, please locate the directory.");
                    SwitchTab(EnumTab.Settings);
                    textBoxEnvName.Focus();
                    isLaunched = false;

                    return;
                }
                switch (currentScript)
                {
                    case EnumScript.txt2img:
                        if (!File.Exists(textBoxTxt2imgScript.Text))
                        {
                            MessageBox.Show(textBoxTxt2imgScript.Text + " not found, please locate the txt2img script.", "txt2img script not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SwitchTab(EnumTab.Settings);
                            textBoxTxt2imgScript.Focus();
                            isLaunched = false;
                            return;
                        }
                        break;
                    case EnumScript.img2img:
                        if (!File.Exists(textBoxImg2imgScript.Text))
                        {
                            MessageBox.Show(textBoxImg2imgScript.Text + " not found, please locate the img2img.py script.");
                            SwitchTab(EnumTab.Settings);
                            textBoxImg2imgScript.Focus();
                            isLaunched = false;
                            return;
                        }
                        break;
                    case EnumScript.imgs2imgs:
                        if (!File.Exists(textBoxImgs2imgsScript.Text))
                        {
                            MessageBox.Show(textBoxImgs2imgsScript.Text + " not found, please locate the img2img.py script.");
                            SwitchTab(EnumTab.Settings);
                            textBoxImgs2imgsScript.Focus();
                            isLaunched = false;
                            return;
                        }
                        break;
                    case EnumScript.imgMorph:
                        if (!File.Exists(textBoxImg2MorphScript.Text))
                        {
                            MessageBox.Show(textBoxImg2MorphScript.Text + " not found, please locate the img2img.py script.");
                            SwitchTab(EnumTab.Settings);
                            textBoxImg2MorphScript.Focus();
                            isLaunched = false;
                            return;
                        }
                        break;
                }


                AddToPromptList();
                buttonLaunchAsync.BackColor = Color.FromArgb(20, 60, 30);
                buttonLaunchAsync.Image = Resources.stop_button;


                CheckForIllegalCrossThreadCalls = false;


                cts.Dispose();
                cts = new CancellationTokenSource();
                token = cts.Token;

                string args = "";

                args = PrepareScriptAndGetArgs();
                await AsyncLaunch(args, token);

            }
            else
            {
                if (cts != null)
                    cts.Cancel();

                richTextBoxConsole.Clear();
                buttonLaunchAsync.BackColor = Color.FromArgb(45, 35, 55);
                buttonLaunchAsync.Image = Resources.play_button;
                buttonLaunchAsync.Text = "";
            }




        }

        public Task AsyncLaunch(string args, CancellationToken token)
        {
            Task t1 = Task.Run(async () =>
            {
                Process process = new Process();

                Thread.Sleep(200);
                try
                {
                    var processStartInfo = new ProcessStartInfo(@"C:\Windows\System32\cmd.exe", args);

                    processStartInfo.ErrorDialog = false;
                    processStartInfo.UseShellExecute = false;
                    processStartInfo.RedirectStandardError = true;
                    processStartInfo.RedirectStandardInput = true;
                    processStartInfo.RedirectStandardOutput = true;
                    processStartInfo.CreateNoWindow = !showConsole;
                    //Execute the process

                    process.StartInfo = processStartInfo;

                    //process.OutputDataReceived += (sender, args) => UpdateText(args.Data);
                    //process.ErrorDataReceived += (sender, args) => UpdateErrorText(args.Data);
                    process.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
                    process.ErrorDataReceived += new DataReceivedEventHandler(SortErrorHandler);
                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    while (true)
                    {
                        token.ThrowIfCancellationRequested();
                        Thread.Sleep(100);

                    }
                    //process.WaitForExit();

                }
                catch (OperationCanceledException)
                {
                    KillProcessAndChildrens(process.Id);
                    Thread.Sleep(200);
                }
                catch (Exception ex)
                {
                    richTextBoxConsole.Text = ex.Message;
                }
            },
            token);
            return Task.CompletedTask;
        }




        private string PrepareScriptAndGetArgs()
        {
            string textScript = currentScript.ToString();
            if (tabImage.isFaceRectangleSet)
                textScript = textScript + " Crop";
            richTextBoxConsole.Clear();
            richTextBoxConsole.AppendText("Starting : " + textScript);
            richTextBoxConsole.AppendText(Environment.NewLine);

            string script = "";
            switch (currentScript)
            {
                case EnumScript.txt2img:
                    script = textBoxTxt2imgScript.Text;
                    break;
                case EnumScript.img2img:
                    script = textBoxImg2imgScript.Text;
                    break;
                case EnumScript.imgs2imgs:
                    script = textBoxImgs2imgsScript.Text;
                    break;
                case EnumScript.imgMorph:
                    script = textBoxImg2MorphScript.Text;
                    break;
            }


            // seed
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

            // prompt + styles
            textBoxPrompt.Text = Regex.Replace(textBoxPrompt.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Singleline);

            string prompt = textBoxPrompt.Text;
            prompt = prompt + ", " + tabPrompt.Styles;
            prompt = " --prompt \"" + prompt.Replace("\"", "") + "\"";

            // Size
            string size = "";
            if (currentScript == EnumScript.txt2img)
                size = " --W " + textBoxSizeW.Text + " --H " + textBoxSizeH.Text;

            //steps
            string iteration = " --ddim_steps " + labelIteration.Text;

            // N_iter
            string n_iter = " --n_iter " + labelN_iter.Text;
            if (trackBarN_iter.Value == 0)
                n_iter = " --n_iter 999999";

            // N_samples
            string n_samples = " --n_samples " + labelN_samples.Text;

            // N scale
            string guidance = " --scale " + labelGuidance.Text.Replace(",", "."); ;

            // Channels
            string channels = " --C " + labelChannels.Text;
            if (currentScript == EnumScript.txt2img)
                channels = "";

            // Strength
            string strength = " --strength " + ((float)trackBarStrength.Value / 20).ToString(CultureInfo.InvariantCulture);
            if (currentScript == EnumScript.txt2img)
                strength = "";

            // Plms
            string plms = "";
            if (isPlmsActivated)
                plms = " --plms";

            // Init Image
            string initImage = "  --init-img " + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\initimage.png";
            if (currentScript == EnumScript.txt2img)
                initImage = "";

            // Outdir
            string outdir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result";
            System.IO.Directory.CreateDirectory(outdir);
            outdir = outdir + "\\" + tabPrompt.Preset;
            System.IO.Directory.CreateDirectory(outdir);
            outdir = CreateResultDirectory(outdir);
            lastOutputPath = outdir;
            outdir = " --outdir \"" + outdir + "\"";


            // Morph specific args
            string morphArgs = "";
            if (currentScript == EnumScript.imgMorph)
            {
                string tx = " --tx " + tabMorph.TX;
                string ty = " --ty " + tabMorph.TY;
                string angle = " --angle " + tabMorph.Angle;
                string zoom = " --zoom " + tabMorph.Zoom;
                morphArgs = tx + ty + angle + zoom;
            }



            // InpaintZone enabled
            if (currentScript == EnumScript.img2img && tabImage.isFaceRectangleSet)
            {
                // N_iter
                n_iter = " --n_iter 4";

                // N_samples
                n_samples = " --n_samples 1";

                // Init Image
                initImage = "  --init-img \""
                    + (System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\croped.png")
                    + "\"";

                string cropOutDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Crop";
                System.IO.Directory.CreateDirectory(cropOutDir);
                clearFolder(cropOutDir);

                outdir = " --outdir \"" + cropOutDir + "\"";
            }


            // save settings to output folder
            if (currentScript == EnumScript.txt2img)
                SavePromptInTxtFile(lastOutputPath, textBoxPrompt.Text, tabPrompt.Styles, seed + iteration + n_iter + n_samples + guidance + channels + plms);
            else
                SavePromptInTxtFile(lastOutputPath, textBoxPrompt.Text, tabPrompt.Styles, seed + iteration + n_iter + n_samples + guidance + channels + plms, tabImage.InitImage);



            // making cmd args
            string gen = "python " + script + prompt + size + seed + iteration + n_iter + n_samples + guidance + channels + strength + plms + outdir + initImage + morphArgs + " --skip_grid ";

            //Clipboard.SetText(gen);

            string drive = textBoxEnvPath.Text.Substring(0, 1);

            string args = @" %windir%\System32\cmd.exe /K "
            + textBoxAnacondaPath.Text + "\\Scripts\\activate.bat "
            + textBoxAnacondaPath.Text + "&conda activate " + textBoxEnvName.Text
            + "&" + drive + ":&cd " + textBoxEnvPath.Text + "&" + gen;

            return args;
        }




        void SortOutputHandler(object sender, DataReceivedEventArgs e)
        {
            if (isLaunched)
            {
                Trace.WriteLine(e.Data);
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    richTextBoxConsole.SelectionColor = Color.White;
                    richTextBoxConsole.AppendText((Environment.NewLine + e.Data) ?? string.Empty);
                }));
            }
            else
            {
                richTextBoxConsole.Text = "Stopped";
            }

        }
        void SortErrorHandler(object sender, DataReceivedEventArgs e)
        {
            if (isLaunched)
            {
                Trace.WriteLine(e.Data);
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    richTextBoxConsole.SelectionColor = Color.Yellow;
                    richTextBoxConsole.AppendText((Environment.NewLine + e.Data) ?? string.Empty);
                }));
                if (richTextBoxConsole.Text.Contains("Enjoy"))
                {
                    if (cts != null)
                    {
                        cts.Cancel();
                        richTextBoxConsole.Clear();
                        //MessageBox.Show(cts.IsCancellationRequested.ToString());
                    }
                    //cts.CancelAfter(TimeSpan.FromSeconds(1));
                    buttonLaunchAsync.BackColor = Color.FromArgb(45, 35, 55);
                    buttonLaunchAsync.Image = Resources.play_button;
                    buttonLaunchAsync.Text = "Completed";
                    isLaunched = false;
                }
                if (richTextBoxConsole.Text.Contains("EnvironmentNameNotFound"))
                {
                    if (cts != null)
                    {
                        cts.Cancel();
                        richTextBoxConsole.Clear();
                        //MessageBox.Show(cts.IsCancellationRequested.ToString());
                    }
                    //cts.CancelAfter(TimeSpan.FromSeconds(1));
                    buttonLaunchAsync.BackColor = Color.FromArgb(45, 35, 55);
                    buttonLaunchAsync.Image = Resources.play_button;
                    buttonLaunchAsync.Text = "EnvironmentNameNotFound";
                    isLaunched = false;

                    MessageBox.Show(textBoxEnvName.Text + " is not a valid Anaconda Environment name !\n You can list all the valids envs typing \"conda info --envs\" on Anaconda Powershell Prompt", "Invalid Environment name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SwitchTab(EnumTab.Settings);
                    textBoxAnacondaPath.Focus();

                }
            }
            else
            {
                richTextBoxConsole.Text = "Stopped";
            }

        }



        // Timer
        private void timerSec_Tick(object sender, EventArgs e)
        {
            buttonLaunchAsync.Text = sec.ToString();
            buttonLaunchAsync.Image = Resources.stop_button;
            sec++;
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
                SwitchScriptSelector(EnumScript.txt2img);
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

        private void buttonSteps_Click(object sender, EventArgs e)
        {
            trackBarSteps.Value = 2;
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

            if (sender == trackBarSteps)
            {
                string value = (trackBarSteps.Value * 25).ToString();
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
                    SaveIteration(trackBarSteps.Value);
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

        private void richTextBoxConsole_TextChanged(object sender, EventArgs e)
        {
            richTextBoxConsole.SelectionStart = richTextBoxConsole.Text.Length;
            richTextBoxConsole.ScrollToCaret();
        }










































        /*
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
                //get env drive letter
                drive = envpath.Substring(0, 1);
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
            //get env drive letter
            drive = envpath.Substring(0, 1);
            return true;
        }
        else
            return false;
    }
}
*/




    }
}