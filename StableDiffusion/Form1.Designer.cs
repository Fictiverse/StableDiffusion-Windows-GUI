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
            this.textBoxPrompt = new System.Windows.Forms.TextBox();
            this.listBoxPreset = new System.Windows.Forms.ListBox();
            this.listBoxPresetStyles = new System.Windows.Forms.ListBox();
            this.listBoxGenericStyles = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.flowLayoutPanelPaintTools = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCpick = new System.Windows.Forms.Panel();
            this.panelGradiant = new System.Windows.Forms.Panel();
            this.panelC2 = new System.Windows.Forms.Panel();
            this.panelC3 = new System.Windows.Forms.Panel();
            this.panelC4 = new System.Windows.Forms.Panel();
            this.panelC6 = new System.Windows.Forms.Panel();
            this.panelC5 = new System.Windows.Forms.Panel();
            this.panelC7 = new System.Windows.Forms.Panel();
            this.panelC8 = new System.Windows.Forms.Panel();
            this.panelC9 = new System.Windows.Forms.Panel();
            this.panelC10 = new System.Windows.Forms.Panel();
            this.panelC11 = new System.Windows.Forms.Panel();
            this.panelC12 = new System.Windows.Forms.Panel();
            this.panelC13 = new System.Windows.Forms.Panel();
            this.panelTabImages = new System.Windows.Forms.Panel();
            this.buttonPastImage = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.listBoxInitImages = new System.Windows.Forms.ListBox();
            this.buttonPencilRedo = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.listViewInitImages = new System.Windows.Forms.ListView();
            this.ImagesList = new System.Windows.Forms.ColumnHeader();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonInpaint = new System.Windows.Forms.Button();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClearImage = new System.Windows.Forms.Button();
            this.buttonStrength = new System.Windows.Forms.Button();
            this.trackBarStrength = new System.Windows.Forms.TrackBar();
            this.buttonN_iter = new System.Windows.Forms.Button();
            this.trackBarN_iter = new System.Windows.Forms.TrackBar();
            this.buttonN_samples = new System.Windows.Forms.Button();
            this.trackBarN_samples = new System.Windows.Forms.TrackBar();
            this.buttonSeed = new System.Windows.Forms.Button();
            this.buttonIteration = new System.Windows.Forms.Button();
            this.trackBarIteration = new System.Windows.Forms.TrackBar();
            this.buttonOutFolder = new System.Windows.Forms.Button();
            this.buttonClearOutputFolder = new System.Windows.Forms.Button();
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
            this.buttonOpenSettings = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTabImage = new System.Windows.Forms.Button();
            this.buttonTabSequence = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClearStyle = new System.Windows.Forms.Button();
            this.buttonTabPrompt = new System.Windows.Forms.Button();
            this.panelSelectedPrompt = new System.Windows.Forms.Panel();
            this.panelSelectedImage = new System.Windows.Forms.Panel();
            this.panelSelectedSequence = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.timerSec = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel14 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.panelTabPrompt = new System.Windows.Forms.Panel();
            this.buttonAddSelectedStylesToPreset = new System.Windows.Forms.Button();
            this.buttonAddSelectedStylesToGeneric = new System.Windows.Forms.Button();
            this.buttonAddSelectedPreset = new System.Windows.Forms.Button();
            this.buttonAddSelectedToStyles = new System.Windows.Forms.Button();
            this.buttonAddGenericToPreset = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.textBoxGenericStyle = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemoveGenericStyle = new System.Windows.Forms.Button();
            this.buttonAddGenericStyle = new System.Windows.Forms.Button();
            this.buttonAddAllSelectedPreset = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.textBoxPresetStyle = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemovePresetStyle = new System.Windows.Forms.Button();
            this.buttonAddPresetStyle = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.textBoxPreset = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemovePreset = new System.Windows.Forms.Button();
            this.buttonAddPreset = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveSelectedStyles = new System.Windows.Forms.Button();
            this.buttonSaveGenericStyles = new System.Windows.Forms.Button();
            this.buttonSavePresets = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemoveStyles = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedStyles = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.buttonShuffleSelectedStyles = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxSelectedStyles = new System.Windows.Forms.ListBox();
            this.panelTabSequence = new System.Windows.Forms.Panel();
            this.buttonWorkInProgress1 = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSelectedMorph = new System.Windows.Forms.Panel();
            this.buttonTabMorph = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelPaintTools.SuspendLayout();
            this.panelTabImages.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN_iter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN_samples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIteration)).BeginInit();
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
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanelGuidance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGuidance)).BeginInit();
            this.panel13.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChannels)).BeginInit();
            this.panel15.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.panelTabPrompt.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel19.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel17.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTabSequence.SuspendLayout();
            this.panel16.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.textBoxPrompt.Size = new System.Drawing.Size(948, 22);
            this.textBoxPrompt.TabIndex = 1;
            this.textBoxPrompt.Text = "identity photo of a woman";
            // 
            // listBoxPreset
            // 
            this.listBoxPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.listBoxPreset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPreset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxPreset.ForeColor = System.Drawing.Color.Silver;
            this.listBoxPreset.FormattingEnabled = true;
            this.listBoxPreset.ItemHeight = 20;
            this.listBoxPreset.Items.AddRange(new object[] {
            "Portrait",
            "Oil painting",
            "Pen drawing",
            "Landscape art"});
            this.listBoxPreset.Location = new System.Drawing.Point(10, 10);
            this.listBoxPreset.Name = "listBoxPreset";
            this.listBoxPreset.Size = new System.Drawing.Size(198, 135);
            this.listBoxPreset.TabIndex = 2;
            this.listBoxPreset.SelectedIndexChanged += new System.EventHandler(this.listBoxPreset_SelectedIndexChanged);
            // 
            // listBoxPresetStyles
            // 
            this.listBoxPresetStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.listBoxPresetStyles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPresetStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPresetStyles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPresetStyles.ForeColor = System.Drawing.Color.Silver;
            this.listBoxPresetStyles.FormattingEnabled = true;
            this.listBoxPresetStyles.ItemHeight = 17;
            this.listBoxPresetStyles.Location = new System.Drawing.Point(10, 10);
            this.listBoxPresetStyles.Name = "listBoxPresetStyles";
            this.listBoxPresetStyles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPresetStyles.Size = new System.Drawing.Size(198, 227);
            this.listBoxPresetStyles.TabIndex = 3;
            // 
            // listBoxGenericStyles
            // 
            this.listBoxGenericStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.listBoxGenericStyles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxGenericStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxGenericStyles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxGenericStyles.ForeColor = System.Drawing.Color.Silver;
            this.listBoxGenericStyles.FormattingEnabled = true;
            this.listBoxGenericStyles.ItemHeight = 17;
            this.listBoxGenericStyles.Items.AddRange(new object[] {
            "ultrarealistic",
            "highly detailed",
            "photorealistic",
            "digital painting",
            "artstation",
            "smooth",
            "sharp focus",
            "illustration",
            "3d",
            "unreal engine",
            "octane render",
            "vray render",
            "houdini",
            "global illumination",
            "ray tracing",
            "4k",
            "anime",
            "colorful",
            "atmospheric",
            "beautifull",
            "cinematic",
            "hdr",
            "artworks",
            "synthwave"});
            this.listBoxGenericStyles.Location = new System.Drawing.Point(10, 10);
            this.listBoxGenericStyles.Name = "listBoxGenericStyles";
            this.listBoxGenericStyles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxGenericStyles.Size = new System.Drawing.Size(198, 437);
            this.listBoxGenericStyles.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.ForeColor = System.Drawing.Color.Silver;
            this.buttonStart.Image = global::StableDiffusion.Properties.Resources.play_button;
            this.buttonStart.Location = new System.Drawing.Point(46, 3);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.buttonStart.Size = new System.Drawing.Size(121, 178);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // flowLayoutPanelPaintTools
            // 
            this.flowLayoutPanelPaintTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelCpick);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelGradiant);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC2);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC3);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC4);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC6);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC5);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC7);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC8);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC9);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC10);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC11);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC12);
            this.flowLayoutPanelPaintTools.Controls.Add(this.panelC13);
            this.flowLayoutPanelPaintTools.Enabled = false;
            this.flowLayoutPanelPaintTools.Location = new System.Drawing.Point(244, 518);
            this.flowLayoutPanelPaintTools.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelPaintTools.Name = "flowLayoutPanelPaintTools";
            this.flowLayoutPanelPaintTools.Size = new System.Drawing.Size(433, 75);
            this.flowLayoutPanelPaintTools.TabIndex = 20;
            // 
            // panelCpick
            // 
            this.panelCpick.BackColor = System.Drawing.Color.White;
            this.panelCpick.Location = new System.Drawing.Point(5, 3);
            this.panelCpick.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.panelCpick.Name = "panelCpick";
            this.panelCpick.Size = new System.Drawing.Size(62, 33);
            this.panelCpick.TabIndex = 24;
            // 
            // panelGradiant
            // 
            this.panelGradiant.BackColor = System.Drawing.Color.Black;
            this.panelGradiant.Location = new System.Drawing.Point(73, 3);
            this.panelGradiant.Name = "panelGradiant";
            this.panelGradiant.Size = new System.Drawing.Size(354, 33);
            this.panelGradiant.TabIndex = 21;
            this.panelGradiant.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGradiant_Paint);
            this.panelGradiant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGradiant_MouseDown);
            this.panelGradiant.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGradiant_MouseMove);
            this.panelGradiant.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelGradiant_MouseUp);
            // 
            // panelC2
            // 
            this.panelC2.BackColor = System.Drawing.Color.Silver;
            this.panelC2.Location = new System.Drawing.Point(5, 44);
            this.panelC2.Margin = new System.Windows.Forms.Padding(5);
            this.panelC2.Name = "panelC2";
            this.panelC2.Size = new System.Drawing.Size(26, 25);
            this.panelC2.TabIndex = 21;
            this.panelC2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC3
            // 
            this.panelC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(85)))), ((int)(((byte)(36)))));
            this.panelC3.Location = new System.Drawing.Point(41, 44);
            this.panelC3.Margin = new System.Windows.Forms.Padding(5);
            this.panelC3.Name = "panelC3";
            this.panelC3.Size = new System.Drawing.Size(26, 25);
            this.panelC3.TabIndex = 23;
            this.panelC3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC4
            // 
            this.panelC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelC4.Location = new System.Drawing.Point(77, 44);
            this.panelC4.Margin = new System.Windows.Forms.Padding(5);
            this.panelC4.Name = "panelC4";
            this.panelC4.Size = new System.Drawing.Size(26, 25);
            this.panelC4.TabIndex = 24;
            this.panelC4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC6
            // 
            this.panelC6.BackColor = System.Drawing.Color.Yellow;
            this.panelC6.Location = new System.Drawing.Point(113, 44);
            this.panelC6.Margin = new System.Windows.Forms.Padding(5);
            this.panelC6.Name = "panelC6";
            this.panelC6.Size = new System.Drawing.Size(26, 25);
            this.panelC6.TabIndex = 22;
            this.panelC6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC5
            // 
            this.panelC5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(49)))));
            this.panelC5.Location = new System.Drawing.Point(149, 44);
            this.panelC5.Margin = new System.Windows.Forms.Padding(5);
            this.panelC5.Name = "panelC5";
            this.panelC5.Size = new System.Drawing.Size(26, 25);
            this.panelC5.TabIndex = 25;
            this.panelC5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC7
            // 
            this.panelC7.BackColor = System.Drawing.Color.SkyBlue;
            this.panelC7.Location = new System.Drawing.Point(185, 44);
            this.panelC7.Margin = new System.Windows.Forms.Padding(5);
            this.panelC7.Name = "panelC7";
            this.panelC7.Size = new System.Drawing.Size(26, 25);
            this.panelC7.TabIndex = 26;
            this.panelC7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC8
            // 
            this.panelC8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(148)))));
            this.panelC8.Location = new System.Drawing.Point(221, 44);
            this.panelC8.Margin = new System.Windows.Forms.Padding(5);
            this.panelC8.Name = "panelC8";
            this.panelC8.Size = new System.Drawing.Size(26, 25);
            this.panelC8.TabIndex = 27;
            this.panelC8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC9
            // 
            this.panelC9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.panelC9.Location = new System.Drawing.Point(257, 44);
            this.panelC9.Margin = new System.Windows.Forms.Padding(5);
            this.panelC9.Name = "panelC9";
            this.panelC9.Size = new System.Drawing.Size(26, 25);
            this.panelC9.TabIndex = 28;
            this.panelC9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC10
            // 
            this.panelC10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelC10.Location = new System.Drawing.Point(293, 44);
            this.panelC10.Margin = new System.Windows.Forms.Padding(5);
            this.panelC10.Name = "panelC10";
            this.panelC10.Size = new System.Drawing.Size(26, 25);
            this.panelC10.TabIndex = 29;
            this.panelC10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC11
            // 
            this.panelC11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelC11.Location = new System.Drawing.Point(329, 44);
            this.panelC11.Margin = new System.Windows.Forms.Padding(5);
            this.panelC11.Name = "panelC11";
            this.panelC11.Size = new System.Drawing.Size(26, 25);
            this.panelC11.TabIndex = 30;
            this.panelC11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC12
            // 
            this.panelC12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelC12.Location = new System.Drawing.Point(365, 44);
            this.panelC12.Margin = new System.Windows.Forms.Padding(5);
            this.panelC12.Name = "panelC12";
            this.panelC12.Size = new System.Drawing.Size(26, 25);
            this.panelC12.TabIndex = 30;
            this.panelC12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelC13
            // 
            this.panelC13.BackColor = System.Drawing.Color.Olive;
            this.panelC13.Location = new System.Drawing.Point(401, 44);
            this.panelC13.Margin = new System.Windows.Forms.Padding(5);
            this.panelC13.Name = "panelC13";
            this.panelC13.Size = new System.Drawing.Size(26, 25);
            this.panelC13.TabIndex = 30;
            this.panelC13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelC_MouseClick);
            // 
            // panelTabImages
            // 
            this.panelTabImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelTabImages.Controls.Add(this.buttonPastImage);
            this.panelTabImages.Controls.Add(this.panel9);
            this.panelTabImages.Controls.Add(this.buttonPencilRedo);
            this.panelTabImages.Controls.Add(this.panel12);
            this.panelTabImages.Controls.Add(this.buttonPencil);
            this.panelTabImages.Controls.Add(this.buttonInpaint);
            this.panelTabImages.Controls.Add(this.buttonOpenImage);
            this.panelTabImages.Controls.Add(this.pictureBox1);
            this.panelTabImages.Controls.Add(this.flowLayoutPanelPaintTools);
            this.panelTabImages.Location = new System.Drawing.Point(1033, 59);
            this.panelTabImages.Name = "panelTabImages";
            this.panelTabImages.Size = new System.Drawing.Size(680, 600);
            this.panelTabImages.TabIndex = 21;
            // 
            // buttonPastImage
            // 
            this.buttonPastImage.AllowDrop = true;
            this.buttonPastImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonPastImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPastImage.FlatAppearance.BorderSize = 0;
            this.buttonPastImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPastImage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPastImage.ForeColor = System.Drawing.Color.Silver;
            this.buttonPastImage.Image = global::StableDiffusion.Properties.Resources.paste;
            this.buttonPastImage.Location = new System.Drawing.Point(520, 5);
            this.buttonPastImage.Name = "buttonPastImage";
            this.buttonPastImage.Size = new System.Drawing.Size(43, 40);
            this.buttonPastImage.TabIndex = 64;
            this.buttonPastImage.UseVisualStyleBackColor = false;
            this.buttonPastImage.Click += new System.EventHandler(this.buttonPastImage_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel9.Controls.Add(this.listBoxInitImages);
            this.panel9.Location = new System.Drawing.Point(520, 51);
            this.panel9.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10);
            this.panel9.Size = new System.Drawing.Size(155, 232);
            this.panel9.TabIndex = 53;
            // 
            // listBoxInitImages
            // 
            this.listBoxInitImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.listBoxInitImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxInitImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInitImages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxInitImages.ForeColor = System.Drawing.Color.Silver;
            this.listBoxInitImages.FormattingEnabled = true;
            this.listBoxInitImages.ItemHeight = 20;
            this.listBoxInitImages.Location = new System.Drawing.Point(10, 10);
            this.listBoxInitImages.Name = "listBoxInitImages";
            this.listBoxInitImages.Size = new System.Drawing.Size(135, 212);
            this.listBoxInitImages.TabIndex = 42;
            this.listBoxInitImages.SelectedIndexChanged += new System.EventHandler(this.listBoxInitImages_SelectedIndexChanged);
            // 
            // buttonPencilRedo
            // 
            this.buttonPencilRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonPencilRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPencilRedo.FlatAppearance.BorderSize = 0;
            this.buttonPencilRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPencilRedo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPencilRedo.ForeColor = System.Drawing.Color.Silver;
            this.buttonPencilRedo.Image = global::StableDiffusion.Properties.Resources.go_back_arrow;
            this.buttonPencilRedo.Location = new System.Drawing.Point(83, 520);
            this.buttonPencilRedo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.buttonPencilRedo.Name = "buttonPencilRedo";
            this.buttonPencilRedo.Size = new System.Drawing.Size(75, 75);
            this.buttonPencilRedo.TabIndex = 55;
            this.buttonPencilRedo.Text = "Undo";
            this.buttonPencilRedo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPencilRedo.UseVisualStyleBackColor = false;
            this.buttonPencilRedo.Click += new System.EventHandler(this.buttonPencilRedo_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel12.Controls.Add(this.listViewInitImages);
            this.panel12.Location = new System.Drawing.Point(520, 291);
            this.panel12.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10);
            this.panel12.Size = new System.Drawing.Size(155, 226);
            this.panel12.TabIndex = 54;
            // 
            // listViewInitImages
            // 
            this.listViewInitImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(5)))), ((int)(((byte)(10)))));
            this.listViewInitImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewInitImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImagesList});
            this.listViewInitImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewInitImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInitImages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewInitImages.ForeColor = System.Drawing.Color.Silver;
            this.listViewInitImages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewInitImages.Location = new System.Drawing.Point(10, 10);
            this.listViewInitImages.Name = "listViewInitImages";
            this.listViewInitImages.Size = new System.Drawing.Size(135, 206);
            this.listViewInitImages.TabIndex = 55;
            this.listViewInitImages.UseCompatibleStateImageBehavior = false;
            this.listViewInitImages.SelectedIndexChanged += new System.EventHandler(this.listViewInitImages_SelectedIndexChanged);
            // 
            // ImagesList
            // 
            this.ImagesList.Text = "Images List";
            this.ImagesList.Width = 100;
            // 
            // buttonPencil
            // 
            this.buttonPencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPencil.FlatAppearance.BorderSize = 0;
            this.buttonPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPencil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPencil.ForeColor = System.Drawing.Color.Silver;
            this.buttonPencil.Image = global::StableDiffusion.Properties.Resources.edit;
            this.buttonPencil.Location = new System.Drawing.Point(5, 520);
            this.buttonPencil.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(75, 75);
            this.buttonPencil.TabIndex = 42;
            this.buttonPencil.Text = "Paint";
            this.buttonPencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPencil.UseVisualStyleBackColor = false;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonInpaint
            // 
            this.buttonInpaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonInpaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInpaint.FlatAppearance.BorderSize = 0;
            this.buttonInpaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInpaint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInpaint.ForeColor = System.Drawing.Color.Silver;
            this.buttonInpaint.Image = global::StableDiffusion.Properties.Resources.eraser;
            this.buttonInpaint.Location = new System.Drawing.Point(161, 520);
            this.buttonInpaint.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.buttonInpaint.Name = "buttonInpaint";
            this.buttonInpaint.Size = new System.Drawing.Size(78, 75);
            this.buttonInpaint.TabIndex = 47;
            this.buttonInpaint.Text = "Inpaint";
            this.buttonInpaint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInpaint.UseVisualStyleBackColor = false;
            this.buttonInpaint.Click += new System.EventHandler(this.buttonInpaint_Click);
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.AllowDrop = true;
            this.buttonOpenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonOpenImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenImage.FlatAppearance.BorderSize = 0;
            this.buttonOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenImage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenImage.ForeColor = System.Drawing.Color.Silver;
            this.buttonOpenImage.Image = global::StableDiffusion.Properties.Resources.add_photo;
            this.buttonOpenImage.Location = new System.Drawing.Point(569, 5);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(106, 40);
            this.buttonOpenImage.TabIndex = 30;
            this.buttonOpenImage.UseVisualStyleBackColor = false;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            this.buttonOpenImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonImage_DragDrop);
            this.buttonOpenImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.buttonImage_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonClearImage
            // 
            this.buttonClearImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
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
            this.buttonStrength.Location = new System.Drawing.Point(0, 0);
            this.buttonStrength.Margin = new System.Windows.Forms.Padding(0);
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
            this.trackBarStrength.Location = new System.Drawing.Point(116, 0);
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
            this.buttonN_iter.Location = new System.Drawing.Point(0, 0);
            this.buttonN_iter.Margin = new System.Windows.Forms.Padding(0);
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
            this.trackBarN_iter.Location = new System.Drawing.Point(116, 0);
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
            this.buttonN_samples.Location = new System.Drawing.Point(0, 0);
            this.buttonN_samples.Margin = new System.Windows.Forms.Padding(0);
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
            this.trackBarN_samples.Location = new System.Drawing.Point(116, 0);
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
            this.buttonSeed.Location = new System.Drawing.Point(0, 0);
            this.buttonSeed.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSeed.Name = "buttonSeed";
            this.buttonSeed.Size = new System.Drawing.Size(113, 43);
            this.buttonSeed.TabIndex = 37;
            this.buttonSeed.Text = "Seed";
            this.buttonSeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSeed.UseVisualStyleBackColor = false;
            this.buttonSeed.Click += new System.EventHandler(this.buttonSeed_Click);
            // 
            // buttonIteration
            // 
            this.buttonIteration.AllowDrop = true;
            this.buttonIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonIteration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIteration.FlatAppearance.BorderSize = 0;
            this.buttonIteration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIteration.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIteration.ForeColor = System.Drawing.Color.Silver;
            this.buttonIteration.Image = global::StableDiffusion.Properties.Resources.volume;
            this.buttonIteration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIteration.Location = new System.Drawing.Point(0, 0);
            this.buttonIteration.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIteration.Name = "buttonIteration";
            this.buttonIteration.Size = new System.Drawing.Size(113, 43);
            this.buttonIteration.TabIndex = 38;
            this.buttonIteration.Text = "Quality";
            this.buttonIteration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIteration.UseVisualStyleBackColor = false;
            this.buttonIteration.Click += new System.EventHandler(this.buttonIteration_Click);
            // 
            // trackBarIteration
            // 
            this.trackBarIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.trackBarIteration.LargeChange = 1;
            this.trackBarIteration.Location = new System.Drawing.Point(116, 0);
            this.trackBarIteration.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.trackBarIteration.Maximum = 8;
            this.trackBarIteration.Minimum = 1;
            this.trackBarIteration.Name = "trackBarIteration";
            this.trackBarIteration.Size = new System.Drawing.Size(150, 45);
            this.trackBarIteration.TabIndex = 39;
            this.trackBarIteration.Value = 2;
            this.trackBarIteration.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // buttonOutFolder
            // 
            this.buttonOutFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonOutFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOutFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOutFolder.FlatAppearance.BorderSize = 0;
            this.buttonOutFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutFolder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOutFolder.ForeColor = System.Drawing.Color.Silver;
            this.buttonOutFolder.Image = global::StableDiffusion.Properties.Resources.search;
            this.buttonOutFolder.Location = new System.Drawing.Point(3, 3);
            this.buttonOutFolder.Name = "buttonOutFolder";
            this.buttonOutFolder.Size = new System.Drawing.Size(39, 40);
            this.buttonOutFolder.TabIndex = 40;
            this.buttonOutFolder.UseVisualStyleBackColor = false;
            this.buttonOutFolder.Click += new System.EventHandler(this.buttonOutFolder_Click);
            // 
            // buttonClearOutputFolder
            // 
            this.buttonClearOutputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonClearOutputFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearOutputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearOutputFolder.FlatAppearance.BorderSize = 0;
            this.buttonClearOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearOutputFolder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClearOutputFolder.ForeColor = System.Drawing.Color.Silver;
            this.buttonClearOutputFolder.Image = global::StableDiffusion.Properties.Resources.delete_cross1;
            this.buttonClearOutputFolder.Location = new System.Drawing.Point(3, 49);
            this.buttonClearOutputFolder.Name = "buttonClearOutputFolder";
            this.buttonClearOutputFolder.Size = new System.Drawing.Size(39, 40);
            this.buttonClearOutputFolder.TabIndex = 41;
            this.buttonClearOutputFolder.UseVisualStyleBackColor = false;
            this.buttonClearOutputFolder.Click += new System.EventHandler(this.buttonClearOutputFolder_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.Silver;
            this.buttonSave.Image = global::StableDiffusion.Properties.Resources.save1;
            this.buttonSave.Location = new System.Drawing.Point(272, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(47, 44);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSave_MouseUp);
            // 
            // flowLayoutPanelQuality
            // 
            this.flowLayoutPanelQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanelQuality.Controls.Add(this.buttonIteration);
            this.flowLayoutPanelQuality.Controls.Add(this.trackBarIteration);
            this.flowLayoutPanelQuality.Controls.Add(this.panel3);
            this.flowLayoutPanelQuality.Location = new System.Drawing.Point(3, 52);
            this.flowLayoutPanelQuality.Name = "flowLayoutPanelQuality";
            this.flowLayoutPanelQuality.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanelQuality.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.labelIteration);
            this.panel3.Location = new System.Drawing.Point(272, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
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
            this.flowLayoutPanelRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanelRepeat.Controls.Add(this.buttonN_iter);
            this.flowLayoutPanelRepeat.Controls.Add(this.trackBarN_iter);
            this.flowLayoutPanelRepeat.Controls.Add(this.panel4);
            this.flowLayoutPanelRepeat.Location = new System.Drawing.Point(3, 101);
            this.flowLayoutPanelRepeat.Name = "flowLayoutPanelRepeat";
            this.flowLayoutPanelRepeat.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanelRepeat.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.labelN_iter);
            this.panel4.Location = new System.Drawing.Point(272, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
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
            this.flowLayoutPanelSamples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanelSamples.Controls.Add(this.buttonN_samples);
            this.flowLayoutPanelSamples.Controls.Add(this.trackBarN_samples);
            this.flowLayoutPanelSamples.Controls.Add(this.panel5);
            this.flowLayoutPanelSamples.Location = new System.Drawing.Point(3, 150);
            this.flowLayoutPanelSamples.Name = "flowLayoutPanelSamples";
            this.flowLayoutPanelSamples.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanelSamples.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.labelN_samples);
            this.panel5.Location = new System.Drawing.Point(272, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
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
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanel6.Controls.Add(this.buttonStrength);
            this.flowLayoutPanel6.Controls.Add(this.trackBarStrength);
            this.flowLayoutPanel6.Controls.Add(this.panel6);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 297);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanel6.TabIndex = 45;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel6.Controls.Add(this.labelStrength);
            this.panel6.Location = new System.Drawing.Point(272, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
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
            this.flowLayoutPanelSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanelSeed.Controls.Add(this.buttonSeed);
            this.flowLayoutPanelSeed.Controls.Add(this.panel1);
            this.flowLayoutPanelSeed.Controls.Add(this.buttonSave);
            this.flowLayoutPanelSeed.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelSeed.Name = "flowLayoutPanelSeed";
            this.flowLayoutPanelSeed.Size = new System.Drawing.Size(325, 43);
            this.flowLayoutPanelSeed.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.textBoxSeed);
            this.panel1.Location = new System.Drawing.Point(116, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.panel1.Size = new System.Drawing.Size(150, 45);
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
            this.textBoxSeed.Size = new System.Drawing.Size(140, 22);
            this.textBoxSeed.TabIndex = 47;
            this.textBoxSeed.Text = "777";
            this.textBoxSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSeed_KeyPress);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanelSeed);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanelQuality);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanelRepeat);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanelSamples);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanelGuidance);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(7, 317);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(325, 343);
            this.flowLayoutPanel8.TabIndex = 46;
            // 
            // flowLayoutPanelGuidance
            // 
            this.flowLayoutPanelGuidance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanelGuidance.Controls.Add(this.buttonGuidance);
            this.flowLayoutPanelGuidance.Controls.Add(this.trackBarGuidance);
            this.flowLayoutPanelGuidance.Controls.Add(this.panel13);
            this.flowLayoutPanelGuidance.Location = new System.Drawing.Point(3, 199);
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
            this.buttonGuidance.Location = new System.Drawing.Point(0, 0);
            this.buttonGuidance.Margin = new System.Windows.Forms.Padding(0);
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
            this.trackBarGuidance.Location = new System.Drawing.Point(116, 0);
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
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
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
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanel1.Controls.Add(this.buttonChannels);
            this.flowLayoutPanel1.Controls.Add(this.trackBarChannels);
            this.flowLayoutPanel1.Controls.Add(this.panel15);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 248);
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
            this.buttonChannels.Location = new System.Drawing.Point(0, 0);
            this.buttonChannels.Margin = new System.Windows.Forms.Padding(0);
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
            this.trackBarChannels.Location = new System.Drawing.Point(116, 0);
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
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
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
            // buttonOpenSettings
            // 
            this.buttonOpenSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonOpenSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenSettings.FlatAppearance.BorderSize = 0;
            this.buttonOpenSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenSettings.ForeColor = System.Drawing.Color.Silver;
            this.buttonOpenSettings.Image = global::StableDiffusion.Properties.Resources.option_dequipement;
            this.buttonOpenSettings.Location = new System.Drawing.Point(3, 141);
            this.buttonOpenSettings.Name = "buttonOpenSettings";
            this.buttonOpenSettings.Size = new System.Drawing.Size(39, 42);
            this.buttonOpenSettings.TabIndex = 42;
            this.buttonOpenSettings.UseVisualStyleBackColor = false;
            this.buttonOpenSettings.Click += new System.EventHandler(this.buttonOpenSettings_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Image = global::StableDiffusion.Properties.Resources.delete_cross1;
            this.button4.Location = new System.Drawing.Point(3, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 40);
            this.button4.TabIndex = 43;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
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
            this.tableLayoutPanel2.Controls.Add(this.buttonClearStyle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonTabPrompt, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(135, 40);
            this.tableLayoutPanel2.TabIndex = 59;
            // 
            // buttonClearStyle
            // 
            this.buttonClearStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonClearStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearStyle.FlatAppearance.BorderSize = 0;
            this.buttonClearStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClearStyle.ForeColor = System.Drawing.Color.Silver;
            this.buttonClearStyle.Image = global::StableDiffusion.Properties.Resources.delete_cross;
            this.buttonClearStyle.Location = new System.Drawing.Point(101, 0);
            this.buttonClearStyle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearStyle.Name = "buttonClearStyle";
            this.buttonClearStyle.Size = new System.Drawing.Size(34, 40);
            this.buttonClearStyle.TabIndex = 62;
            this.buttonClearStyle.UseVisualStyleBackColor = false;
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel8.Controls.Add(this.listBoxPreset);
            this.panel8.Location = new System.Drawing.Point(6, 52);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10);
            this.panel8.Size = new System.Drawing.Size(218, 155);
            this.panel8.TabIndex = 52;
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
            this.panel7.Size = new System.Drawing.Size(963, 45);
            this.panel7.TabIndex = 50;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.flowLayoutPanel11.Controls.Add(this.button1);
            this.flowLayoutPanel11.Controls.Add(this.panel7);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(7, 4);
            this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(1013, 51);
            this.flowLayoutPanel11.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = global::StableDiffusion.Properties.Resources.text;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 45);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel10.Controls.Add(this.listBoxPresetStyles);
            this.panel10.Location = new System.Drawing.Point(6, 260);
            this.panel10.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10);
            this.panel10.Size = new System.Drawing.Size(218, 247);
            this.panel10.TabIndex = 53;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel11.Controls.Add(this.listBoxGenericStyles);
            this.panel11.Location = new System.Drawing.Point(230, 50);
            this.panel11.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10);
            this.panel11.Size = new System.Drawing.Size(218, 457);
            this.panel11.TabIndex = 54;
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
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 796);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(2429, 40);
            this.panel14.TabIndex = 56;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.button12);
            this.flowLayoutPanel14.Controls.Add(this.buttonDonate);
            this.flowLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel14.Location = new System.Drawing.Point(2103, 0);
            this.flowLayoutPanel14.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel14.Size = new System.Drawing.Size(326, 40);
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
            this.button12.Location = new System.Drawing.Point(191, 3);
            this.button12.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(135, 40);
            this.button12.TabIndex = 60;
            this.button12.Text = "Version : 0.5";
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
            this.buttonDonate.Location = new System.Drawing.Point(53, 3);
            this.buttonDonate.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonDonate.Size = new System.Drawing.Size(135, 40);
            this.buttonDonate.TabIndex = 61;
            this.buttonDonate.Text = "Donate";
            this.buttonDonate.UseVisualStyleBackColor = false;
            this.buttonDonate.Click += new System.EventHandler(this.buttonDonate_Click);
            // 
            // panelTabPrompt
            // 
            this.panelTabPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelTabPrompt.Controls.Add(this.buttonAddSelectedStylesToPreset);
            this.panelTabPrompt.Controls.Add(this.buttonAddSelectedStylesToGeneric);
            this.panelTabPrompt.Controls.Add(this.buttonAddSelectedPreset);
            this.panelTabPrompt.Controls.Add(this.buttonAddSelectedToStyles);
            this.panelTabPrompt.Controls.Add(this.buttonAddGenericToPreset);
            this.panelTabPrompt.Controls.Add(this.tableLayoutPanel4);
            this.panelTabPrompt.Controls.Add(this.buttonAddAllSelectedPreset);
            this.panelTabPrompt.Controls.Add(this.tableLayoutPanel9);
            this.panelTabPrompt.Controls.Add(this.tableLayoutPanel5);
            this.panelTabPrompt.Controls.Add(this.tableLayoutPanel11);
            this.panelTabPrompt.Controls.Add(this.panel8);
            this.panelTabPrompt.Controls.Add(this.tableLayoutPanel1);
            this.panelTabPrompt.Controls.Add(this.panel10);
            this.panelTabPrompt.Controls.Add(this.panel2);
            this.panelTabPrompt.Controls.Add(this.panel11);
            this.panelTabPrompt.Location = new System.Drawing.Point(340, 60);
            this.panelTabPrompt.Margin = new System.Windows.Forms.Padding(0);
            this.panelTabPrompt.Name = "panelTabPrompt";
            this.panelTabPrompt.Padding = new System.Windows.Forms.Padding(3);
            this.panelTabPrompt.Size = new System.Drawing.Size(680, 600);
            this.panelTabPrompt.TabIndex = 57;
            // 
            // buttonAddSelectedStylesToPreset
            // 
            this.buttonAddSelectedStylesToPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonAddSelectedStylesToPreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSelectedStylesToPreset.FlatAppearance.BorderSize = 0;
            this.buttonAddSelectedStylesToPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSelectedStylesToPreset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSelectedStylesToPreset.ForeColor = System.Drawing.Color.Silver;
            this.buttonAddSelectedStylesToPreset.Image = global::StableDiffusion.Properties.Resources.fast_backward;
            this.buttonAddSelectedStylesToPreset.Location = new System.Drawing.Point(567, 555);
            this.buttonAddSelectedStylesToPreset.Name = "buttonAddSelectedStylesToPreset";
            this.buttonAddSelectedStylesToPreset.Size = new System.Drawing.Size(108, 40);
            this.buttonAddSelectedStylesToPreset.TabIndex = 70;
            this.buttonAddSelectedStylesToPreset.UseVisualStyleBackColor = false;
            this.buttonAddSelectedStylesToPreset.Click += new System.EventHandler(this.buttonAddSelectedStylesToPreset_Click);
            // 
            // buttonAddSelectedStylesToGeneric
            // 
            this.buttonAddSelectedStylesToGeneric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonAddSelectedStylesToGeneric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSelectedStylesToGeneric.FlatAppearance.BorderSize = 0;
            this.buttonAddSelectedStylesToGeneric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSelectedStylesToGeneric.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSelectedStylesToGeneric.ForeColor = System.Drawing.Color.Silver;
            this.buttonAddSelectedStylesToGeneric.Image = global::StableDiffusion.Properties.Resources.previous;
            this.buttonAddSelectedStylesToGeneric.Location = new System.Drawing.Point(454, 555);
            this.buttonAddSelectedStylesToGeneric.Name = "buttonAddSelectedStylesToGeneric";
            this.buttonAddSelectedStylesToGeneric.Size = new System.Drawing.Size(107, 40);
            this.buttonAddSelectedStylesToGeneric.TabIndex = 69;
            this.buttonAddSelectedStylesToGeneric.UseVisualStyleBackColor = false;
            this.buttonAddSelectedStylesToGeneric.Click += new System.EventHandler(this.buttonAddSelectedStylesToGeneric_Click);
            // 
            // buttonAddSelectedPreset
            // 
            this.buttonAddSelectedPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonAddSelectedPreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSelectedPreset.FlatAppearance.BorderSize = 0;
            this.buttonAddSelectedPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSelectedPreset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSelectedPreset.ForeColor = System.Drawing.Color.Silver;
            this.buttonAddSelectedPreset.Image = global::StableDiffusion.Properties.Resources.next;
            this.buttonAddSelectedPreset.Location = new System.Drawing.Point(118, 554);
            this.buttonAddSelectedPreset.Name = "buttonAddSelectedPreset";
            this.buttonAddSelectedPreset.Size = new System.Drawing.Size(106, 40);
            this.buttonAddSelectedPreset.TabIndex = 68;
            this.buttonAddSelectedPreset.UseVisualStyleBackColor = false;
            this.buttonAddSelectedPreset.Click += new System.EventHandler(this.buttonAddSelectedPreset_Click);
            // 
            // buttonAddSelectedToStyles
            // 
            this.buttonAddSelectedToStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonAddSelectedToStyles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSelectedToStyles.FlatAppearance.BorderSize = 0;
            this.buttonAddSelectedToStyles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSelectedToStyles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSelectedToStyles.ForeColor = System.Drawing.Color.Silver;
            this.buttonAddSelectedToStyles.Image = global::StableDiffusion.Properties.Resources.next;
            this.buttonAddSelectedToStyles.Location = new System.Drawing.Point(342, 554);
            this.buttonAddSelectedToStyles.Name = "buttonAddSelectedToStyles";
            this.buttonAddSelectedToStyles.Size = new System.Drawing.Size(106, 40);
            this.buttonAddSelectedToStyles.TabIndex = 67;
            this.buttonAddSelectedToStyles.UseVisualStyleBackColor = false;
            this.buttonAddSelectedToStyles.Click += new System.EventHandler(this.buttonAddSelectedToStyles_Click);
            // 
            // buttonAddGenericToPreset
            // 
            this.buttonAddGenericToPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonAddGenericToPreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddGenericToPreset.FlatAppearance.BorderSize = 0;
            this.buttonAddGenericToPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGenericToPreset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddGenericToPreset.ForeColor = System.Drawing.Color.Silver;
            this.buttonAddGenericToPreset.Image = global::StableDiffusion.Properties.Resources.previous;
            this.buttonAddGenericToPreset.Location = new System.Drawing.Point(230, 554);
            this.buttonAddGenericToPreset.Name = "buttonAddGenericToPreset";
            this.buttonAddGenericToPreset.Size = new System.Drawing.Size(106, 40);
            this.buttonAddGenericToPreset.TabIndex = 66;
            this.buttonAddGenericToPreset.UseVisualStyleBackColor = false;
            this.buttonAddGenericToPreset.Click += new System.EventHandler(this.buttonAddSelectedToPreset_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.51376F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.48624F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.panel19, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel13, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(230, 505);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(218, 48);
            this.tableLayoutPanel4.TabIndex = 65;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel19.Controls.Add(this.textBoxGenericStyle);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 3);
            this.panel19.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel19.Name = "panel19";
            this.panel19.Padding = new System.Windows.Forms.Padding(10, 7, 5, 5);
            this.panel19.Size = new System.Drawing.Size(145, 42);
            this.panel19.TabIndex = 62;
            // 
            // textBoxGenericStyle
            // 
            this.textBoxGenericStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxGenericStyle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGenericStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGenericStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGenericStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxGenericStyle.Location = new System.Drawing.Point(10, 7);
            this.textBoxGenericStyle.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxGenericStyle.Name = "textBoxGenericStyle";
            this.textBoxGenericStyle.Size = new System.Drawing.Size(130, 22);
            this.textBoxGenericStyle.TabIndex = 1;
            this.textBoxGenericStyle.Text = "new style";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Controls.Add(this.buttonRemoveGenericStyle, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.buttonAddGenericStyle, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(148, 3);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(70, 42);
            this.tableLayoutPanel13.TabIndex = 65;
            // 
            // buttonRemoveGenericStyle
            // 
            this.buttonRemoveGenericStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonRemoveGenericStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveGenericStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveGenericStyle.FlatAppearance.BorderSize = 0;
            this.buttonRemoveGenericStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveGenericStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveGenericStyle.ForeColor = System.Drawing.Color.Silver;
            this.buttonRemoveGenericStyle.Image = global::StableDiffusion.Properties.Resources.removeC;
            this.buttonRemoveGenericStyle.Location = new System.Drawing.Point(38, 0);
            this.buttonRemoveGenericStyle.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonRemoveGenericStyle.Name = "buttonRemoveGenericStyle";
            this.buttonRemoveGenericStyle.Size = new System.Drawing.Size(32, 42);
            this.buttonRemoveGenericStyle.TabIndex = 45;
            this.buttonRemoveGenericStyle.UseVisualStyleBackColor = false;
            // 
            // buttonAddGenericStyle
            // 
            this.buttonAddGenericStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonAddGenericStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddGenericStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddGenericStyle.FlatAppearance.BorderSize = 0;
            this.buttonAddGenericStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGenericStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddGenericStyle.ForeColor = System.Drawing.Color.Silver;
            this.buttonAddGenericStyle.Image = global::StableDiffusion.Properties.Resources.addC;
            this.buttonAddGenericStyle.Location = new System.Drawing.Point(0, 0);
            this.buttonAddGenericStyle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonAddGenericStyle.Name = "buttonAddGenericStyle";
            this.buttonAddGenericStyle.Size = new System.Drawing.Size(32, 42);
            this.buttonAddGenericStyle.TabIndex = 40;
            this.buttonAddGenericStyle.UseVisualStyleBackColor = false;
            this.buttonAddGenericStyle.Click += new System.EventHandler(this.buttonAddStyle_Click);
            // 
            // buttonAddAllSelectedPreset
            // 
            this.buttonAddAllSelectedPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.buttonAddAllSelectedPreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddAllSelectedPreset.FlatAppearance.BorderSize = 0;
            this.buttonAddAllSelectedPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAllSelectedPreset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddAllSelectedPreset.ForeColor = System.Drawing.Color.Silver;
            this.buttonAddAllSelectedPreset.Image = global::StableDiffusion.Properties.Resources.fast_forward;
            this.buttonAddAllSelectedPreset.Location = new System.Drawing.Point(6, 554);
            this.buttonAddAllSelectedPreset.Name = "buttonAddAllSelectedPreset";
            this.buttonAddAllSelectedPreset.Size = new System.Drawing.Size(106, 40);
            this.buttonAddAllSelectedPreset.TabIndex = 45;
            this.buttonAddAllSelectedPreset.UseVisualStyleBackColor = false;
            this.buttonAddAllSelectedPreset.Click += new System.EventHandler(this.buttonAddAllSelectedPreset_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.51376F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.48624F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.panel18, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel12, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(6, 505);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(218, 48);
            this.tableLayoutPanel9.TabIndex = 64;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel18.Controls.Add(this.textBoxPresetStyle);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 3);
            this.panel18.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(10, 7, 5, 5);
            this.panel18.Size = new System.Drawing.Size(145, 42);
            this.panel18.TabIndex = 62;
            // 
            // textBoxPresetStyle
            // 
            this.textBoxPresetStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxPresetStyle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPresetStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPresetStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPresetStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPresetStyle.Location = new System.Drawing.Point(10, 7);
            this.textBoxPresetStyle.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPresetStyle.Name = "textBoxPresetStyle";
            this.textBoxPresetStyle.Size = new System.Drawing.Size(130, 22);
            this.textBoxPresetStyle.TabIndex = 1;
            this.textBoxPresetStyle.Text = "new style";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Controls.Add(this.buttonRemovePresetStyle, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.buttonAddPresetStyle, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(148, 3);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(70, 42);
            this.tableLayoutPanel12.TabIndex = 65;
            // 
            // buttonRemovePresetStyle
            // 
            this.buttonRemovePresetStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonRemovePresetStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemovePresetStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemovePresetStyle.FlatAppearance.BorderSize = 0;
            this.buttonRemovePresetStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemovePresetStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemovePresetStyle.ForeColor = System.Drawing.Color.Silver;
            this.buttonRemovePresetStyle.Image = global::StableDiffusion.Properties.Resources.removeC;
            this.buttonRemovePresetStyle.Location = new System.Drawing.Point(38, 0);
            this.buttonRemovePresetStyle.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonRemovePresetStyle.Name = "buttonRemovePresetStyle";
            this.buttonRemovePresetStyle.Size = new System.Drawing.Size(32, 42);
            this.buttonRemovePresetStyle.TabIndex = 45;
            this.buttonRemovePresetStyle.UseVisualStyleBackColor = false;
            // 
            // buttonAddPresetStyle
            // 
            this.buttonAddPresetStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonAddPresetStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddPresetStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddPresetStyle.FlatAppearance.BorderSize = 0;
            this.buttonAddPresetStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPresetStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPresetStyle.ForeColor = System.Drawing.Color.Silver;
            this.buttonAddPresetStyle.Image = global::StableDiffusion.Properties.Resources.addC;
            this.buttonAddPresetStyle.Location = new System.Drawing.Point(0, 0);
            this.buttonAddPresetStyle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonAddPresetStyle.Name = "buttonAddPresetStyle";
            this.buttonAddPresetStyle.Size = new System.Drawing.Size(32, 42);
            this.buttonAddPresetStyle.TabIndex = 40;
            this.buttonAddPresetStyle.UseVisualStyleBackColor = false;
            this.buttonAddPresetStyle.Click += new System.EventHandler(this.buttonAddStyle_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.51376F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.48624F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 207);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(218, 48);
            this.tableLayoutPanel5.TabIndex = 63;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel17.Controls.Add(this.textBoxPreset);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 3);
            this.panel17.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(10, 7, 5, 5);
            this.panel17.Size = new System.Drawing.Size(145, 42);
            this.panel17.TabIndex = 62;
            // 
            // textBoxPreset
            // 
            this.textBoxPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.textBoxPreset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPreset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPreset.Location = new System.Drawing.Point(10, 7);
            this.textBoxPreset.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPreset.Name = "textBoxPreset";
            this.textBoxPreset.Size = new System.Drawing.Size(130, 22);
            this.textBoxPreset.TabIndex = 1;
            this.textBoxPreset.Text = "new preset";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.buttonRemovePreset, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.buttonAddPreset, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(148, 3);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(70, 42);
            this.tableLayoutPanel8.TabIndex = 65;
            // 
            // buttonRemovePreset
            // 
            this.buttonRemovePreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonRemovePreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemovePreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemovePreset.FlatAppearance.BorderSize = 0;
            this.buttonRemovePreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemovePreset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemovePreset.ForeColor = System.Drawing.Color.Silver;
            this.buttonRemovePreset.Image = global::StableDiffusion.Properties.Resources.removeC;
            this.buttonRemovePreset.Location = new System.Drawing.Point(38, 0);
            this.buttonRemovePreset.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonRemovePreset.Name = "buttonRemovePreset";
            this.buttonRemovePreset.Size = new System.Drawing.Size(32, 42);
            this.buttonRemovePreset.TabIndex = 45;
            this.buttonRemovePreset.UseVisualStyleBackColor = false;
            // 
            // buttonAddPreset
            // 
            this.buttonAddPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonAddPreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddPreset.FlatAppearance.BorderSize = 0;
            this.buttonAddPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPreset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPreset.ForeColor = System.Drawing.Color.Silver;
            this.buttonAddPreset.Image = global::StableDiffusion.Properties.Resources.addC;
            this.buttonAddPreset.Location = new System.Drawing.Point(0, 0);
            this.buttonAddPreset.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonAddPreset.Name = "buttonAddPreset";
            this.buttonAddPreset.Size = new System.Drawing.Size(32, 42);
            this.buttonAddPreset.TabIndex = 40;
            this.buttonAddPreset.UseVisualStyleBackColor = false;
            this.buttonAddPreset.Click += new System.EventHandler(this.buttonAddStyle_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Controls.Add(this.buttonSaveSelectedStyles, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.buttonSaveGenericStyles, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.buttonSavePresets, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(674, 46);
            this.tableLayoutPanel11.TabIndex = 62;
            // 
            // buttonSaveSelectedStyles
            // 
            this.buttonSaveSelectedStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.buttonSaveSelectedStyles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveSelectedStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveSelectedStyles.FlatAppearance.BorderSize = 0;
            this.buttonSaveSelectedStyles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveSelectedStyles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveSelectedStyles.ForeColor = System.Drawing.Color.Silver;
            this.buttonSaveSelectedStyles.Image = global::StableDiffusion.Properties.Resources.save1;
            this.buttonSaveSelectedStyles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveSelectedStyles.Location = new System.Drawing.Point(451, 3);
            this.buttonSaveSelectedStyles.Name = "buttonSaveSelectedStyles";
            this.buttonSaveSelectedStyles.Size = new System.Drawing.Size(220, 40);
            this.buttonSaveSelectedStyles.TabIndex = 62;
            this.buttonSaveSelectedStyles.Text = "Selected Styles";
            this.buttonSaveSelectedStyles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveSelectedStyles.UseVisualStyleBackColor = false;
            this.buttonSaveSelectedStyles.Click += new System.EventHandler(this.buttonSaveSelectedStyles_Click);
            // 
            // buttonSaveGenericStyles
            // 
            this.buttonSaveGenericStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.buttonSaveGenericStyles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveGenericStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveGenericStyles.FlatAppearance.BorderSize = 0;
            this.buttonSaveGenericStyles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveGenericStyles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveGenericStyles.ForeColor = System.Drawing.Color.Silver;
            this.buttonSaveGenericStyles.Image = global::StableDiffusion.Properties.Resources.save1;
            this.buttonSaveGenericStyles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveGenericStyles.Location = new System.Drawing.Point(227, 3);
            this.buttonSaveGenericStyles.Name = "buttonSaveGenericStyles";
            this.buttonSaveGenericStyles.Size = new System.Drawing.Size(218, 40);
            this.buttonSaveGenericStyles.TabIndex = 61;
            this.buttonSaveGenericStyles.Text = "Generic Styles";
            this.buttonSaveGenericStyles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveGenericStyles.UseVisualStyleBackColor = false;
            this.buttonSaveGenericStyles.Click += new System.EventHandler(this.buttonSaveGenericStyles_Click);
            // 
            // buttonSavePresets
            // 
            this.buttonSavePresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(30)))));
            this.buttonSavePresets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSavePresets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSavePresets.FlatAppearance.BorderSize = 0;
            this.buttonSavePresets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavePresets.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSavePresets.ForeColor = System.Drawing.Color.Silver;
            this.buttonSavePresets.Image = global::StableDiffusion.Properties.Resources.save1;
            this.buttonSavePresets.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSavePresets.Location = new System.Drawing.Point(3, 3);
            this.buttonSavePresets.Name = "buttonSavePresets";
            this.buttonSavePresets.Size = new System.Drawing.Size(218, 40);
            this.buttonSavePresets.TabIndex = 60;
            this.buttonSavePresets.Text = "Presets";
            this.buttonSavePresets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSavePresets.UseVisualStyleBackColor = false;
            this.buttonSavePresets.Click += new System.EventHandler(this.buttonSavePresets_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonRemoveStyles, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemoveSelectedStyles, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button20, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonShuffleSelectedStyles, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(454, 508);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 45);
            this.tableLayoutPanel1.TabIndex = 59;
            // 
            // buttonRemoveStyles
            // 
            this.buttonRemoveStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.buttonRemoveStyles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveStyles.FlatAppearance.BorderSize = 0;
            this.buttonRemoveStyles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveStyles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveStyles.ForeColor = System.Drawing.Color.Silver;
            this.buttonRemoveStyles.Image = global::StableDiffusion.Properties.Resources.cancel;
            this.buttonRemoveStyles.Location = new System.Drawing.Point(168, 0);
            this.buttonRemoveStyles.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.buttonRemoveStyles.Name = "buttonRemoveStyles";
            this.buttonRemoveStyles.Size = new System.Drawing.Size(53, 42);
            this.buttonRemoveStyles.TabIndex = 45;
            this.buttonRemoveStyles.UseVisualStyleBackColor = false;
            this.buttonRemoveStyles.Click += new System.EventHandler(this.buttonRemoveStyles_Click);
            // 
            // buttonRemoveSelectedStyles
            // 
            this.buttonRemoveSelectedStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonRemoveSelectedStyles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveSelectedStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveSelectedStyles.FlatAppearance.BorderSize = 0;
            this.buttonRemoveSelectedStyles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSelectedStyles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveSelectedStyles.ForeColor = System.Drawing.Color.Silver;
            this.buttonRemoveSelectedStyles.Image = global::StableDiffusion.Properties.Resources.removeC;
            this.buttonRemoveSelectedStyles.Location = new System.Drawing.Point(113, 0);
            this.buttonRemoveSelectedStyles.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.buttonRemoveSelectedStyles.Name = "buttonRemoveSelectedStyles";
            this.buttonRemoveSelectedStyles.Size = new System.Drawing.Size(49, 42);
            this.buttonRemoveSelectedStyles.TabIndex = 44;
            this.buttonRemoveSelectedStyles.UseVisualStyleBackColor = false;
            this.buttonRemoveSelectedStyles.Click += new System.EventHandler(this.buttonRemoveStyleSelectedStyles_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button20.ForeColor = System.Drawing.Color.Silver;
            this.button20.Image = global::StableDiffusion.Properties.Resources.delete_cross1;
            this.button20.Location = new System.Drawing.Point(58, 0);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(49, 42);
            this.button20.TabIndex = 41;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Visible = false;
            // 
            // buttonShuffleSelectedStyles
            // 
            this.buttonShuffleSelectedStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonShuffleSelectedStyles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShuffleSelectedStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShuffleSelectedStyles.FlatAppearance.BorderSize = 0;
            this.buttonShuffleSelectedStyles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShuffleSelectedStyles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShuffleSelectedStyles.ForeColor = System.Drawing.Color.Silver;
            this.buttonShuffleSelectedStyles.Image = global::StableDiffusion.Properties.Resources.shuffle;
            this.buttonShuffleSelectedStyles.Location = new System.Drawing.Point(0, 0);
            this.buttonShuffleSelectedStyles.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.buttonShuffleSelectedStyles.Name = "buttonShuffleSelectedStyles";
            this.buttonShuffleSelectedStyles.Size = new System.Drawing.Size(52, 42);
            this.buttonShuffleSelectedStyles.TabIndex = 40;
            this.buttonShuffleSelectedStyles.UseVisualStyleBackColor = false;
            this.buttonShuffleSelectedStyles.Click += new System.EventHandler(this.buttonShuffleSelectedStyles_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.listBoxSelectedStyles);
            this.panel2.Location = new System.Drawing.Point(454, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(221, 457);
            this.panel2.TabIndex = 53;
            // 
            // listBoxSelectedStyles
            // 
            this.listBoxSelectedStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.listBoxSelectedStyles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSelectedStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSelectedStyles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxSelectedStyles.ForeColor = System.Drawing.Color.Silver;
            this.listBoxSelectedStyles.FormattingEnabled = true;
            this.listBoxSelectedStyles.ItemHeight = 17;
            this.listBoxSelectedStyles.Location = new System.Drawing.Point(10, 10);
            this.listBoxSelectedStyles.Name = "listBoxSelectedStyles";
            this.listBoxSelectedStyles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSelectedStyles.Size = new System.Drawing.Size(201, 437);
            this.listBoxSelectedStyles.TabIndex = 2;
            // 
            // panelTabSequence
            // 
            this.panelTabSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelTabSequence.Controls.Add(this.buttonWorkInProgress1);
            this.panelTabSequence.Location = new System.Drawing.Point(1730, 60);
            this.panelTabSequence.Margin = new System.Windows.Forms.Padding(0);
            this.panelTabSequence.Name = "panelTabSequence";
            this.panelTabSequence.Padding = new System.Windows.Forms.Padding(3);
            this.panelTabSequence.Size = new System.Drawing.Size(680, 600);
            this.panelTabSequence.TabIndex = 58;
            // 
            // buttonWorkInProgress1
            // 
            this.buttonWorkInProgress1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.buttonWorkInProgress1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWorkInProgress1.FlatAppearance.BorderSize = 0;
            this.buttonWorkInProgress1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkInProgress1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWorkInProgress1.ForeColor = System.Drawing.Color.Silver;
            this.buttonWorkInProgress1.Image = global::StableDiffusion.Properties.Resources.work_in_progress;
            this.buttonWorkInProgress1.Location = new System.Drawing.Point(180, 167);
            this.buttonWorkInProgress1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.buttonWorkInProgress1.Name = "buttonWorkInProgress1";
            this.buttonWorkInProgress1.Size = new System.Drawing.Size(314, 226);
            this.buttonWorkInProgress1.TabIndex = 48;
            this.buttonWorkInProgress1.Text = "Comming soon...";
            this.buttonWorkInProgress1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWorkInProgress1.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panel16.Controls.Add(this.buttonStart);
            this.panel16.Controls.Add(this.flowLayoutPanel2);
            this.panel16.Controls.Add(this.tableLayoutPanel3);
            this.panel16.Location = new System.Drawing.Point(7, 61);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(328, 186);
            this.panel16.TabIndex = 60;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panelSelectedPrompt);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel2.Controls.Add(this.panelSelectedImage);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel2.Controls.Add(this.panelSelectedSequence);
            this.flowLayoutPanel2.Controls.Add(this.buttonTabSequence);
            this.flowLayoutPanel2.Controls.Add(this.panelSelectedMorph);
            this.flowLayoutPanel2.Controls.Add(this.buttonTabMorph);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(167, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(161, 186);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonOpenSettings, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.buttonClearOutputFolder, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonOutFolder, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(45, 186);
            this.tableLayoutPanel3.TabIndex = 61;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(2429, 836);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panelTabSequence);
            this.Controls.Add(this.panelTabPrompt);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.flowLayoutPanel11);
            this.Controls.Add(this.flowLayoutPanel8);
            this.Controls.Add(this.panelTabImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flowLayoutPanelPaintTools.ResumeLayout(false);
            this.panelTabImages.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN_iter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN_samples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIteration)).EndInit();
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
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.flowLayoutPanel14.ResumeLayout(false);
            this.panelTabPrompt.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTabSequence.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox textBoxPrompt;
        private ListBox listBoxPreset;
        private ListBox listBoxPresetStyles;
        private ListBox listBoxGenericStyles;
        private Button buttonStart;
        private FlowLayoutPanel flowLayoutPanelPaintTools;
        private Panel panelC2;
        private Panel panelC3;
        private Panel panelC4;
        private Panel panelC6;
        private Panel panelC5;
        private Panel panelC7;
        private Panel panelC8;
        private Panel panelC9;
        private Panel panelTabImages;
        private Panel panelGradiant;
        private Panel panelCpick;
        private PictureBox pictureBox1;
        private Button buttonClearImage;
        private Button buttonOpenImage;
        private TrackBar trackBarStrength;
        private Button buttonN_iter;
        private Button buttonStrength;
        private TrackBar trackBarN_iter;
        private Button buttonN_samples;
        private TrackBar trackBarN_samples;
        private Button buttonSeed;
        private Button buttonIteration;
        private TrackBar trackBarIteration;
        private Button buttonOutFolder;
        private Button buttonClearOutputFolder;
        private ListBox listBoxInitImages;
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
        private Button button1;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Button buttonInpaint;
        private ListView listViewInitImages;
        private Panel panel12;
        private ColumnHeader ImagesList;
        private ImageList imageList1;
        private Button buttonTabPrompt;
        private Button buttonTabImage;
        private Panel panelC10;
        private Button buttonPencil;
        private Panel panelC11;
        private Panel panelC12;
        private Panel panelC13;
        private Panel panel14;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonChannels;
        private TrackBar trackBarChannels;
        private Panel panel15;
        private Label labelChannels;
        private Panel panelTabPrompt;
        private Button buttonTabSequence;
        private Button buttonOpenSettings;
        private Button button4;
        private Panel panel2;
        private ListBox listBoxSelectedStyles;
        private Button buttonShuffleSelectedStyles;
        private Button button20;
        private Panel panelTabSequence;
        private Button buttonPencilRedo;
        private Button button12;
        private FlowLayoutPanel flowLayoutPanel14;
        private Button buttonDonate;
        private Panel panelSelectedPrompt;
        private Panel panelSelectedImage;
        private Panel panelSelectedSequence;
        private Button buttonClearStyle;
        private FlowLayoutPanel flowLayoutPanelGuidance;
        private Button buttonGuidance;
        private TrackBar trackBarGuidance;
        private Panel panel13;
        private Label labelGuidance;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonRemoveStyles;
        private Button buttonRemoveSelectedStyles;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel16;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panelSelectedMorph;
        private Button buttonTabMorph;
        private Button buttonPastImage;
        private Button buttonSavePresets;
        private Button buttonAddAllSelectedPreset;
        private Panel panel17;
        private TextBox textBoxPreset;
        private TableLayoutPanel tableLayoutPanel8;
        private Button buttonRemovePreset;
        private Button buttonAddPreset;
        private TableLayoutPanel tableLayoutPanel11;
        private Button buttonSaveSelectedStyles;
        private Button buttonSaveGenericStyles;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panel18;
        private TextBox textBoxPresetStyle;
        private TableLayoutPanel tableLayoutPanel12;
        private Button buttonRemovePresetStyle;
        private Button buttonAddPresetStyle;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel19;
        private TextBox textBoxGenericStyle;
        private TableLayoutPanel tableLayoutPanel13;
        private Button buttonRemoveGenericStyle;
        private Button buttonAddGenericStyle;
        private Button buttonAddGenericToPreset;
        private Button buttonAddSelectedToStyles;
        private Button buttonAddSelectedPreset;
        private Button buttonAddSelectedStylesToPreset;
        private Button buttonAddSelectedStylesToGeneric;
        private Button buttonWorkInProgress1;
    }
}