namespace StableDiffusion
{
    partial class TabMorphControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel20 = new System.Windows.Forms.Panel();
            this.buttonPastImage = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.listViewInitImages = new System.Windows.Forms.ListView();
            this.ImagesList = new System.Windows.Forms.ColumnHeader();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelRepeat = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonZoom = new System.Windows.Forms.Button();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelZoom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAngle = new System.Windows.Forms.Button();
            this.trackBarAngle = new System.Windows.Forms.TrackBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelAngle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelSeed = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonTx = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTx = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonTy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTy = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel20.SuspendLayout();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanelRepeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).BeginInit();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanelSeed.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panel20.Controls.Add(this.buttonPastImage);
            this.panel20.Controls.Add(this.panel12);
            this.panel20.Controls.Add(this.buttonOpenImage);
            this.panel20.Controls.Add(this.flowLayoutPanel2);
            this.panel20.Controls.Add(this.flowLayoutPanel4);
            this.panel20.Controls.Add(this.pictureBox1);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Margin = new System.Windows.Forms.Padding(6);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(680, 680);
            this.panel20.TabIndex = 62;
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
            this.buttonPastImage.Location = new System.Drawing.Point(522, 5);
            this.buttonPastImage.Name = "buttonPastImage";
            this.buttonPastImage.Size = new System.Drawing.Size(43, 40);
            this.buttonPastImage.TabIndex = 76;
            this.buttonPastImage.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel12.Controls.Add(this.listViewInitImages);
            this.panel12.Location = new System.Drawing.Point(522, 51);
            this.panel12.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10);
            this.panel12.Size = new System.Drawing.Size(155, 466);
            this.panel12.TabIndex = 75;
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
            this.listViewInitImages.Size = new System.Drawing.Size(135, 446);
            this.listViewInitImages.TabIndex = 55;
            this.listViewInitImages.UseCompatibleStateImageBehavior = false;
            // 
            // ImagesList
            // 
            this.ImagesList.Text = "Images List";
            this.ImagesList.Width = 100;
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
            this.buttonOpenImage.Location = new System.Drawing.Point(571, 5);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(106, 40);
            this.buttonOpenImage.TabIndex = 73;
            this.buttonOpenImage.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanelRepeat);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 518);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(354, 104);
            this.flowLayoutPanel2.TabIndex = 72;
            // 
            // flowLayoutPanelRepeat
            // 
            this.flowLayoutPanelRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanelRepeat.Controls.Add(this.buttonZoom);
            this.flowLayoutPanelRepeat.Controls.Add(this.trackBarZoom);
            this.flowLayoutPanelRepeat.Controls.Add(this.panel5);
            this.flowLayoutPanelRepeat.Controls.Add(this.button1);
            this.flowLayoutPanelRepeat.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelRepeat.Name = "flowLayoutPanelRepeat";
            this.flowLayoutPanelRepeat.Size = new System.Drawing.Size(351, 46);
            this.flowLayoutPanelRepeat.TabIndex = 70;
            // 
            // buttonZoom
            // 
            this.buttonZoom.AllowDrop = true;
            this.buttonZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonZoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZoom.FlatAppearance.BorderSize = 0;
            this.buttonZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonZoom.ForeColor = System.Drawing.Color.Silver;
            this.buttonZoom.Image = global::StableDiffusion.Properties.Resources.zoom;
            this.buttonZoom.Location = new System.Drawing.Point(3, 3);
            this.buttonZoom.Name = "buttonZoom";
            this.buttonZoom.Size = new System.Drawing.Size(43, 40);
            this.buttonZoom.TabIndex = 35;
            this.buttonZoom.UseVisualStyleBackColor = false;
            this.buttonZoom.Click += new System.EventHandler(this.buttonZoom_Click);
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.trackBarZoom.LargeChange = 1;
            this.trackBarZoom.Location = new System.Drawing.Point(52, 3);
            this.trackBarZoom.Maximum = 20;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(159, 45);
            this.trackBarZoom.TabIndex = 33;
            this.trackBarZoom.Value = 10;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.labelZoom);
            this.panel5.Location = new System.Drawing.Point(217, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(47, 40);
            this.panel5.TabIndex = 50;
            // 
            // labelZoom
            // 
            this.labelZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.labelZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelZoom.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelZoom.Location = new System.Drawing.Point(5, 5);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(37, 30);
            this.labelZoom.TabIndex = 0;
            this.labelZoom.Text = "1";
            this.labelZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button1.Image = global::StableDiffusion.Properties.Resources.sinusoide;
            this.button1.Location = new System.Drawing.Point(267, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 40);
            this.button1.TabIndex = 51;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanel5.Controls.Add(this.buttonAngle);
            this.flowLayoutPanel5.Controls.Add(this.trackBarAngle);
            this.flowLayoutPanel5.Controls.Add(this.panel6);
            this.flowLayoutPanel5.Controls.Add(this.button2);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 55);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(351, 46);
            this.flowLayoutPanel5.TabIndex = 71;
            // 
            // buttonAngle
            // 
            this.buttonAngle.AllowDrop = true;
            this.buttonAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonAngle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAngle.FlatAppearance.BorderSize = 0;
            this.buttonAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAngle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAngle.ForeColor = System.Drawing.Color.Silver;
            this.buttonAngle.Image = global::StableDiffusion.Properties.Resources.rotation_de_lecran;
            this.buttonAngle.Location = new System.Drawing.Point(3, 3);
            this.buttonAngle.Name = "buttonAngle";
            this.buttonAngle.Size = new System.Drawing.Size(43, 40);
            this.buttonAngle.TabIndex = 35;
            this.buttonAngle.UseVisualStyleBackColor = false;
            this.buttonAngle.Click += new System.EventHandler(this.buttonAngle_Click);
            // 
            // trackBarAngle
            // 
            this.trackBarAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.trackBarAngle.LargeChange = 1;
            this.trackBarAngle.Location = new System.Drawing.Point(52, 3);
            this.trackBarAngle.Maximum = 20;
            this.trackBarAngle.Name = "trackBarAngle";
            this.trackBarAngle.Size = new System.Drawing.Size(159, 45);
            this.trackBarAngle.TabIndex = 33;
            this.trackBarAngle.Value = 10;
            this.trackBarAngle.Scroll += new System.EventHandler(this.trackBarAngle_Scroll);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel6.Controls.Add(this.labelAngle);
            this.panel6.Location = new System.Drawing.Point(217, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(47, 40);
            this.panel6.TabIndex = 50;
            // 
            // labelAngle
            // 
            this.labelAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.labelAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAngle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAngle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelAngle.Location = new System.Drawing.Point(5, 5);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(37, 30);
            this.labelAngle.TabIndex = 0;
            this.labelAngle.Text = "0";
            this.labelAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Image = global::StableDiffusion.Properties.Resources.sinusoide;
            this.button2.Location = new System.Drawing.Point(267, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 40);
            this.button2.TabIndex = 51;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanelSeed);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(359, 518);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(158, 104);
            this.flowLayoutPanel4.TabIndex = 69;
            // 
            // flowLayoutPanelSeed
            // 
            this.flowLayoutPanelSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanelSeed.Controls.Add(this.buttonTx);
            this.flowLayoutPanelSeed.Controls.Add(this.panel4);
            this.flowLayoutPanelSeed.Controls.Add(this.button3);
            this.flowLayoutPanelSeed.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelSeed.Name = "flowLayoutPanelSeed";
            this.flowLayoutPanelSeed.Size = new System.Drawing.Size(155, 46);
            this.flowLayoutPanelSeed.TabIndex = 65;
            // 
            // buttonTx
            // 
            this.buttonTx.AllowDrop = true;
            this.buttonTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonTx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTx.FlatAppearance.BorderSize = 0;
            this.buttonTx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTx.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTx.ForeColor = System.Drawing.Color.Silver;
            this.buttonTx.Image = global::StableDiffusion.Properties.Resources.tx;
            this.buttonTx.Location = new System.Drawing.Point(3, 3);
            this.buttonTx.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.buttonTx.Name = "buttonTx";
            this.buttonTx.Size = new System.Drawing.Size(40, 40);
            this.buttonTx.TabIndex = 37;
            this.buttonTx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTx.UseVisualStyleBackColor = false;
            this.buttonTx.Click += new System.EventHandler(this.buttonTx_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.labelTx);
            this.panel4.Location = new System.Drawing.Point(46, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(60, 40);
            this.panel4.TabIndex = 51;
            // 
            // labelTx
            // 
            this.labelTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.labelTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTx.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTx.Location = new System.Drawing.Point(5, 5);
            this.labelTx.Name = "labelTx";
            this.labelTx.Size = new System.Drawing.Size(50, 30);
            this.labelTx.TabIndex = 0;
            this.labelTx.Text = "256";
            this.labelTx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Image = global::StableDiffusion.Properties.Resources.sinusoide;
            this.button3.Location = new System.Drawing.Point(109, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 40);
            this.button3.TabIndex = 52;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.flowLayoutPanel1.Controls.Add(this.buttonTy);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(155, 46);
            this.flowLayoutPanel1.TabIndex = 66;
            // 
            // buttonTy
            // 
            this.buttonTy.AllowDrop = true;
            this.buttonTy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.buttonTy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTy.FlatAppearance.BorderSize = 0;
            this.buttonTy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTy.ForeColor = System.Drawing.Color.Silver;
            this.buttonTy.Image = global::StableDiffusion.Properties.Resources.ty;
            this.buttonTy.Location = new System.Drawing.Point(3, 3);
            this.buttonTy.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.buttonTy.Name = "buttonTy";
            this.buttonTy.Size = new System.Drawing.Size(40, 40);
            this.buttonTy.TabIndex = 37;
            this.buttonTy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTy.UseVisualStyleBackColor = false;
            this.buttonTy.Click += new System.EventHandler(this.buttonTy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.labelTy);
            this.panel1.Location = new System.Drawing.Point(46, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(60, 40);
            this.panel1.TabIndex = 51;
            // 
            // labelTy
            // 
            this.labelTy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.labelTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTy.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelTy.Location = new System.Drawing.Point(5, 5);
            this.labelTy.Name = "labelTy";
            this.labelTy.Size = new System.Drawing.Size(50, 30);
            this.labelTy.TabIndex = 0;
            this.labelTy.Text = "256";
            this.labelTy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Image = global::StableDiffusion.Properties.Resources.sinusoide;
            this.button4.Location = new System.Drawing.Point(109, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 40);
            this.button4.TabIndex = 52;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
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
            // TabMorphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel20);
            this.Name = "TabMorphControl";
            this.Size = new System.Drawing.Size(680, 680);
            this.panel20.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanelRepeat.ResumeLayout(false);
            this.flowLayoutPanelRepeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).EndInit();
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanelSeed.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel20;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanelSeed;
        private Button buttonTx;
        private Panel panel4;
        private Label labelTx;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonTy;
        private Panel panel1;
        private Label labelTy;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button buttonAngle;
        private TrackBar trackBarAngle;
        private Panel panel6;
        private Label labelAngle;
        private FlowLayoutPanel flowLayoutPanelRepeat;
        private Button buttonZoom;
        private TrackBar trackBarZoom;
        private Panel panel5;
        private Label labelZoom;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button buttonPastImage;
        private Panel panel12;
        private ListView listViewInitImages;
        private ColumnHeader ImagesList;
        private Button buttonOpenImage;
    }
}
