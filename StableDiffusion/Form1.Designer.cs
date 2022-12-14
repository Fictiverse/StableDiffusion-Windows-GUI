namespace StableDiffusion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxPrompt = new System.Windows.Forms.TextBox();
            this.buttonClearImage = new System.Windows.Forms.Button();
            this.buttonStrength = new System.Windows.Forms.Button();
            this.trackBarStrength = new System.Windows.Forms.TrackBar();
            this.buttonN_iter = new System.Windows.Forms.Button();
            this.trackBarN_iter = new System.Windows.Forms.TrackBar();
            this.buttonN_samples = new System.Windows.Forms.Button();
            this.trackBarN_samples = new System.Windows.Forms.TrackBar();
            this.buttonSeed = new System.Windows.Forms.Button();
            this.buttonSteps = new System.Windows.Forms.Button();
            this.trackBarSteps = new System.Windows.Forms.TrackBar();
            this.buttonOutFolder = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.flowLayoutPanelQuality = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelIteration = new System.Windows.Forms.Label();
            this.flowLayoutPanelRepeat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelN_iter = new System.Windows.Forms.Label();
            this.flowLayoutPanelSamples = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelN_samples = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelStrength = new System.Windows.Forms.Label();
            this.flowLayoutPanelSeed = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSize = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxSizeW = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxSizeH = new System.Windows.Forms.TextBox();
            this.buttonSizeShape = new System.Windows.Forms.Button();
            this.buttonOpenSettings = new System.Windows.Forms.Button();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelGuidance = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonGuidance = new System.Windows.Forms.Button();
            this.trackBarGuidance = new System.Windows.Forms.TrackBar();
            this.panel13 = new System.Windows.Forms.Panel();
            this.labelGuidance = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonChannels = new System.Windows.Forms.Button();
            this.trackBarChannels = new System.Windows.Forms.TrackBar();
            this.panel15 = new System.Windows.Forms.Panel();
            this.labelChannels = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTabImage = new System.Windows.Forms.Button();
            this.buttonTabSequence = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTabPrompt = new System.Windows.Forms.Button();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.panelSelectedPrompt = new System.Windows.Forms.Panel();
            this.panelSelectedImage = new System.Windows.Forms.Panel();
            this.panelSelectedSequence = new System.Windows.Forms.Panel();
            this.timerSec = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonText = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel14 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.richTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.tabSettings = new System.Windows.Forms.Panel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAnacondaPath = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBoxAnacondaPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseAnacondaPath = new System.Windows.Forms.Button();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEnvName = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBoxEnvName = new System.Windows.Forms.TextBox();
            this.buttonBrowseEnvs = new System.Windows.Forms.Button();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEnvPath = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.textBoxEnvPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseEnvPath = new System.Windows.Forms.Button();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonTxt2img = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.textBoxTxt2imgScript = new System.Windows.Forms.TextBox();
            this.buttonBrowseTxt2imgScript = new System.Windows.Forms.Button();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonImg2img = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.textBoxImg2imgScript = new System.Windows.Forms.TextBox();
            this.buttonBrowseImg2imgScript = new System.Windows.Forms.Button();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonImgs2imgs = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.textBoxImgs2imgsScript = new System.Windows.Forms.TextBox();
            this.buttonBrowseImgs2imgsScript = new System.Windows.Forms.Button();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonImg2Morph = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.textBoxImg2MorphScript = new System.Windows.Forms.TextBox();
            this.buttonBrowseImg2morphScript = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSelectedMorph = new System.Windows.Forms.Panel();
            this.buttonTabMorph = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTabBrowse = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLaunchAsync = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN_iter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN_samples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSteps)).BeginInit();
            this.flowLayoutPanelQuality.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanelRepeat.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanelSamples.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanelSeed.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanelGuidance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGuidance)).BeginInit();
            this.panel13.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChannels)).BeginInit();
            this.panel15.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.panel16.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.panel17.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.panel18.SuspendLayout();
            this.flowLayoutPanel15.SuspendLayout();
            this.panel19.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            this.panel20.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPrompt
            // 
            this.textBoxPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrompt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPrompt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPrompt.Location = new System.Drawing.Point(10, 10);
            this.textBoxPrompt.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPrompt.Name = "textBoxPrompt";
            this.textBoxPrompt.Size = new System.Drawing.Size(902, 22);
            this.textBoxPrompt.TabIndex = 1;
            this.textBoxPrompt.Text = "Abstract gate to the Fictiverse";
            this.textBoxPrompt.Validated += new System.EventHandler(this.textBoxPrompt_Validated);
            // 
            // buttonClearImage
            // 
            this.buttonClearImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.buttonClearImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearImage.FlatAppearance.BorderSize = 0;
            this.buttonClearImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearImage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClearImage.ForeColor = System.Drawing.Color.Silver;
            this.buttonClearImage.Image = global::StableDiffusion.Properties.Resources.delete_cross;
            this.buttonClearImage.Location = new System.Drawing.Point(101, 0);
            this.buttonClearImage.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearImage.Name = "buttonClearImage";
            this.buttonClearImage.Size = new System.Drawing.Size(34, 40);
            this.buttonClearImage.TabIndex = 28;
            this.buttonClearImage.UseVisualStyleBackColor = false;
            this.buttonClearImage.Click += new System.EventHandler(this.buttonClearImage_Click);
            // 
            // buttonStrength
            // 
            this.buttonStrength.AllowDrop = true;
            this.buttonStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonStrength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStrength.FlatAppearance.BorderSize = 0;
            this.buttonStrength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStrength.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStrength.ForeColor = System.Drawing.Color.Silver;
            this.buttonStrength.Image = global::StableDiffusion.Properties.Resources.blend_tool;
            this.buttonStrength.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStrength.Location = new System.Drawing.Point(3, 0);
            this.buttonStrength.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonStrength.Name = "buttonStrength";
            this.buttonStrength.Size = new System.Drawing.Size(113, 43);
            this.buttonStrength.TabIndex = 34;
            this.buttonStrength.Text = "Strength";
            this.buttonStrength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStrength.UseVisualStyleBackColor = false;
            this.buttonStrength.Click += new System.EventHandler(this.buttonStrength_Click);
            // 
            // trackBarStrength
            // 
            this.trackBarStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.trackBarStrength.LargeChange = 1;
            this.trackBarStrength.Location = new System.Drawing.Point(119, 0);
            this.trackBarStrength.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.trackBarStrength.Maximum = 19;
            this.trackBarStrength.Minimum = 1;
            this.trackBarStrength.Name = "trackBarStrength";
            this.trackBarStrength.Size = new System.Drawing.Size(150, 45);
            this.trackBarStrength.TabIndex = 31;
            this.trackBarStrength.Value = 16;
            this.trackBarStrength.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // buttonN_iter
            // 
            this.buttonN_iter.AllowDrop = true;
            this.buttonN_iter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonN_iter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonN_iter.FlatAppearance.BorderSize = 0;
            this.buttonN_iter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonN_iter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonN_iter.ForeColor = System.Drawing.Color.Silver;
            this.buttonN_iter.Image = global::StableDiffusion.Properties.Resources.repeat;
            this.buttonN_iter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonN_iter.Location = new System.Drawing.Point(3, 0);
            this.buttonN_iter.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonN_iter.Name = "buttonN_iter";
            this.buttonN_iter.Size = new System.Drawing.Size(113, 43);
            this.buttonN_iter.TabIndex = 35;
            this.buttonN_iter.Text = "Repeat";
            this.buttonN_iter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonN_iter.UseVisualStyleBackColor = false;
            this.buttonN_iter.Click += new System.EventHandler(this.buttonN_iter_Click);
            // 
            // trackBarN_iter
            // 
            this.trackBarN_iter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.trackBarN_iter.LargeChange = 1;
            this.trackBarN_iter.Location = new System.Drawing.Point(119, 0);
            this.trackBarN_iter.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.trackBarN_iter.Name = "trackBarN_iter";
            this.trackBarN_iter.Size = new System.Drawing.Size(150, 45);
            this.trackBarN_iter.TabIndex = 33;
            this.trackBarN_iter.Value = 1;
            this.trackBarN_iter.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // buttonN_samples
            // 
            this.buttonN_samples.AllowDrop = true;
            this.buttonN_samples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonN_samples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonN_samples.FlatAppearance.BorderSize = 0;
            this.buttonN_samples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonN_samples.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonN_samples.ForeColor = System.Drawing.Color.Silver;
            this.buttonN_samples.Image = global::StableDiffusion.Properties.Resources.stacked_files;
            this.buttonN_samples.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonN_samples.Location = new System.Drawing.Point(3, 0);
            this.buttonN_samples.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonN_samples.Name = "buttonN_samples";
            this.buttonN_samples.Size = new System.Drawing.Size(113, 43);
            this.buttonN_samples.TabIndex = 36;
            this.buttonN_samples.Text = "Samples";
            this.buttonN_samples.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonN_samples.UseVisualStyleBackColor = false;
            this.buttonN_samples.Click += new System.EventHandler(this.buttonN_samples_Click);
            // 
            // trackBarN_samples
            // 
            this.trackBarN_samples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.trackBarN_samples.LargeChange = 1;
            this.trackBarN_samples.Location = new System.Drawing.Point(119, 0);
            this.trackBarN_samples.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.trackBarN_samples.Maximum = 6;
            this.trackBarN_samples.Minimum = 1;
            this.trackBarN_samples.Name = "trackBarN_samples";
            this.trackBarN_samples.Size = new System.Drawing.Size(150, 45);
            this.trackBarN_samples.TabIndex = 35;
            this.trackBarN_samples.Value = 6;
            this.trackBarN_samples.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // buttonSeed
            // 
            this.buttonSeed.AllowDrop = true;
            this.buttonSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonSeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeed.FlatAppearance.BorderSize = 0;
            this.buttonSeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSeed.ForeColor = System.Drawing.Color.Silver;
            this.buttonSeed.Image = global::StableDiffusion.Properties.Resources.dice;
            this.buttonSeed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeed.Location = new System.Drawing.Point(3, 0);
            this.buttonSeed.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonSeed.Name = "buttonSeed";
            this.buttonSeed.Size = new System.Drawing.Size(113, 43);
            this.buttonSeed.TabIndex = 37;
            this.buttonSeed.Text = "Seed";
            this.buttonSeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSeed.UseVisualStyleBackColor = false;
            this.buttonSeed.Click += new System.EventHandler(this.buttonSeed_Click);
            // 
            // buttonSteps
            // 
            this.buttonSteps.AllowDrop = true;
            this.buttonSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonSteps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSteps.FlatAppearance.BorderSize = 0;
            this.buttonSteps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSteps.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSteps.ForeColor = System.Drawing.Color.Silver;
            this.buttonSteps.Image = global::StableDiffusion.Properties.Resources.volume;
            this.buttonSteps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSteps.Location = new System.Drawing.Point(3, 0);
            this.buttonSteps.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonSteps.Name = "buttonSteps";
            this.buttonSteps.Size = new System.Drawing.Size(113, 43);
            this.buttonSteps.TabIndex = 38;
            this.buttonSteps.Text = "Steps";
            this.buttonSteps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSteps.UseVisualStyleBackColor = false;
            this.buttonSteps.Click += new System.EventHandler(this.buttonSteps_Click);
            // 
            // trackBarSteps
            // 
            this.trackBarSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.trackBarSteps.LargeChange = 1;
            this.trackBarSteps.Location = new System.Drawing.Point(119, 0);
            this.trackBarSteps.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.trackBarSteps.Maximum = 8;
            this.trackBarSteps.Minimum = 1;
            this.trackBarSteps.Name = "trackBarSteps";
            this.trackBarSteps.Size = new System.Drawing.Size(150, 45);
            this.trackBarSteps.TabIndex = 39;
            this.trackBarSteps.Value = 2;
            this.trackBarSteps.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // buttonOutFolder
            // 
            this.buttonOutFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonOutFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOutFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOutFolder.FlatAppearance.BorderSize = 0;
            this.buttonOutFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutFolder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOutFolder.ForeColor = System.Drawing.Color.Silver;
            this.buttonOutFolder.Image = global::StableDiffusion.Properties.Resources.search;
            this.buttonOutFolder.Location = new System.Drawing.Point(124, 0);
            this.buttonOutFolder.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOutFolder.Name = "buttonOutFolder";
            this.buttonOutFolder.Size = new System.Drawing.Size(34, 40);
            this.buttonOutFolder.TabIndex = 40;
            this.buttonOutFolder.UseVisualStyleBackColor = false;
            this.buttonOutFolder.Click += new System.EventHandler(this.buttonOutFolder_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.Silver;
            this.buttonSave.Image = global::StableDiffusion.Properties.Resources.save11;
            this.buttonSave.Location = new System.Drawing.Point(101, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(34, 40);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSave_MouseUp);
            // 
            // flowLayoutPanelQuality
            // 
            this.flowLayoutPanelQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanelQuality.Controls.Add(this.buttonSteps);
            this.flowLayoutPanelQuality.Controls.Add(this.trackBarSteps);
            this.flowLayoutPanelQuality.Controls.Add(this.panel3);
            this.flowLayoutPanelQuality.Location = new System.Drawing.Point(3, 104);
            this.flowLayoutPanelQuality.Name = "flowLayoutPanelQuality";
            this.flowLayoutPanelQuality.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanelQuality.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.labelIteration);
            this.panel3.Location = new System.Drawing.Point(272, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(47, 43);
            this.panel3.TabIndex = 49;
            // 
            // labelIteration
            // 
            this.labelIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.labelIteration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIteration.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIteration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelIteration.Location = new System.Drawing.Point(5, 5);
            this.labelIteration.Name = "labelIteration";
            this.labelIteration.Size = new System.Drawing.Size(37, 33);
            this.labelIteration.TabIndex = 0;
            this.labelIteration.Text = "0";
            this.labelIteration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelRepeat
            // 
            this.flowLayoutPanelRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanelRepeat.Controls.Add(this.buttonN_iter);
            this.flowLayoutPanelRepeat.Controls.Add(this.trackBarN_iter);
            this.flowLayoutPanelRepeat.Controls.Add(this.panel4);
            this.flowLayoutPanelRepeat.Location = new System.Drawing.Point(3, 153);
            this.flowLayoutPanelRepeat.Name = "flowLayoutPanelRepeat";
            this.flowLayoutPanelRepeat.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanelRepeat.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.labelN_iter);
            this.panel4.Location = new System.Drawing.Point(272, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(47, 43);
            this.panel4.TabIndex = 50;
            // 
            // labelN_iter
            // 
            this.labelN_iter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.labelN_iter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelN_iter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelN_iter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelN_iter.Location = new System.Drawing.Point(5, 5);
            this.labelN_iter.Name = "labelN_iter";
            this.labelN_iter.Size = new System.Drawing.Size(37, 33);
            this.labelN_iter.TabIndex = 0;
            this.labelN_iter.Text = "0";
            this.labelN_iter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelSamples
            // 
            this.flowLayoutPanelSamples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanelSamples.Controls.Add(this.buttonN_samples);
            this.flowLayoutPanelSamples.Controls.Add(this.trackBarN_samples);
            this.flowLayoutPanelSamples.Controls.Add(this.panel5);
            this.flowLayoutPanelSamples.Location = new System.Drawing.Point(3, 202);
            this.flowLayoutPanelSamples.Name = "flowLayoutPanelSamples";
            this.flowLayoutPanelSamples.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanelSamples.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.labelN_samples);
            this.panel5.Location = new System.Drawing.Point(272, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(47, 43);
            this.panel5.TabIndex = 50;
            // 
            // labelN_samples
            // 
            this.labelN_samples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.labelN_samples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelN_samples.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelN_samples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelN_samples.Location = new System.Drawing.Point(5, 5);
            this.labelN_samples.Name = "labelN_samples";
            this.labelN_samples.Size = new System.Drawing.Size(37, 33);
            this.labelN_samples.TabIndex = 0;
            this.labelN_samples.Text = "0";
            this.labelN_samples.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel6.Controls.Add(this.buttonStrength);
            this.flowLayoutPanel6.Controls.Add(this.trackBarStrength);
            this.flowLayoutPanel6.Controls.Add(this.panel6);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 349);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanel6.TabIndex = 45;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel6.Controls.Add(this.labelStrength);
            this.panel6.Location = new System.Drawing.Point(272, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(47, 43);
            this.panel6.TabIndex = 50;
            // 
            // labelStrength
            // 
            this.labelStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.labelStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStrength.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStrength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelStrength.Location = new System.Drawing.Point(5, 5);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(37, 33);
            this.labelStrength.TabIndex = 0;
            this.labelStrength.Text = "0";
            this.labelStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelSeed
            // 
            this.flowLayoutPanelSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanelSeed.Controls.Add(this.buttonSeed);
            this.flowLayoutPanelSeed.Controls.Add(this.panel1);
            this.flowLayoutPanelSeed.Location = new System.Drawing.Point(3, 55);
            this.flowLayoutPanelSeed.Name = "flowLayoutPanelSeed";
            this.flowLayoutPanelSeed.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanelSeed.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.textBoxSeed);
            this.panel1.Location = new System.Drawing.Point(119, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.panel1.Size = new System.Drawing.Size(203, 45);
            this.panel1.TabIndex = 49;
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxSeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSeed.Location = new System.Drawing.Point(5, 10);
            this.textBoxSeed.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(193, 22);
            this.textBoxSeed.TabIndex = 47;
            this.textBoxSeed.Text = "777";
            this.textBoxSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSeed_KeyPress);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel4.Controls.Add(this.buttonSize);
            this.flowLayoutPanel4.Controls.Add(this.panel8);
            this.flowLayoutPanel4.Controls.Add(this.panel9);
            this.flowLayoutPanel4.Controls.Add(this.buttonSizeShape);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(322, 43);
            this.flowLayoutPanel4.TabIndex = 46;
            // 
            // buttonSize
            // 
            this.buttonSize.AllowDrop = true;
            this.buttonSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSize.FlatAppearance.BorderSize = 0;
            this.buttonSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSize.ForeColor = System.Drawing.Color.Silver;
            this.buttonSize.Image = global::StableDiffusion.Properties.Resources.rounded_black_square_shape;
            this.buttonSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSize.Location = new System.Drawing.Point(3, 0);
            this.buttonSize.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(113, 43);
            this.buttonSize.TabIndex = 37;
            this.buttonSize.Text = "Size";
            this.buttonSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSize.UseVisualStyleBackColor = false;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel8.Controls.Add(this.textBoxSizeW);
            this.panel8.Location = new System.Drawing.Point(119, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.panel8.Size = new System.Drawing.Size(72, 45);
            this.panel8.TabIndex = 49;
            // 
            // textBoxSizeW
            // 
            this.textBoxSizeW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxSizeW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSizeW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSizeW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSizeW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSizeW.Location = new System.Drawing.Point(5, 10);
            this.textBoxSizeW.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSizeW.Name = "textBoxSizeW";
            this.textBoxSizeW.Size = new System.Drawing.Size(62, 22);
            this.textBoxSizeW.TabIndex = 47;
            this.textBoxSizeW.Text = "512";
            this.textBoxSizeW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSizeW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSize_KeyPress);
            this.textBoxSizeW.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSize_Validating);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel9.Controls.Add(this.textBoxSizeH);
            this.panel9.Location = new System.Drawing.Point(197, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.panel9.Size = new System.Drawing.Size(72, 45);
            this.panel9.TabIndex = 50;
            // 
            // textBoxSizeH
            // 
            this.textBoxSizeH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxSizeH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSizeH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSizeH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSizeH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSizeH.Location = new System.Drawing.Point(5, 10);
            this.textBoxSizeH.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSizeH.Name = "textBoxSizeH";
            this.textBoxSizeH.Size = new System.Drawing.Size(62, 22);
            this.textBoxSizeH.TabIndex = 47;
            this.textBoxSizeH.Text = "512";
            this.textBoxSizeH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSizeH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSize_KeyPress);
            this.textBoxSizeH.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSize_Validating);
            // 
            // buttonSizeShape
            // 
            this.buttonSizeShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonSizeShape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSizeShape.FlatAppearance.BorderSize = 0;
            this.buttonSizeShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSizeShape.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSizeShape.ForeColor = System.Drawing.Color.Silver;
            this.buttonSizeShape.Image = global::StableDiffusion.Properties.Resources.rounded_black_square_shapeS_;
            this.buttonSizeShape.Location = new System.Drawing.Point(272, 0);
            this.buttonSizeShape.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonSizeShape.Name = "buttonSizeShape";
            this.buttonSizeShape.Size = new System.Drawing.Size(47, 43);
            this.buttonSizeShape.TabIndex = 42;
            this.buttonSizeShape.UseVisualStyleBackColor = false;
            this.buttonSizeShape.Click += new System.EventHandler(this.buttonSizeShape_Click);
            // 
            // buttonOpenSettings
            // 
            this.buttonOpenSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonOpenSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenSettings.FlatAppearance.BorderSize = 0;
            this.buttonOpenSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenSettings.ForeColor = System.Drawing.Color.Silver;
            this.buttonOpenSettings.Image = global::StableDiffusion.Properties.Resources.option_dequipement;
            this.buttonOpenSettings.Location = new System.Drawing.Point(124, 0);
            this.buttonOpenSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOpenSettings.Name = "buttonOpenSettings";
            this.buttonOpenSettings.Size = new System.Drawing.Size(34, 40);
            this.buttonOpenSettings.TabIndex = 42;
            this.buttonOpenSettings.UseVisualStyleBackColor = false;
            this.buttonOpenSettings.Click += new System.EventHandler(this.buttonOpenSettings_Click);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanelSeed);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanelQuality);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanelRepeat);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanelSamples);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanelGuidance);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(7, 342);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanel8.Size = new System.Drawing.Size(328, 398);
            this.flowLayoutPanel8.TabIndex = 46;
            // 
            // flowLayoutPanelGuidance
            // 
            this.flowLayoutPanelGuidance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanelGuidance.Controls.Add(this.buttonGuidance);
            this.flowLayoutPanelGuidance.Controls.Add(this.trackBarGuidance);
            this.flowLayoutPanelGuidance.Controls.Add(this.panel13);
            this.flowLayoutPanelGuidance.Location = new System.Drawing.Point(3, 251);
            this.flowLayoutPanelGuidance.Name = "flowLayoutPanelGuidance";
            this.flowLayoutPanelGuidance.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanelGuidance.TabIndex = 52;
            // 
            // buttonGuidance
            // 
            this.buttonGuidance.AllowDrop = true;
            this.buttonGuidance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonGuidance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuidance.FlatAppearance.BorderSize = 0;
            this.buttonGuidance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuidance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGuidance.ForeColor = System.Drawing.Color.Silver;
            this.buttonGuidance.Image = global::StableDiffusion.Properties.Resources.scale;
            this.buttonGuidance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuidance.Location = new System.Drawing.Point(3, 0);
            this.buttonGuidance.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonGuidance.Name = "buttonGuidance";
            this.buttonGuidance.Size = new System.Drawing.Size(113, 43);
            this.buttonGuidance.TabIndex = 34;
            this.buttonGuidance.Text = "Guidance";
            this.buttonGuidance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuidance.UseVisualStyleBackColor = false;
            this.buttonGuidance.Click += new System.EventHandler(this.buttonGuidance_Click);
            // 
            // trackBarGuidance
            // 
            this.trackBarGuidance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.trackBarGuidance.LargeChange = 1;
            this.trackBarGuidance.Location = new System.Drawing.Point(119, 0);
            this.trackBarGuidance.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.trackBarGuidance.Maximum = 200;
            this.trackBarGuidance.Name = "trackBarGuidance";
            this.trackBarGuidance.Size = new System.Drawing.Size(150, 45);
            this.trackBarGuidance.SmallChange = 2;
            this.trackBarGuidance.TabIndex = 31;
            this.trackBarGuidance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGuidance.Value = 15;
            this.trackBarGuidance.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel13.Controls.Add(this.labelGuidance);
            this.panel13.Location = new System.Drawing.Point(272, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(5);
            this.panel13.Size = new System.Drawing.Size(47, 43);
            this.panel13.TabIndex = 50;
            // 
            // labelGuidance
            // 
            this.labelGuidance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.labelGuidance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGuidance.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGuidance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelGuidance.Location = new System.Drawing.Point(5, 5);
            this.labelGuidance.Name = "labelGuidance";
            this.labelGuidance.Size = new System.Drawing.Size(37, 33);
            this.labelGuidance.TabIndex = 0;
            this.labelGuidance.Text = "0";
            this.labelGuidance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel1.Controls.Add(this.buttonChannels);
            this.flowLayoutPanel1.Controls.Add(this.trackBarChannels);
            this.flowLayoutPanel1.Controls.Add(this.panel15);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 300);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanel1.TabIndex = 51;
            // 
            // buttonChannels
            // 
            this.buttonChannels.AllowDrop = true;
            this.buttonChannels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonChannels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChannels.FlatAppearance.BorderSize = 0;
            this.buttonChannels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChannels.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChannels.ForeColor = System.Drawing.Color.Silver;
            this.buttonChannels.Image = global::StableDiffusion.Properties.Resources.network;
            this.buttonChannels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChannels.Location = new System.Drawing.Point(3, 0);
            this.buttonChannels.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonChannels.Name = "buttonChannels";
            this.buttonChannels.Size = new System.Drawing.Size(113, 43);
            this.buttonChannels.TabIndex = 36;
            this.buttonChannels.Text = "Channels";
            this.buttonChannels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChannels.UseVisualStyleBackColor = false;
            this.buttonChannels.Click += new System.EventHandler(this.buttonChannels_Click);
            // 
            // trackBarChannels
            // 
            this.trackBarChannels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.trackBarChannels.LargeChange = 1;
            this.trackBarChannels.Location = new System.Drawing.Point(119, 0);
            this.trackBarChannels.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.trackBarChannels.Minimum = 1;
            this.trackBarChannels.Name = "trackBarChannels";
            this.trackBarChannels.Size = new System.Drawing.Size(150, 45);
            this.trackBarChannels.TabIndex = 35;
            this.trackBarChannels.Value = 1;
            this.trackBarChannels.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel15.Controls.Add(this.labelChannels);
            this.panel15.Location = new System.Drawing.Point(272, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(5);
            this.panel15.Size = new System.Drawing.Size(47, 43);
            this.panel15.TabIndex = 50;
            // 
            // labelChannels
            // 
            this.labelChannels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.labelChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChannels.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChannels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelChannels.Location = new System.Drawing.Point(5, 5);
            this.labelChannels.Name = "labelChannels";
            this.labelChannels.Size = new System.Drawing.Size(37, 33);
            this.labelChannels.TabIndex = 0;
            this.labelChannels.Text = "0";
            this.labelChannels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.buttonTabImage, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonClearImage, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(23, 49);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(135, 40);
            this.tableLayoutPanel6.TabIndex = 63;
            // 
            // buttonTabImage
            // 
            this.buttonTabImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonTabImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTabImage.FlatAppearance.BorderSize = 0;
            this.buttonTabImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabImage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTabImage.ForeColor = System.Drawing.Color.Silver;
            this.buttonTabImage.Location = new System.Drawing.Point(3, 0);
            this.buttonTabImage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonTabImage.Name = "buttonTabImage";
            this.buttonTabImage.Size = new System.Drawing.Size(95, 40);
            this.buttonTabImage.TabIndex = 58;
            this.buttonTabImage.Text = "Image";
            this.buttonTabImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabImage.UseVisualStyleBackColor = false;
            this.buttonTabImage.Click += new System.EventHandler(this.buttonTabImage_Click);
            // 
            // buttonTabSequence
            // 
            this.buttonTabSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonTabSequence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabSequence.FlatAppearance.BorderSize = 0;
            this.buttonTabSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabSequence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTabSequence.ForeColor = System.Drawing.Color.Silver;
            this.buttonTabSequence.Location = new System.Drawing.Point(26, 95);
            this.buttonTabSequence.Name = "buttonTabSequence";
            this.buttonTabSequence.Size = new System.Drawing.Size(132, 40);
            this.buttonTabSequence.TabIndex = 59;
            this.buttonTabSequence.Text = "Sequence";
            this.buttonTabSequence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabSequence.UseVisualStyleBackColor = false;
            this.buttonTabSequence.Click += new System.EventHandler(this.buttonTabSequence_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonTabPrompt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSave, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(135, 40);
            this.tableLayoutPanel2.TabIndex = 59;
            // 
            // buttonTabPrompt
            // 
            this.buttonTabPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.buttonTabPrompt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabPrompt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTabPrompt.FlatAppearance.BorderSize = 0;
            this.buttonTabPrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabPrompt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTabPrompt.ForeColor = System.Drawing.Color.Silver;
            this.buttonTabPrompt.Location = new System.Drawing.Point(3, 0);
            this.buttonTabPrompt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonTabPrompt.Name = "buttonTabPrompt";
            this.buttonTabPrompt.Size = new System.Drawing.Size(95, 40);
            this.buttonTabPrompt.TabIndex = 56;
            this.buttonTabPrompt.Text = "Prompt";
            this.buttonTabPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabPrompt.UseVisualStyleBackColor = false;
            this.buttonTabPrompt.Click += new System.EventHandler(this.buttonTabPrompt_Click);
            // 
            // buttonClearText
            // 
            this.buttonClearText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonClearText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearText.FlatAppearance.BorderSize = 0;
            this.buttonClearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClearText.ForeColor = System.Drawing.Color.Silver;
            this.buttonClearText.Image = global::StableDiffusion.Properties.Resources.delete_cross;
            this.buttonClearText.Location = new System.Drawing.Point(965, 3);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(45, 45);
            this.buttonClearText.TabIndex = 62;
            this.buttonClearText.UseVisualStyleBackColor = false;
            this.buttonClearText.Click += new System.EventHandler(this.buttonClearText_Click);
            // 
            // panelSelectedPrompt
            // 
            this.panelSelectedPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.panelSelectedPrompt.Location = new System.Drawing.Point(3, 3);
            this.panelSelectedPrompt.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panelSelectedPrompt.Name = "panelSelectedPrompt";
            this.panelSelectedPrompt.Size = new System.Drawing.Size(20, 40);
            this.panelSelectedPrompt.TabIndex = 59;
            // 
            // panelSelectedImage
            // 
            this.panelSelectedImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panelSelectedImage.Location = new System.Drawing.Point(3, 49);
            this.panelSelectedImage.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panelSelectedImage.Name = "panelSelectedImage";
            this.panelSelectedImage.Size = new System.Drawing.Size(20, 40);
            this.panelSelectedImage.TabIndex = 60;
            // 
            // panelSelectedSequence
            // 
            this.panelSelectedSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panelSelectedSequence.Location = new System.Drawing.Point(3, 95);
            this.panelSelectedSequence.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panelSelectedSequence.Name = "panelSelectedSequence";
            this.panelSelectedSequence.Size = new System.Drawing.Size(20, 40);
            this.panelSelectedSequence.TabIndex = 61;
            // 
            // timerSec
            // 
            this.timerSec.Interval = 1000;
            this.timerSec.Tick += new System.EventHandler(this.timerSec_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel7.Controls.Add(this.textBoxPrompt);
            this.panel7.Location = new System.Drawing.Point(45, 3);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.panel7.Size = new System.Drawing.Size(917, 45);
            this.panel7.TabIndex = 50;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel11.Controls.Add(this.buttonText);
            this.flowLayoutPanel11.Controls.Add(this.panel7);
            this.flowLayoutPanel11.Controls.Add(this.buttonClearText);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(7, 4);
            this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(1013, 51);
            this.flowLayoutPanel11.TabIndex = 51;
            // 
            // buttonText
            // 
            this.buttonText.AllowDrop = true;
            this.buttonText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonText.FlatAppearance.BorderSize = 0;
            this.buttonText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonText.ForeColor = System.Drawing.Color.Silver;
            this.buttonText.Image = global::StableDiffusion.Properties.Resources.text;
            this.buttonText.Location = new System.Drawing.Point(3, 3);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(39, 45);
            this.buttonText.TabIndex = 37;
            this.buttonText.UseVisualStyleBackColor = false;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panel14.Controls.Add(this.flowLayoutPanel14);
            this.panel14.Controls.Add(this.richTextBoxConsole);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 744);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1025, 40);
            this.panel14.TabIndex = 56;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.button12);
            this.flowLayoutPanel14.Controls.Add(this.buttonDonate);
            this.flowLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel14.Location = new System.Drawing.Point(748, 0);
            this.flowLayoutPanel14.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel14.Size = new System.Drawing.Size(277, 40);
            this.flowLayoutPanel14.TabIndex = 59;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.Silver;
            this.button12.Location = new System.Drawing.Point(142, 3);
            this.button12.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(135, 40);
            this.button12.TabIndex = 60;
            this.button12.Text = "Version : 0.9";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // buttonDonate
            // 
            this.buttonDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDonate.FlatAppearance.BorderSize = 0;
            this.buttonDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDonate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDonate.ForeColor = System.Drawing.Color.Silver;
            this.buttonDonate.Image = global::StableDiffusion.Properties.Resources.hearts;
            this.buttonDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDonate.Location = new System.Drawing.Point(4, 3);
            this.buttonDonate.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonDonate.Size = new System.Drawing.Size(135, 40);
            this.buttonDonate.TabIndex = 61;
            this.buttonDonate.Text = "Donate";
            this.buttonDonate.UseVisualStyleBackColor = false;
            this.buttonDonate.Click += new System.EventHandler(this.buttonDonate_Click);
            // 
            // richTextBoxConsole
            // 
            this.richTextBoxConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.richTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxConsole.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxConsole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxConsole.ForeColor = System.Drawing.Color.Silver;
            this.richTextBoxConsole.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxConsole.Name = "richTextBoxConsole";
            this.richTextBoxConsole.ReadOnly = true;
            this.richTextBoxConsole.Size = new System.Drawing.Size(746, 40);
            this.richTextBoxConsole.TabIndex = 66;
            this.richTextBoxConsole.Text = "";
            this.richTextBoxConsole.TextChanged += new System.EventHandler(this.richTextBoxConsole_TextChanged);
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.tabSettings.Controls.Add(this.flowLayoutPanel5);
            this.tabSettings.Location = new System.Drawing.Point(340, 60);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(680, 680);
            this.tabSettings.TabIndex = 57;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel15);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel16);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(674, 366);
            this.flowLayoutPanel5.TabIndex = 47;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel7.Controls.Add(this.buttonAnacondaPath);
            this.flowLayoutPanel7.Controls.Add(this.panel11);
            this.flowLayoutPanel7.Controls.Add(this.buttonBrowseAnacondaPath);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(674, 43);
            this.flowLayoutPanel7.TabIndex = 45;
            // 
            // buttonAnacondaPath
            // 
            this.buttonAnacondaPath.AllowDrop = true;
            this.buttonAnacondaPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonAnacondaPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnacondaPath.FlatAppearance.BorderSize = 0;
            this.buttonAnacondaPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnacondaPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAnacondaPath.ForeColor = System.Drawing.Color.Silver;
            this.buttonAnacondaPath.Location = new System.Drawing.Point(0, 0);
            this.buttonAnacondaPath.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAnacondaPath.Name = "buttonAnacondaPath";
            this.buttonAnacondaPath.Size = new System.Drawing.Size(180, 43);
            this.buttonAnacondaPath.TabIndex = 37;
            this.buttonAnacondaPath.Text = "Anaconda Path";
            this.buttonAnacondaPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnacondaPath.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel11.Controls.Add(this.textBoxAnacondaPath);
            this.panel11.Location = new System.Drawing.Point(183, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.panel11.Size = new System.Drawing.Size(432, 45);
            this.panel11.TabIndex = 49;
            // 
            // textBoxAnacondaPath
            // 
            this.textBoxAnacondaPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxAnacondaPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAnacondaPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAnacondaPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnacondaPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAnacondaPath.Location = new System.Drawing.Point(10, 10);
            this.textBoxAnacondaPath.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAnacondaPath.Name = "textBoxAnacondaPath";
            this.textBoxAnacondaPath.Size = new System.Drawing.Size(417, 22);
            this.textBoxAnacondaPath.TabIndex = 47;
            // 
            // buttonBrowseAnacondaPath
            // 
            this.buttonBrowseAnacondaPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonBrowseAnacondaPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowseAnacondaPath.FlatAppearance.BorderSize = 0;
            this.buttonBrowseAnacondaPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseAnacondaPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseAnacondaPath.ForeColor = System.Drawing.Color.Silver;
            this.buttonBrowseAnacondaPath.Image = global::StableDiffusion.Properties.Resources.search;
            this.buttonBrowseAnacondaPath.Location = new System.Drawing.Point(618, 0);
            this.buttonBrowseAnacondaPath.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowseAnacondaPath.Name = "buttonBrowseAnacondaPath";
            this.buttonBrowseAnacondaPath.Size = new System.Drawing.Size(50, 45);
            this.buttonBrowseAnacondaPath.TabIndex = 49;
            this.buttonBrowseAnacondaPath.UseVisualStyleBackColor = false;
            this.buttonBrowseAnacondaPath.Click += new System.EventHandler(this.buttonBrowseAnacondaPath_Click);
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel9.Controls.Add(this.buttonEnvName);
            this.flowLayoutPanel9.Controls.Add(this.panel12);
            this.flowLayoutPanel9.Controls.Add(this.buttonBrowseEnvs);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 55);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(674, 43);
            this.flowLayoutPanel9.TabIndex = 46;
            // 
            // buttonEnvName
            // 
            this.buttonEnvName.AllowDrop = true;
            this.buttonEnvName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonEnvName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnvName.FlatAppearance.BorderSize = 0;
            this.buttonEnvName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnvName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnvName.ForeColor = System.Drawing.Color.Silver;
            this.buttonEnvName.Location = new System.Drawing.Point(0, 0);
            this.buttonEnvName.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEnvName.Name = "buttonEnvName";
            this.buttonEnvName.Size = new System.Drawing.Size(180, 43);
            this.buttonEnvName.TabIndex = 37;
            this.buttonEnvName.Text = "Environment Name";
            this.buttonEnvName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEnvName.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel12.Controls.Add(this.textBoxEnvName);
            this.panel12.Location = new System.Drawing.Point(183, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.panel12.Size = new System.Drawing.Size(432, 45);
            this.panel12.TabIndex = 49;
            // 
            // textBoxEnvName
            // 
            this.textBoxEnvName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxEnvName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnvName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEnvName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEnvName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEnvName.Location = new System.Drawing.Point(10, 10);
            this.textBoxEnvName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEnvName.Name = "textBoxEnvName";
            this.textBoxEnvName.Size = new System.Drawing.Size(417, 22);
            this.textBoxEnvName.TabIndex = 47;
            this.textBoxEnvName.Text = "ldm";
            // 
            // buttonBrowseEnvs
            // 
            this.buttonBrowseEnvs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonBrowseEnvs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowseEnvs.FlatAppearance.BorderSize = 0;
            this.buttonBrowseEnvs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseEnvs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseEnvs.ForeColor = System.Drawing.Color.Silver;
            this.buttonBrowseEnvs.Image = global::StableDiffusion.Properties.Resources.search;
            this.buttonBrowseEnvs.Location = new System.Drawing.Point(618, 0);
            this.buttonBrowseEnvs.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowseEnvs.Name = "buttonBrowseEnvs";
            this.buttonBrowseEnvs.Size = new System.Drawing.Size(50, 45);
            this.buttonBrowseEnvs.TabIndex = 50;
            this.buttonBrowseEnvs.UseVisualStyleBackColor = false;
            this.buttonBrowseEnvs.Click += new System.EventHandler(this.buttonBrowseEnvs_Click);
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel10.Controls.Add(this.buttonEnvPath);
            this.flowLayoutPanel10.Controls.Add(this.panel16);
            this.flowLayoutPanel10.Controls.Add(this.buttonBrowseEnvPath);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 107);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(674, 43);
            this.flowLayoutPanel10.TabIndex = 47;
            // 
            // buttonEnvPath
            // 
            this.buttonEnvPath.AllowDrop = true;
            this.buttonEnvPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonEnvPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnvPath.FlatAppearance.BorderSize = 0;
            this.buttonEnvPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnvPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnvPath.ForeColor = System.Drawing.Color.Silver;
            this.buttonEnvPath.Location = new System.Drawing.Point(0, 0);
            this.buttonEnvPath.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEnvPath.Name = "buttonEnvPath";
            this.buttonEnvPath.Size = new System.Drawing.Size(180, 43);
            this.buttonEnvPath.TabIndex = 37;
            this.buttonEnvPath.Text = "Stable Diffusion Path";
            this.buttonEnvPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEnvPath.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel16.Controls.Add(this.textBoxEnvPath);
            this.panel16.Location = new System.Drawing.Point(183, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.panel16.Size = new System.Drawing.Size(432, 45);
            this.panel16.TabIndex = 49;
            // 
            // textBoxEnvPath
            // 
            this.textBoxEnvPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxEnvPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnvPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEnvPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEnvPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEnvPath.Location = new System.Drawing.Point(10, 10);
            this.textBoxEnvPath.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEnvPath.Name = "textBoxEnvPath";
            this.textBoxEnvPath.Size = new System.Drawing.Size(417, 22);
            this.textBoxEnvPath.TabIndex = 47;
            // 
            // buttonBrowseEnvPath
            // 
            this.buttonBrowseEnvPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonBrowseEnvPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowseEnvPath.FlatAppearance.BorderSize = 0;
            this.buttonBrowseEnvPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseEnvPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseEnvPath.ForeColor = System.Drawing.Color.Silver;
            this.buttonBrowseEnvPath.Image = global::StableDiffusion.Properties.Resources.search;
            this.buttonBrowseEnvPath.Location = new System.Drawing.Point(618, 0);
            this.buttonBrowseEnvPath.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowseEnvPath.Name = "buttonBrowseEnvPath";
            this.buttonBrowseEnvPath.Size = new System.Drawing.Size(50, 45);
            this.buttonBrowseEnvPath.TabIndex = 50;
            this.buttonBrowseEnvPath.UseVisualStyleBackColor = false;
            this.buttonBrowseEnvPath.Click += new System.EventHandler(this.buttonBrowseEnvPath_Click);
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel12.Controls.Add(this.buttonTxt2img);
            this.flowLayoutPanel12.Controls.Add(this.panel17);
            this.flowLayoutPanel12.Controls.Add(this.buttonBrowseTxt2imgScript);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(3, 159);
            this.flowLayoutPanel12.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(674, 43);
            this.flowLayoutPanel12.TabIndex = 48;
            // 
            // buttonTxt2img
            // 
            this.buttonTxt2img.AllowDrop = true;
            this.buttonTxt2img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonTxt2img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTxt2img.FlatAppearance.BorderSize = 0;
            this.buttonTxt2img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTxt2img.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTxt2img.ForeColor = System.Drawing.Color.Silver;
            this.buttonTxt2img.Location = new System.Drawing.Point(0, 0);
            this.buttonTxt2img.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTxt2img.Name = "buttonTxt2img";
            this.buttonTxt2img.Size = new System.Drawing.Size(180, 43);
            this.buttonTxt2img.TabIndex = 37;
            this.buttonTxt2img.Text = "txt2txt Path";
            this.buttonTxt2img.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTxt2img.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel17.Controls.Add(this.textBoxTxt2imgScript);
            this.panel17.Location = new System.Drawing.Point(183, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.panel17.Size = new System.Drawing.Size(432, 45);
            this.panel17.TabIndex = 49;
            // 
            // textBoxTxt2imgScript
            // 
            this.textBoxTxt2imgScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxTxt2imgScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTxt2imgScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTxt2imgScript.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTxt2imgScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxTxt2imgScript.Location = new System.Drawing.Point(10, 10);
            this.textBoxTxt2imgScript.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTxt2imgScript.Name = "textBoxTxt2imgScript";
            this.textBoxTxt2imgScript.Size = new System.Drawing.Size(417, 22);
            this.textBoxTxt2imgScript.TabIndex = 47;
            // 
            // buttonBrowseTxt2imgScript
            // 
            this.buttonBrowseTxt2imgScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonBrowseTxt2imgScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowseTxt2imgScript.FlatAppearance.BorderSize = 0;
            this.buttonBrowseTxt2imgScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseTxt2imgScript.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseTxt2imgScript.ForeColor = System.Drawing.Color.Silver;
            this.buttonBrowseTxt2imgScript.Image = global::StableDiffusion.Properties.Resources.search;
            this.buttonBrowseTxt2imgScript.Location = new System.Drawing.Point(618, 0);
            this.buttonBrowseTxt2imgScript.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowseTxt2imgScript.Name = "buttonBrowseTxt2imgScript";
            this.buttonBrowseTxt2imgScript.Size = new System.Drawing.Size(50, 45);
            this.buttonBrowseTxt2imgScript.TabIndex = 50;
            this.buttonBrowseTxt2imgScript.UseVisualStyleBackColor = false;
            this.buttonBrowseTxt2imgScript.Click += new System.EventHandler(this.buttonBrowseTxt2imgScript_Click);
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel13.Controls.Add(this.buttonImg2img);
            this.flowLayoutPanel13.Controls.Add(this.panel18);
            this.flowLayoutPanel13.Controls.Add(this.buttonBrowseImg2imgScript);
            this.flowLayoutPanel13.Location = new System.Drawing.Point(3, 211);
            this.flowLayoutPanel13.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(674, 43);
            this.flowLayoutPanel13.TabIndex = 49;
            // 
            // buttonImg2img
            // 
            this.buttonImg2img.AllowDrop = true;
            this.buttonImg2img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonImg2img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImg2img.FlatAppearance.BorderSize = 0;
            this.buttonImg2img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImg2img.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImg2img.ForeColor = System.Drawing.Color.Silver;
            this.buttonImg2img.Location = new System.Drawing.Point(0, 0);
            this.buttonImg2img.Margin = new System.Windows.Forms.Padding(0);
            this.buttonImg2img.Name = "buttonImg2img";
            this.buttonImg2img.Size = new System.Drawing.Size(180, 43);
            this.buttonImg2img.TabIndex = 37;
            this.buttonImg2img.Text = "img2img Path";
            this.buttonImg2img.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImg2img.UseVisualStyleBackColor = false;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel18.Controls.Add(this.textBoxImg2imgScript);
            this.panel18.Location = new System.Drawing.Point(183, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.panel18.Size = new System.Drawing.Size(432, 45);
            this.panel18.TabIndex = 49;
            // 
            // textBoxImg2imgScript
            // 
            this.textBoxImg2imgScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxImg2imgScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxImg2imgScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxImg2imgScript.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxImg2imgScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxImg2imgScript.Location = new System.Drawing.Point(10, 10);
            this.textBoxImg2imgScript.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxImg2imgScript.Name = "textBoxImg2imgScript";
            this.textBoxImg2imgScript.Size = new System.Drawing.Size(417, 22);
            this.textBoxImg2imgScript.TabIndex = 47;
            // 
            // buttonBrowseImg2imgScript
            // 
            this.buttonBrowseImg2imgScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonBrowseImg2imgScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowseImg2imgScript.FlatAppearance.BorderSize = 0;
            this.buttonBrowseImg2imgScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseImg2imgScript.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseImg2imgScript.ForeColor = System.Drawing.Color.Silver;
            this.buttonBrowseImg2imgScript.Image = global::StableDiffusion.Properties.Resources.search;
            this.buttonBrowseImg2imgScript.Location = new System.Drawing.Point(618, 0);
            this.buttonBrowseImg2imgScript.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowseImg2imgScript.Name = "buttonBrowseImg2imgScript";
            this.buttonBrowseImg2imgScript.Size = new System.Drawing.Size(50, 45);
            this.buttonBrowseImg2imgScript.TabIndex = 50;
            this.buttonBrowseImg2imgScript.UseVisualStyleBackColor = false;
            this.buttonBrowseImg2imgScript.Click += new System.EventHandler(this.buttonBrowseImg2imgScript_Click);
            // 
            // flowLayoutPanel15
            // 
            this.flowLayoutPanel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel15.Controls.Add(this.buttonImgs2imgs);
            this.flowLayoutPanel15.Controls.Add(this.panel19);
            this.flowLayoutPanel15.Controls.Add(this.buttonBrowseImgs2imgsScript);
            this.flowLayoutPanel15.Location = new System.Drawing.Point(3, 263);
            this.flowLayoutPanel15.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(674, 43);
            this.flowLayoutPanel15.TabIndex = 50;
            // 
            // buttonImgs2imgs
            // 
            this.buttonImgs2imgs.AllowDrop = true;
            this.buttonImgs2imgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonImgs2imgs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImgs2imgs.FlatAppearance.BorderSize = 0;
            this.buttonImgs2imgs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImgs2imgs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImgs2imgs.ForeColor = System.Drawing.Color.Silver;
            this.buttonImgs2imgs.Location = new System.Drawing.Point(0, 0);
            this.buttonImgs2imgs.Margin = new System.Windows.Forms.Padding(0);
            this.buttonImgs2imgs.Name = "buttonImgs2imgs";
            this.buttonImgs2imgs.Size = new System.Drawing.Size(180, 43);
            this.buttonImgs2imgs.TabIndex = 37;
            this.buttonImgs2imgs.Text = "imgs2imgs Path";
            this.buttonImgs2imgs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImgs2imgs.UseVisualStyleBackColor = false;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel19.Controls.Add(this.textBoxImgs2imgsScript);
            this.panel19.Location = new System.Drawing.Point(183, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel19.Name = "panel19";
            this.panel19.Padding = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.panel19.Size = new System.Drawing.Size(432, 45);
            this.panel19.TabIndex = 49;
            // 
            // textBoxImgs2imgsScript
            // 
            this.textBoxImgs2imgsScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxImgs2imgsScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxImgs2imgsScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxImgs2imgsScript.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxImgs2imgsScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxImgs2imgsScript.Location = new System.Drawing.Point(10, 10);
            this.textBoxImgs2imgsScript.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxImgs2imgsScript.Name = "textBoxImgs2imgsScript";
            this.textBoxImgs2imgsScript.Size = new System.Drawing.Size(417, 22);
            this.textBoxImgs2imgsScript.TabIndex = 47;
            // 
            // buttonBrowseImgs2imgsScript
            // 
            this.buttonBrowseImgs2imgsScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonBrowseImgs2imgsScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowseImgs2imgsScript.FlatAppearance.BorderSize = 0;
            this.buttonBrowseImgs2imgsScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseImgs2imgsScript.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseImgs2imgsScript.ForeColor = System.Drawing.Color.Silver;
            this.buttonBrowseImgs2imgsScript.Image = global::StableDiffusion.Properties.Resources.search;
            this.buttonBrowseImgs2imgsScript.Location = new System.Drawing.Point(618, 0);
            this.buttonBrowseImgs2imgsScript.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowseImgs2imgsScript.Name = "buttonBrowseImgs2imgsScript";
            this.buttonBrowseImgs2imgsScript.Size = new System.Drawing.Size(50, 45);
            this.buttonBrowseImgs2imgsScript.TabIndex = 50;
            this.buttonBrowseImgs2imgsScript.UseVisualStyleBackColor = false;
            this.buttonBrowseImgs2imgsScript.Click += new System.EventHandler(this.buttonBrowseImgs2imgsScript_Click);
            // 
            // flowLayoutPanel16
            // 
            this.flowLayoutPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel16.Controls.Add(this.buttonImg2Morph);
            this.flowLayoutPanel16.Controls.Add(this.panel20);
            this.flowLayoutPanel16.Controls.Add(this.buttonBrowseImg2morphScript);
            this.flowLayoutPanel16.Location = new System.Drawing.Point(3, 315);
            this.flowLayoutPanel16.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.flowLayoutPanel16.Name = "flowLayoutPanel16";
            this.flowLayoutPanel16.Size = new System.Drawing.Size(674, 43);
            this.flowLayoutPanel16.TabIndex = 51;
            // 
            // buttonImg2Morph
            // 
            this.buttonImg2Morph.AllowDrop = true;
            this.buttonImg2Morph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonImg2Morph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImg2Morph.FlatAppearance.BorderSize = 0;
            this.buttonImg2Morph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImg2Morph.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImg2Morph.ForeColor = System.Drawing.Color.Silver;
            this.buttonImg2Morph.Location = new System.Drawing.Point(0, 0);
            this.buttonImg2Morph.Margin = new System.Windows.Forms.Padding(0);
            this.buttonImg2Morph.Name = "buttonImg2Morph";
            this.buttonImg2Morph.Size = new System.Drawing.Size(180, 43);
            this.buttonImg2Morph.TabIndex = 37;
            this.buttonImg2Morph.Text = "img2morph Path";
            this.buttonImg2Morph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImg2Morph.UseVisualStyleBackColor = false;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel20.Controls.Add(this.textBoxImg2MorphScript);
            this.panel20.Location = new System.Drawing.Point(183, 0);
            this.panel20.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel20.Name = "panel20";
            this.panel20.Padding = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.panel20.Size = new System.Drawing.Size(432, 45);
            this.panel20.TabIndex = 49;
            // 
            // textBoxImg2MorphScript
            // 
            this.textBoxImg2MorphScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxImg2MorphScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxImg2MorphScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxImg2MorphScript.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxImg2MorphScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxImg2MorphScript.Location = new System.Drawing.Point(10, 10);
            this.textBoxImg2MorphScript.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxImg2MorphScript.Name = "textBoxImg2MorphScript";
            this.textBoxImg2MorphScript.Size = new System.Drawing.Size(417, 22);
            this.textBoxImg2MorphScript.TabIndex = 47;
            // 
            // buttonBrowseImg2morphScript
            // 
            this.buttonBrowseImg2morphScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonBrowseImg2morphScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowseImg2morphScript.FlatAppearance.BorderSize = 0;
            this.buttonBrowseImg2morphScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseImg2morphScript.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseImg2morphScript.ForeColor = System.Drawing.Color.Silver;
            this.buttonBrowseImg2morphScript.Image = global::StableDiffusion.Properties.Resources.search;
            this.buttonBrowseImg2morphScript.Location = new System.Drawing.Point(618, 0);
            this.buttonBrowseImg2morphScript.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowseImg2morphScript.Name = "buttonBrowseImg2morphScript";
            this.buttonBrowseImg2morphScript.Size = new System.Drawing.Size(50, 45);
            this.buttonBrowseImg2morphScript.TabIndex = 50;
            this.buttonBrowseImg2morphScript.UseVisualStyleBackColor = false;
            this.buttonBrowseImg2morphScript.Click += new System.EventHandler(this.buttonBrowseImg2morphScript_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel2.Controls.Add(this.panelSelectedPrompt);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel2.Controls.Add(this.panelSelectedImage);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel2.Controls.Add(this.panelSelectedSequence);
            this.flowLayoutPanel2.Controls.Add(this.buttonTabSequence);
            this.flowLayoutPanel2.Controls.Add(this.panelSelectedMorph);
            this.flowLayoutPanel2.Controls.Add(this.buttonTabMorph);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.panel10);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(174, 60);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(161, 276);
            this.flowLayoutPanel2.TabIndex = 64;
            // 
            // panelSelectedMorph
            // 
            this.panelSelectedMorph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panelSelectedMorph.Location = new System.Drawing.Point(3, 141);
            this.panelSelectedMorph.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panelSelectedMorph.Name = "panelSelectedMorph";
            this.panelSelectedMorph.Size = new System.Drawing.Size(20, 40);
            this.panelSelectedMorph.TabIndex = 66;
            // 
            // buttonTabMorph
            // 
            this.buttonTabMorph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonTabMorph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabMorph.FlatAppearance.BorderSize = 0;
            this.buttonTabMorph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabMorph.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTabMorph.ForeColor = System.Drawing.Color.Silver;
            this.buttonTabMorph.Location = new System.Drawing.Point(26, 141);
            this.buttonTabMorph.Name = "buttonTabMorph";
            this.buttonTabMorph.Size = new System.Drawing.Size(132, 40);
            this.buttonTabMorph.TabIndex = 59;
            this.buttonTabMorph.Text = "Morph";
            this.buttonTabMorph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabMorph.UseVisualStyleBackColor = false;
            this.buttonTabMorph.Click += new System.EventHandler(this.buttonTabMorph_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel2.Location = new System.Drawing.Point(3, 187);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 40);
            this.panel2.TabIndex = 68;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(26, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 67;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel10.Location = new System.Drawing.Point(3, 233);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(20, 40);
            this.panel10.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(26, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 69;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.48101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.51899F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOutFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonTabBrowse, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 40);
            this.tableLayoutPanel1.TabIndex = 65;
            // 
            // buttonTabBrowse
            // 
            this.buttonTabBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.buttonTabBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTabBrowse.FlatAppearance.BorderSize = 0;
            this.buttonTabBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabBrowse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTabBrowse.ForeColor = System.Drawing.Color.Silver;
            this.buttonTabBrowse.Location = new System.Drawing.Point(3, 0);
            this.buttonTabBrowse.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonTabBrowse.Name = "buttonTabBrowse";
            this.buttonTabBrowse.Size = new System.Drawing.Size(118, 40);
            this.buttonTabBrowse.TabIndex = 65;
            this.buttonTabBrowse.Text = "Browse";
            this.buttonTabBrowse.UseVisualStyleBackColor = false;
            this.buttonTabBrowse.Click += new System.EventHandler(this.buttonTabBrowse_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.buttonLaunchAsync);
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(7, 60);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(161, 277);
            this.flowLayoutPanel3.TabIndex = 65;
            // 
            // buttonLaunchAsync
            // 
            this.buttonLaunchAsync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonLaunchAsync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLaunchAsync.FlatAppearance.BorderSize = 0;
            this.buttonLaunchAsync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaunchAsync.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLaunchAsync.ForeColor = System.Drawing.Color.Silver;
            this.buttonLaunchAsync.Image = global::StableDiffusion.Properties.Resources.play_button;
            this.buttonLaunchAsync.Location = new System.Drawing.Point(3, 49);
            this.buttonLaunchAsync.Name = "buttonLaunchAsync";
            this.buttonLaunchAsync.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.buttonLaunchAsync.Size = new System.Drawing.Size(155, 178);
            this.buttonLaunchAsync.TabIndex = 67;
            this.buttonLaunchAsync.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLaunchAsync.UseVisualStyleBackColor = false;
            this.buttonLaunchAsync.Click += new System.EventHandler(this.buttonLaunchAsync_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.48101F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.51899F));
            this.tableLayoutPanel3.Controls.Add(this.buttonSettings, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonOpenSettings, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 233);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(158, 40);
            this.tableLayoutPanel3.TabIndex = 68;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSettings.ForeColor = System.Drawing.Color.Silver;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(3, 0);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(118, 40);
            this.buttonSettings.TabIndex = 68;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1025, 784);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.flowLayoutPanel11);
            this.Controls.Add(this.flowLayoutPanel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stable Diffusion UI";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN_iter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN_samples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSteps)).EndInit();
            this.flowLayoutPanelQuality.ResumeLayout(false);
            this.flowLayoutPanelQuality.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanelRepeat.ResumeLayout(false);
            this.flowLayoutPanelRepeat.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanelSamples.ResumeLayout(false);
            this.flowLayoutPanelSamples.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanelSeed.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanelGuidance.ResumeLayout(false);
            this.flowLayoutPanelGuidance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGuidance)).EndInit();
            this.panel13.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChannels)).EndInit();
            this.panel15.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.flowLayoutPanel14.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.flowLayoutPanel15.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.flowLayoutPanel16.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox textBoxPrompt;
        private Button buttonClearImage;
        private TrackBar trackBarStrength;
        private Button buttonN_iter;
        private Button buttonStrength;
        private TrackBar trackBarN_iter;
        private Button buttonN_samples;
        private TrackBar trackBarN_samples;
        private Button buttonSeed;
        private Button buttonSteps;
        private TrackBar trackBarSteps;
        private Button buttonOutFolder;
        private Button buttonSave;
        private FlowLayoutPanel flowLayoutPanelQuality;
        private FlowLayoutPanel flowLayoutPanelRepeat;
        private FlowLayoutPanel flowLayoutPanelSamples;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanelSeed;
        private FlowLayoutPanel flowLayoutPanel8;
        private Panel panel1;
        private TextBox textBoxSeed;
        private Panel panel3;
        private Label labelIteration;
        private Panel panel4;
        private Label labelN_iter;
        private Panel panel5;
        private Label labelN_samples;
        private Panel panel6;
        private Label labelStrength;
        private System.Windows.Forms.Timer timerSec;
        private Panel panel7;
        private FlowLayoutPanel flowLayoutPanel11;
        private Button buttonText;
        private ImageList imageList1;
        private Button buttonTabPrompt;
        private Button buttonTabImage;
        private Panel panel14;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonChannels;
        private TrackBar trackBarChannels;
        private Panel panel15;
        private Label labelChannels;
        private Panel tabSettings;
        private Button buttonTabSequence;
        private Button buttonOpenSettings;
        private Button button12;
        private FlowLayoutPanel flowLayoutPanel14;
        private Button buttonDonate;
        private Panel panelSelectedPrompt;
        private Panel panelSelectedImage;
        private Panel panelSelectedSequence;
        private Button buttonClearText;
        private FlowLayoutPanel flowLayoutPanelGuidance;
        private Button buttonGuidance;
        private TrackBar trackBarGuidance;
        private Panel panel13;
        private Label labelGuidance;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panelSelectedMorph;
        private Button buttonTabMorph;
        private Button buttonTabBrowse;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button buttonSize;
        private Panel panel8;
        private TextBox textBoxSizeW;
        private Panel panel9;
        private TextBox textBoxSizeH;
        private Button buttonSizeShape;
        private Panel panel10;
        private Button button1;
        private RichTextBox richTextBoxConsole;
        private Button buttonLaunchAsync;
        private Button buttonSettings;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button buttonAnacondaPath;
        private Panel panel11;
        private TextBox textBoxAnacondaPath;
        private FlowLayoutPanel flowLayoutPanel9;
        private Button buttonEnvName;
        private Panel panel12;
        private TextBox textBoxEnvName;
        private FlowLayoutPanel flowLayoutPanel10;
        private Button buttonEnvPath;
        private Panel panel16;
        private TextBox textBoxEnvPath;
        private FlowLayoutPanel flowLayoutPanel12;
        private Button buttonTxt2img;
        private Panel panel17;
        private TextBox textBoxTxt2imgScript;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonBrowseAnacondaPath;
        private Button buttonBrowseEnvs;
        private Button buttonBrowseEnvPath;
        private Button buttonBrowseTxt2imgScript;
        private FlowLayoutPanel flowLayoutPanel13;
        private Button buttonImg2img;
        private Panel panel18;
        private TextBox textBoxImg2imgScript;
        private Button buttonBrowseImg2imgScript;
        private FlowLayoutPanel flowLayoutPanel15;
        private Button buttonImgs2imgs;
        private Panel panel19;
        private TextBox textBoxImgs2imgsScript;
        private Button buttonBrowseImgs2imgsScript;
        private FlowLayoutPanel flowLayoutPanel16;
        private Button buttonImg2Morph;
        private Panel panel20;
        private TextBox textBoxImg2MorphScript;
        private Button buttonBrowseImg2morphScript;
    }
}