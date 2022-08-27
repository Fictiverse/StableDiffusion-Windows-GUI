using StableDiffusion.Properties;
using System;
using System.Diagnostics;
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
    public partial class Form1 : Form
    {



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
            this.Size = new Size(1043, 743);




            // init default values

            bool isEnvValid = false;

            envpath = LoadEnvPath();
            while (!isEnvValid)
            {
                isEnvValid = IsEnvPathValid(envpath);
            }

            //txt2imgPath = LoadTxt2imgPath();
            //img2imgPath = LoadImg2imgPath();
            //inpaintPath= LoadInpaintPath();

            lastOutputPath =  System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result";

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

            trackBarIteration.Value = ClampTrackbar(LoadIteration(), trackBarIteration.Minimum, trackBarIteration.Maximum, trackBarIteration.Value);
            trackBarN_iter.Value = ClampTrackbar(LoadN_iter(), trackBarN_iter.Minimum, trackBarN_iter.Maximum, trackBarN_iter.Value);
            trackBarN_samples.Value = ClampTrackbar(LoadN_samples(), trackBarN_samples.Minimum, trackBarN_samples.Maximum, trackBarN_samples.Value);
            trackBarGuidance.Value = ClampTrackbar(LoadGuidance(), trackBarGuidance.Minimum, trackBarGuidance.Maximum, trackBarGuidance.Value);
            trackBarChannels.Value = ClampTrackbar(LoadChannels(), trackBarChannels.Minimum, trackBarChannels.Maximum, trackBarChannels.Value);
            trackBarStrength.Value = ClampTrackbar(LoadStrength(), trackBarStrength.Minimum, trackBarStrength.Maximum, trackBarStrength.Value);

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





            listBoxPreset.Items.Clear();
            List<string> presets = LoadPresets();
            foreach (var str in presets)
                listBoxPreset.Items.Add(str);

            listBoxGenericStyles.Items.Clear();
            List<string> gStyles = LoadGenericStyles();
            foreach (var str in gStyles)
                listBoxGenericStyles.Items.Add(str);

            listBoxSelectedStyles.Items.Clear();
            List<string> sStyles = LoadSelectedStyles();
            foreach (var str in sStyles)
                listBoxSelectedStyles.Items.Add(str);

            // init default tab
            SelectedPanelTab = panelTabPrompt;


            // init drawing area
            using (Graphics graph = Graphics.FromImage(DrawArea))
            {
                Rectangle ImageSize = new Rectangle(0, 0, 512, 512);
                graph.FillRectangle(Brushes.Black, ImageSize);
            }
            pictureBox1.Image = DrawArea;



            // init Gradiant
            Color c = Color.Gray;
            Graphics g = panelGradiant.CreateGraphics();
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(panelGradiant.ClientRectangle, Color.Black, Color.White, 0.0);
            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Black, c, Color.White };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };
            linearGradientBrush.InterpolationColors = cblend;
            g.FillRectangle(linearGradientBrush, panelGradiant.ClientRectangle);


            // mousewheel events
            this.pictureBox1.MouseWheel += new MouseEventHandler(pictureBox1_MouseWheel);
            this.pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseWheel);


            // init images folders
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages");
            String path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\InitImages";

            string[] subdirs = Directory.GetDirectories(path);
            foreach (string dir in subdirs)
            {
                string new_string = dir.Split('\\').Last();
                listBoxInitImages.Items.Add(new_string);
            }
            listViewInitImages.View = View.Details;


            //populateInitImages();



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

        bool TabPrompt = true;
        bool TabImage = false;
        bool TabSequence = false;
        bool TabMorph = false;

        bool isTabSequenceSelected = false;
        bool isTabMorphSelected = false;
        Panel SelectedPanelTab = new Panel();



        private void buttonTabPrompt_Click(object sender, EventArgs e)
        {
            TabPrompt = true;
            TabImage = false;
            TabSequence = false;
            TabMorph = false;

            switchTab(buttonTabPrompt, TabPrompt);
            switchTab(buttonTabImage, TabImage);
            switchTab(buttonTabSequence, TabSequence);
            switchTab(buttonTabMorph, TabMorph);

            switchTabPosition(SelectedPanelTab, panelTabPrompt);

            SelectedPanelTab = panelTabPrompt;
            if (isInpainting)
            {
                StopInpaint();
            }

            if (!isDrawingClear)
                SwitchScriptSelector(1);
            else
                SwitchScriptSelector(0);

        }

        private void buttonTabImage_Click(object sender, EventArgs e)
        {
            TabPrompt = false;
            TabImage = true;
            TabSequence = false;
            TabMorph = false;

            switchTab(buttonTabPrompt, TabPrompt);
            switchTab(buttonTabImage, TabImage);
            switchTab(buttonTabSequence, TabSequence);
            switchTab(buttonTabMorph, TabMorph);

            switchTabPosition(SelectedPanelTab, panelTabImages);

            SelectedPanelTab = panelTabImages;

            if (!isDrawingClear)
                SwitchScriptSelector(1);
            else
                SwitchScriptSelector(0);


        }

        private void buttonTabSequence_Click(object sender, EventArgs e)
        {
            TabPrompt = false;
            TabImage = false;
            TabSequence = true;
            TabMorph = false;

            switchTab(buttonTabPrompt, TabPrompt);
            switchTab(buttonTabImage, TabImage);
            switchTab(buttonTabSequence, TabSequence);
            switchTab(buttonTabMorph, TabMorph);

            switchTabPosition(SelectedPanelTab, panelTabSequence);

            SelectedPanelTab = panelTabSequence;

            if (isInpainting)
            {
                StopInpaint();
            }


            SwitchScriptSelector(2);


        }


        private void buttonTabMorph_Click(object sender, EventArgs e)
        {
            TabPrompt = false;
            TabImage = false;
            TabSequence = false;
            TabMorph = true;

            switchTab(buttonTabPrompt, TabPrompt);
            switchTab(buttonTabImage, TabImage);
            switchTab(buttonTabSequence, TabSequence);
            switchTab(buttonTabMorph, TabMorph);

            switchTabPosition(SelectedPanelTab, panelTabSequence);

            SelectedPanelTab = panelTabSequence;

            if (isInpainting)
            {
                StopInpaint();
            }

            if (!isDrawingClear)
                SwitchScriptSelector(3);
            else
                SwitchScriptSelector(0);

        }



        public void SwitchScriptSelector(int i)
        {
            switch (i)
            {
                case 0:
                    panelSelectedPrompt.BackColor = Color.FromArgb(20, 60, 30);
                    panelSelectedImage.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedSequence.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedMorph.BackColor = Color.FromArgb(15, 10, 15);
                    isTabSequenceSelected = false;
                    isTabMorphSelected = false;
                    break;

                case 1:
                    panelSelectedPrompt.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedImage.BackColor = Color.FromArgb(20, 60, 30);
                    panelSelectedSequence.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedMorph.BackColor = Color.FromArgb(15, 10, 15);
                    isTabSequenceSelected = false;
                    isTabMorphSelected = false;
                    break;

                case 2:
                    panelSelectedPrompt.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedImage.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedSequence.BackColor = Color.FromArgb(20, 60, 30);
                    panelSelectedMorph.BackColor = Color.FromArgb(15, 10, 15);
                    isTabSequenceSelected = true;
                    isTabMorphSelected = false;
                    break;

                case 3:
                    panelSelectedPrompt.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedImage.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedSequence.BackColor = Color.FromArgb(15, 10, 15);
                    panelSelectedMorph.BackColor = Color.FromArgb(20, 60, 30);
                    isTabSequenceSelected = false;
                    isTabMorphSelected = true;
                    break;

                default:

                    break;
            }
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
                if (isTabSequenceSelected)
                {
                    startImages2Images();
                }
                else if (isDrawingClear)
                {
                    startText2Image();
                }
                else
                {
                    startImage2Image(isTabMorphSelected);
                }

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

            string style = "";
            foreach (var item in listBoxSelectedStyles.Items)
            {
                style = style + separator + item;
            }
            text = text + style;
            text = " --prompt \"" + text + "\"";

            string iteration = " --ddim_steps " + labelIteration.Text;

            string n_iter = " --n_iter " + labelN_iter.Text;
            if (trackBarN_iter.Value == 0)
                n_iter = " --n_iter 999999";

            string n_samples = " --n_samples " + labelN_samples.Text;
            string guidance = " --scale " + labelGuidance.Text.Replace(",", "."); ;
            //string channels = " --C " + trackBarChannels.Value;
            string channels = "";

            string plms = " --plms";
            if(!isPlmsActivated)
                plms = "";


            string outdir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result";
            System.IO.Directory.CreateDirectory(outdir);
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                outdir = outdir + "\\" + listBoxPreset.SelectedItem;
                System.IO.Directory.CreateDirectory(outdir);
            }
            else
            {
                outdir = outdir + "\\NoPreset";
                System.IO.Directory.CreateDirectory(outdir);
            }
            outdir = CreateResultDirectory(outdir);
            lastOutputPath = outdir;
            outdir.Replace("\\", "/");
            outdir = " --outdir \"" + outdir + "\"";

            // making python line
            string gen = "python "+ txt2imgPath + text + seed + iteration + n_iter + n_samples + guidance + channels + plms + outdir + " --skip_grid ";

            SavePromptInTxtFile(lastOutputPath, gen);

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
        private void startImage2Image(bool isTabMorph = false)
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

            string style = "";
            foreach (var item in listBoxSelectedStyles.Items)
            {
                style = style + separator + item;
            }
            text = text + style;
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

            if (isTabMorphSelected)
            {
                n_iter = " --n_iter " + 1;
                n_samples = " --n_samples " + 1;
                script = img2morphPath;
            }


            string outdir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Result";
            System.IO.Directory.CreateDirectory(outdir);
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                outdir = outdir + "\\" + listBoxPreset.SelectedItem;
                System.IO.Directory.CreateDirectory(outdir);
            }
            else
            {
                outdir = outdir + "\\NoPreset";
                System.IO.Directory.CreateDirectory(outdir);
            }
            outdir = CreateResultDirectory(outdir);
            lastOutputPath = outdir;
            outdir.Replace("\\", "/");
            outdir = " --outdir \"" + outdir + "\"";
            // making python line
            string gen = "python "+ script + " --skip_grid " + outdir + text + seed + initImage + iteration + str + n_iter + n_samples + guidance + channels + plms;

            SavePromptInTxtFile(lastOutputPath, gen);

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

            string style = "";
            foreach (var item in listBoxSelectedStyles.Items)
            {
                style = style + " | " + item;
            }
            text = text + style;
            text = " --prompt \"" + text + "\"";

            string iteration = " --ddim_steps " + trackBarIteration.Value * 25;
            string n_iter = " --n_iter " + trackBarN_iter.Value;
            string n_samples = " --n_samples " + trackBarN_samples.Value;
            string guidance = " --scale " + (float)trackBarChannels.Value / 2;
            string channels = " --C " + trackBarChannels.Value;
            string plms = " --plms";
            if (!isPlmsActivated)
                plms = "";
            string str = " --strength " + ((float)trackBarStrength.Value / 20).ToString(CultureInfo.InvariantCulture);


            string imgpath = "inputs/sequence/";
            string initDir = "  --inputdir " + imgpath;

            // making python line
            string gen = "python " + imgs2imgsPath + text + seed + initDir + iteration + str + n_iter + n_samples + guidance + channels + plms;

            Clipboard.SetText(gen);

            // start script
            psi.UseShellExecute = true;
            //psi.Verb = "runas";
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = @" %windir%\System32\cmd.exe /K " + AnacondaPath + "\\Scripts\\activate.bat " + AnacondaPath + "&conda activate " + envName + "&" + drive + ":&cd " + envpath + "&" + gen;
            try { newProcess = Process.Start(psi); } catch (Exception) { }

        }




        // start inpaint script
        private void startInpaint()
        {
            // kill old process
            if (newProcess != null && !newProcess.HasExited)
                KillProcessAndChildrens(newProcess.Id);

            //get env drive letter
            string drive = envpath.Substring(0, 1);

            string iteration = " --steps " + trackBarIteration.Value * 25;

            // making python line
            string gen = "python " + inpaintPath + " --indir inputs/inpainting/  --outdir outputs/inpainting_results" + iteration;

            Clipboard.SetText(gen);

            // start script
            psi.UseShellExecute = true;
            //psi.Verb = "runas";
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.Arguments = @" %windir%\System32\cmd.exe /K " + AnacondaPath + "\\Scripts\\activate.bat " + AnacondaPath + "&conda activate " + envName + "&" + drive + ":&cd " + envpath + "&" + gen;
            try{newProcess = Process.Start(psi);}catch (Exception) { }
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
            System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", lastOutputPath);
            /*
            if (isTabSequenceSelected)
            {
                System.Diagnostics.Process.Start("explorer.exe", envpath + "\\outputs\\imgs2imgs\\samples");
            }
            else if (isDrawingClear)
            {
                System.Diagnostics.Process.Start("explorer.exe", envpath + "\\outputs\\txt2img-samples\\samples");
            }
            else
            {
                System.Diagnostics.Process.Start("explorer.exe", envpath + "\\outputs\\img2img-samples\\samples");
            }
            */
        }

        // clear outputs folder
        private void buttonClearOutputFolder_Click(object sender, EventArgs e)
        {
            /*
            if (isTabSequenceSelected)
            {
                clearFolder(envpath + "\\outputs\\imgs2imgs\\samples");
            }
            if (isDrawingClear)
            {
               clearFolder(envpath + "\\outputs\\txt2img-samples\\samples");
            }
            else
            {
                clearFolder(envpath + "\\outputs\\img2img-samples\\samples");
            }
            */
        }









        /// <summary> /////////////////////////////////////////////////////////////////////////////
        ///                          Drawing on picturebox1
        /// </summary>/////////////////////////////////////////////////////////////////////////////


        int brushSize = 4;
        bool isDrawing;
        Color DrawColor = Color.White;
        Color PickColor = Color.White;

        List<Bitmap> undoDrawArea = new List<Bitmap>();


        // painting
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            // save for undo
            AddToUndoList(DrawArea);

            isDrawing = true;


        }

        public void AddToUndoList(Bitmap image)
        {
            // save for undo
            undoDrawArea.Add((Bitmap)image.Clone());

            if (undoDrawArea.Count > 33)
            {

                undoDrawArea.RemoveAt(0);
            }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (isPencilEnabled || isInpainting)
            {
                Bitmap new_Image = new Bitmap(DrawArea.Width, DrawArea.Height, PixelFormat.Format24bppRgb);
                new_Image = DrawArea;
                Graphics g = Graphics.FromImage(new_Image);

                int dX = e.X;
                int dY = e.Y;

                if (new_Image.Width < 512)
                {
                    dX = e.X- ((512- new_Image.Width)/2);
                }
                if (new_Image.Height < 512)
                {
                    dY = e.Y - ((512 - new_Image.Height) / 2);
                }

                using (SolidBrush brush = new SolidBrush(DrawColor))
                {
                    FillCircle(g, brush, dX, dY, brushSize);
                    pictureBox1.Image = DrawArea;
                    g.Dispose();
                }
            }

            isDrawing = false;
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

                Bitmap new_Image = new Bitmap(DrawArea.Width, DrawArea.Height, PixelFormat.Format24bppRgb);
                //Bitmap new_Image = (Bitmap)DrawArea.Clone();

                new_Image = DrawArea;
                Graphics g = Graphics.FromImage(new_Image);

                int dX = e.X;
                int dY = e.Y;

                if (new_Image.Width < 512)
                {
                    dX = e.X - ((512 - new_Image.Width) / 2);
                }
                if (new_Image.Height < 512)
                {
                    dY = e.Y - ((512 - new_Image.Height) / 2);
                }


                if (isDrawing == true)
                {
                    using (SolidBrush brush = new SolidBrush(DrawColor))
                    {
                        FillCircle(g, brush, dX, dY, brushSize);
                        g.Dispose();
                    }
                }

                pictureBox1.Refresh();

                // prevent heavy Ram usage;
                ClearMemory();
            }


        }

        private void buttonPencilRedo_Click(object sender, EventArgs e)
        {
            if (undoDrawArea.Count>0)
            {
                Bitmap bmp = (Bitmap)undoDrawArea[undoDrawArea.Count - 1].Clone();

                //Bitmap bmp = (Bitmap)PreviewsDrawArea[previousIteration].Clone();
                DrawArea = (Bitmap)bmp.Clone();
                pictureBox1.Image = DrawArea;

                undoDrawArea.RemoveAt(undoDrawArea.Count - 1);
            }

            // prevent heavy Ram usage;
            ClearMemory();
        }





        // change brush size
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
                if (e.Delta > 0)
                {
                    brushSize = brushSize + 2;
                }
                else
                {
                    brushSize = brushSize - 2;
                    if (brushSize < 4)
                    { brushSize = 4; }
                }
        }


        // gradiant bar
        double gradiantX = 0;
        bool isGradiantUpdating = false;

        private void panelGradiant_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panelGradiant.CreateGraphics();

            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(panelGradiant.ClientRectangle, Color.Black, Color.White, 0.0);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Black, PickColor, Color.White };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            Point local = panelGradiant.PointToClient(Cursor.Position);
            Pen blackPen = new Pen(Color.Black, 3);

            g.FillRectangle(linearGradientBrush, panelGradiant.ClientRectangle);
            g.DrawLine(blackPen, local.X, local.Y - 100, local.X, local.Y + 100);
        }

        private void panelGradiant_MouseMove(object sender, MouseEventArgs e)
        {
            if (isGradiantUpdating)
                updateGradiant(sender, e);

            panelGradiant.Refresh();
        }


        private void panelGradiant_MouseDown(object sender, MouseEventArgs e)
        {
            isGradiantUpdating = true;
            updateGradiant(sender, e);
        }
        private void panelGradiant_MouseUp(object sender, MouseEventArgs e)
        {
            isGradiantUpdating = false;
        }

        private void updateGradiant(object sender, MouseEventArgs e)
        {
            if (isGradiantUpdating)
            {
                gradiantX = (float)e.X / panelGradiant.Width;

                Color[] colorList = new Color[3] { Color.Black, PickColor, Color.White };
                DrawColor = InterpolateColor(colorList, gradiantX);

                panelCpick.BackColor = DrawColor;
            }
        }




        // inpainting options

        bool isInpainting = false;
        Color lastDrawColor = Color.White;
        int lastBrushSize = 4;

        private void buttonInpaint_Click(object sender, EventArgs e)
        {

            if (!isDrawingClear)
            {
                EnablePencil(false);
                isInpainting = !isInpainting;

                // create output directory if needed
                string inpaintingpath = envpath + "\\inputs\\inpainting\\";
                System.IO.Directory.CreateDirectory(inpaintingpath);
                System.IO.Directory.CreateDirectory(envpath + "\\outputs\\inpainting_results");

                if (isInpainting)
                {
                    buttonInpaint.BackColor = Color.FromArgb(20, 60, 30);

                    // saving current brush
                    lastDrawColor = DrawColor;
                    lastBrushSize = brushSize;

                    // Green color for mask
                    DrawColor = Color.FromArgb(0, 255, 0);

                    clearFolder(inpaintingpath);

                    // saving image to inpaint
                    using (Bitmap bmp = new Bitmap(DrawArea))
                    {
                        bmp.Save(inpaintingpath + "\\current.png", ImageFormat.Png);
                    }


                }
                else
                {
                    buttonInpaint.BackColor = Color.FromArgb(45, 35, 55);

                    // creating mask image
                    Bitmap mask = new Bitmap(ChangeToColor(DrawArea));
                    mask.Save(inpaintingpath + "\\current_mask.png");

                    // restoring original Drawing
                    DrawArea = LoadBitmap(inpaintingpath + "\\current.png");
                    pictureBox1.Image = DrawArea;

                    // open output folder
                    System.Diagnostics.Process.Start("explorer.exe", envpath + "\\outputs\\inpainting_results");

                    // restore brush
                    DrawColor = lastDrawColor;
                    brushSize = lastBrushSize;

                    // start inpaint script
                    startInpaint();

                }
            }

        }


        public void StopInpaint()
        {
            isInpainting = false;
            buttonInpaint.BackColor = Color.FromArgb(45, 35, 55);

            string inpaintingpath = envpath + "\\inputs\\inpainting\\";

            // restoring original Drawing
            DrawArea = LoadBitmap(inpaintingpath + "\\current.png");
            pictureBox1.Image = DrawArea;

            // restore brush
            DrawColor = lastDrawColor;
            brushSize = lastBrushSize;
        }



        // Clear drawing area
        bool isDrawingClear = true;

        private void buttonClearImage_Click(object sender, EventArgs e)
        {
            // save for undo
            AddToUndoList(DrawArea);

            // reseting selected image
            listBoxInitImages.ClearSelected();
            listViewInitImages.Items.Clear();

            // draw black square
            using (Graphics graph = Graphics.FromImage(DrawArea))
            {
                Rectangle ImageSize = new Rectangle(0, 0, 512, 512);
                graph.FillRectangle(Brushes.Black, ImageSize);
            }

            pictureBox1.Image = DrawArea;

            setClearImage(true);
        }


        // Load image from file to drawing area
        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            EnablePencil(false);
            StopInpaint();
            var fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif;...";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = (Bitmap)FixedSize((Image)OpenImage(fd.FileName), 512, 512);


                // resize image
                if (bm.Height > bm.Width)
                {
                    float ratio = (float)bm.Width / (float)bm.Height;
                    double w = (512 * ratio);
                    w = (Math.Round(w / 64)) * 64;
                    bm = (Bitmap)ResizeImage(bm, new Size((int)w , 512 ) , false);
                }
                else
                {
                    float ratio = bm.Width / bm.Height;

                    double h = (512 * ratio);
                    h = (Math.Round(h / 64)) * 64;
                    bm = (Bitmap)ResizeImage(bm, new Size( 512, (int)h ) , false);
                }

                //bm = (Bitmap)ResizeImage(bm, new Size(512, 512), false);
                pictureBox1.Image = bm;

                DrawArea = bm;
                bm.Save(envpath + "\\current.png");
                setClearImage(false);
            }

            // prevent heavy Ram usage;
            ClearMemory();
        }

        private void buttonPastImage_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Bitmap bm = (Bitmap)FixedSize(Clipboard.GetImage(), 512, 512);


                // resize image
                if (bm.Height > bm.Width)
                {
                    float ratio = (float)bm.Width / (float)bm.Height;
                    double w = (512 * ratio);
                    w = (Math.Round(w / 64)) * 64;
                    bm = (Bitmap)ResizeImage(bm, new Size((int)w, 512), false);
                }
                else
                {
                    float ratio = bm.Width / bm.Height;

                    double h = (512 * ratio);
                    h = (Math.Round(h / 64)) * 64;
                    bm = (Bitmap)ResizeImage(bm, new Size(512, (int)h), false);
                }

                //bm = (Bitmap)ResizeImage(bm, new Size(512, 512), false);
                pictureBox1.Image = bm;

                DrawArea = bm;
                bm.Save(envpath + "\\current.png");
                setClearImage(false);
            }

        }
        public void setClearImage(bool value)
        {
            isDrawingClear = value;

            //buttonStrength.Enabled = !value;
            //trackBarStrength.Enabled = !value;


            if (isTabSequenceSelected)
            {

            }
            else if (isDrawingClear)
            {
                SwitchScriptSelector(0);
            }
            else
            {
                SwitchScriptSelector(1);
            }

        }


        private void buttonImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }



        private void listBoxInitImages_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxInitImages.SelectedItems.Count > 0)
                populateInitImages(listViewInitImages, listBoxInitImages.SelectedItem.ToString());

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
                    SaveSelectedStyles(listBoxSelectedStyles);


                    System.Media.SystemSounds.Hand.Play();
                    break;

                case MouseButtons.Right:
                    //OpenWithDefaultProgram("Settings.ini");
                    break;
            }
        }











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

        }






        private void listViewInitImages_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewInitImages.SelectedItems.Count > 0)
            {
                if (isInpainting)
                {
                    StopInpaint();
                }

                undoDrawArea.Clear();

                string path = listViewInitImages.SelectedItems[0].SubItems[0].Text;
                pictureBox1.Image = System.Drawing.Image.FromFile(path);

                DrawArea = LoadBitmap(path);
                pictureBox1.Image = DrawArea;
                DrawArea.Save(envpath + "\\current.png");

                setClearImage(false);


            }

            foreach (ListViewItem i in listViewInitImages.SelectedItems)
            {
                i.Selected = false;
            }

            // prevent heavy Ram usage;
            ClearMemory();

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
            if (isInpainting)
            {
                StopInpaint();
            }
                isPencilEnabled = !isPencilEnabled;
            EnablePencil(isPencilEnabled);
        }

        public void EnablePencil(bool isEnabled)
        {
            isPencilEnabled = isEnabled;

            if (isPencilEnabled)
            {
                flowLayoutPanelPaintTools.Enabled = true;
                pictureBox1.Cursor = Cursors.Cross;
                buttonPencil.BackColor = Color.FromArgb(20, 60, 30);
            }
            else
            {
                flowLayoutPanelPaintTools.Enabled = false;
                pictureBox1.Cursor = Cursors.Default;
                buttonPencil.BackColor = Color.FromArgb(45, 35, 55);
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
        }

        private void buttonRemoveStyleSelectedStyles_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection  selectedItems = listBoxSelectedStyles.SelectedItems;
            if (listBoxSelectedStyles.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBoxSelectedStyles.Items.Remove(selectedItems[i]);
            }
        }


        private void buttonRemoveStyles_Click(object sender, EventArgs e)
        {
            listBoxSelectedStyles.Items.Clear();
        }



        private void buttonAddSelectedPreset_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxPresetStyles.SelectedItems)
            {
                listBoxSelectedStyles.Items.Add(item);
            }
            RemoveDuplicate(listBoxSelectedStyles);
        }

        private void buttonAddAllSelectedPreset_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxPresetStyles.Items)
            {
                listBoxSelectedStyles.Items.Add(item);
            }


            RemoveDuplicate(listBoxSelectedStyles);
        }

        private void buttonAddSelectedToPreset_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxGenericStyles.SelectedItems)
            {
                listBoxPresetStyles.Items.Add(item);
            }
            RemoveDuplicate(listBoxPresetStyles);
        }

        private void buttonAddSelectedToStyles_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxGenericStyles.SelectedItems)
            {
                listBoxSelectedStyles.Items.Add(item);
            }
            RemoveDuplicate(listBoxSelectedStyles);
        }

        private void buttonAddSelectedStylesToGeneric_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxSelectedStyles.SelectedItems)
            {
                listBoxGenericStyles.Items.Add(item);
            }
            RemoveDuplicate(listBoxGenericStyles);
        }

        private void buttonAddSelectedStylesToPreset_Click(object sender, EventArgs e)
        {
            foreach (string item in listBoxSelectedStyles.SelectedItems)
            {
                listBoxPresetStyles.Items.Add(item);
            }
            RemoveDuplicate(listBoxPresetStyles);
        }

        private void buttonAddStyle_Click(object sender, EventArgs e)
        {


            if (sender == buttonAddPreset)
            {
                listBoxPreset.Items.Add(textBoxPreset.Text);
                RemoveDuplicate(listBoxPreset);
                CreatePreset(textBoxPreset.Text);
                //AddPreset(textBoxPreset.Text);
            }
            else if (sender == buttonAddPresetStyle)
            {
                listBoxPresetStyles.Items.Add(textBoxPresetStyle.Text);
                RemoveDuplicate(listBoxPresetStyles);
            }
            else if (sender == buttonAddGenericStyle)
            {
                listBoxGenericStyles.Items.Add(textBoxGenericStyle.Text);
                RemoveDuplicate(listBoxGenericStyles);
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

        private void buttonRemovePreset_Click(object sender, EventArgs e)
        {
            if (listBoxPreset.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete "+ listBoxPreset.SelectedItems[0] + " preset ?", listBoxPreset.SelectedItems[0]+" will be removed !", MessageBoxButtons.YesNo);
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
                else if (dialogResult == DialogResult.No){}
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
        }

        private void buttonRemoveGenericStyle_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = listBoxGenericStyles.SelectedItems;
            if (listBoxGenericStyles.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBoxGenericStyles.Items.Remove(selectedItems[i]);
            }

        }





    }
}