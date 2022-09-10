namespace StableDiffusion
{
    partial class TabBrowseControl
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
            this.components = new System.ComponentModel.Container();
            this.panelTabBrowser = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxResultSettings = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxFolderList = new System.Windows.Forms.ListBox();
            this.contextMenuStripFolderList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemFopen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCopyPreset = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCopyPrompt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCopyStyles = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCopySettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRenameF = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMoveF = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDeleteF = new System.Windows.Forms.ToolStripMenuItem();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listBoxPreset = new System.Windows.Forms.ListBox();
            this.contextMenuStripPreset = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemOpenP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRenameP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDeleteP = new System.Windows.Forms.ToolStripMenuItem();
            this.panel12 = new System.Windows.Forms.Panel();
            this.listViewInitImages = new System.Windows.Forms.ListView();
            this.ImagesList = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStripImageList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemOpenI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetInitImage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDeleteI = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTabBrowser.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStripFolderList.SuspendLayout();
            this.panel8.SuspendLayout();
            this.contextMenuStripPreset.SuspendLayout();
            this.panel12.SuspendLayout();
            this.contextMenuStripImageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTabBrowser
            // 
            this.panelTabBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelTabBrowser.Controls.Add(this.panel2);
            this.panelTabBrowser.Controls.Add(this.panel1);
            this.panelTabBrowser.Controls.Add(this.panel8);
            this.panelTabBrowser.Controls.Add(this.panel12);
            this.panelTabBrowser.Controls.Add(this.pictureBox1);
            this.panelTabBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabBrowser.Location = new System.Drawing.Point(0, 0);
            this.panelTabBrowser.Margin = new System.Windows.Forms.Padding(6);
            this.panelTabBrowser.Name = "panelTabBrowser";
            this.panelTabBrowser.Size = new System.Drawing.Size(680, 680);
            this.panelTabBrowser.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.listBoxResultSettings);
            this.panel2.Location = new System.Drawing.Point(415, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(262, 156);
            this.panel2.TabIndex = 78;
            // 
            // listBoxResultSettings
            // 
            this.listBoxResultSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.listBoxResultSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxResultSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResultSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxResultSettings.ForeColor = System.Drawing.Color.Silver;
            this.listBoxResultSettings.FormattingEnabled = true;
            this.listBoxResultSettings.HorizontalScrollbar = true;
            this.listBoxResultSettings.ItemHeight = 17;
            this.listBoxResultSettings.Location = new System.Drawing.Point(10, 10);
            this.listBoxResultSettings.Name = "listBoxResultSettings";
            this.listBoxResultSettings.Size = new System.Drawing.Size(242, 136);
            this.listBoxResultSettings.TabIndex = 2;
            this.listBoxResultSettings.SelectedIndexChanged += new System.EventHandler(this.listBoxResultSettings_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.listBoxFolderList);
            this.panel1.Location = new System.Drawing.Point(230, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(182, 156);
            this.panel1.TabIndex = 77;
            // 
            // listBoxFolderList
            // 
            this.listBoxFolderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.listBoxFolderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFolderList.ContextMenuStrip = this.contextMenuStripFolderList;
            this.listBoxFolderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFolderList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxFolderList.ForeColor = System.Drawing.Color.Silver;
            this.listBoxFolderList.FormattingEnabled = true;
            this.listBoxFolderList.ItemHeight = 20;
            this.listBoxFolderList.Location = new System.Drawing.Point(10, 10);
            this.listBoxFolderList.Name = "listBoxFolderList";
            this.listBoxFolderList.Size = new System.Drawing.Size(162, 136);
            this.listBoxFolderList.TabIndex = 2;
            this.listBoxFolderList.SelectedIndexChanged += new System.EventHandler(this.listBoxFolderList_SelectedIndexChanged);
            this.listBoxFolderList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxFolderList_KeyDown);
            // 
            // contextMenuStripFolderList
            // 
            this.contextMenuStripFolderList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFopen,
            this.ToolStripMenuItemCopyPreset,
            this.ToolStripMenuItemRenameF,
            this.ToolStripMenuItemMoveF,
            this.ToolStripMenuItemDeleteF});
            this.contextMenuStripFolderList.Name = "contextMenuStrip1";
            this.contextMenuStripFolderList.Size = new System.Drawing.Size(181, 136);
            // 
            // ToolStripMenuItemFopen
            // 
            this.ToolStripMenuItemFopen.Name = "ToolStripMenuItemFopen";
            this.ToolStripMenuItemFopen.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemFopen.Text = "Open";
            this.ToolStripMenuItemFopen.Click += new System.EventHandler(this.ToolStripMenuItemOpenF_Click);
            // 
            // ToolStripMenuItemCopyPreset
            // 
            this.ToolStripMenuItemCopyPreset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCopyAll,
            this.ToolStripMenuItemCopyPrompt,
            this.ToolStripMenuItemCopyStyles,
            this.ToolStripMenuItemCopySettings});
            this.ToolStripMenuItemCopyPreset.Name = "ToolStripMenuItemCopyPreset";
            this.ToolStripMenuItemCopyPreset.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemCopyPreset.Text = "Copy Preset";
            // 
            // ToolStripMenuItemCopyAll
            // 
            this.ToolStripMenuItemCopyAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToolStripMenuItemCopyAll.Name = "ToolStripMenuItemCopyAll";
            this.ToolStripMenuItemCopyAll.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemCopyAll.Text = "All";
            this.ToolStripMenuItemCopyAll.Click += new System.EventHandler(this.ToolStripMenuItemCopyAll_Click);
            // 
            // ToolStripMenuItemCopyPrompt
            // 
            this.ToolStripMenuItemCopyPrompt.Name = "ToolStripMenuItemCopyPrompt";
            this.ToolStripMenuItemCopyPrompt.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemCopyPrompt.Text = "Prompt";
            this.ToolStripMenuItemCopyPrompt.Click += new System.EventHandler(this.ToolStripMenuItemCopyPrompt_Click);
            // 
            // ToolStripMenuItemCopyStyles
            // 
            this.ToolStripMenuItemCopyStyles.Name = "ToolStripMenuItemCopyStyles";
            this.ToolStripMenuItemCopyStyles.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemCopyStyles.Text = "Styles";
            this.ToolStripMenuItemCopyStyles.Click += new System.EventHandler(this.ToolStripMenuItemCopyStyles_Click);
            // 
            // ToolStripMenuItemCopySettings
            // 
            this.ToolStripMenuItemCopySettings.Name = "ToolStripMenuItemCopySettings";
            this.ToolStripMenuItemCopySettings.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemCopySettings.Text = "Settings";
            this.ToolStripMenuItemCopySettings.Click += new System.EventHandler(this.ToolStripMenuItemCopySettings_Click);
            // 
            // ToolStripMenuItemRenameF
            // 
            this.ToolStripMenuItemRenameF.Name = "ToolStripMenuItemRenameF";
            this.ToolStripMenuItemRenameF.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemRenameF.Text = "Rename";
            this.ToolStripMenuItemRenameF.Click += new System.EventHandler(this.ToolStripMenuItemRenameF_Click);
            // 
            // ToolStripMenuItemMoveF
            // 
            this.ToolStripMenuItemMoveF.Name = "ToolStripMenuItemMoveF";
            this.ToolStripMenuItemMoveF.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemMoveF.Text = "Move To";
            this.ToolStripMenuItemMoveF.MouseHover += new System.EventHandler(this.ToolStripMenuItemMoveF_MouseHover);
            // 
            // ToolStripMenuItemDeleteF
            // 
            this.ToolStripMenuItemDeleteF.Name = "ToolStripMenuItemDeleteF";
            this.ToolStripMenuItemDeleteF.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemDeleteF.Text = "Delete";
            this.ToolStripMenuItemDeleteF.Click += new System.EventHandler(this.ToolStripMenuItemDeleteF_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel8.Controls.Add(this.listBoxPreset);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10);
            this.panel8.Size = new System.Drawing.Size(218, 156);
            this.panel8.TabIndex = 76;
            // 
            // listBoxPreset
            // 
            this.listBoxPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.listBoxPreset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPreset.ContextMenuStrip = this.contextMenuStripPreset;
            this.listBoxPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPreset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxPreset.ForeColor = System.Drawing.Color.Silver;
            this.listBoxPreset.FormattingEnabled = true;
            this.listBoxPreset.ItemHeight = 20;
            this.listBoxPreset.Location = new System.Drawing.Point(10, 10);
            this.listBoxPreset.Name = "listBoxPreset";
            this.listBoxPreset.Size = new System.Drawing.Size(198, 136);
            this.listBoxPreset.TabIndex = 2;
            this.listBoxPreset.SelectedIndexChanged += new System.EventHandler(this.listBoxPreset_SelectedIndexChanged);
            // 
            // contextMenuStripPreset
            // 
            this.contextMenuStripPreset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpenP,
            this.ToolStripMenuItemRenameP,
            this.ToolStripMenuItemDeleteP});
            this.contextMenuStripPreset.Name = "contextMenuStrip1";
            this.contextMenuStripPreset.Size = new System.Drawing.Size(118, 70);
            // 
            // ToolStripMenuItemOpenP
            // 
            this.ToolStripMenuItemOpenP.Name = "ToolStripMenuItemOpenP";
            this.ToolStripMenuItemOpenP.Size = new System.Drawing.Size(117, 22);
            this.ToolStripMenuItemOpenP.Text = "Open";
            this.ToolStripMenuItemOpenP.Click += new System.EventHandler(this.ToolStripMenuItemOpenP_Click);
            // 
            // ToolStripMenuItemRenameP
            // 
            this.ToolStripMenuItemRenameP.Name = "ToolStripMenuItemRenameP";
            this.ToolStripMenuItemRenameP.Size = new System.Drawing.Size(117, 22);
            this.ToolStripMenuItemRenameP.Text = "Rename";
            this.ToolStripMenuItemRenameP.Click += new System.EventHandler(this.ToolStripMenuItemRenameP_Click);
            // 
            // ToolStripMenuItemDeleteP
            // 
            this.ToolStripMenuItemDeleteP.Name = "ToolStripMenuItemDeleteP";
            this.ToolStripMenuItemDeleteP.Size = new System.Drawing.Size(117, 22);
            this.ToolStripMenuItemDeleteP.Text = "Delete";
            this.ToolStripMenuItemDeleteP.Click += new System.EventHandler(this.ToolStripMenuItemDeleteP_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.panel12.Controls.Add(this.listViewInitImages);
            this.panel12.Location = new System.Drawing.Point(522, 165);
            this.panel12.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(3);
            this.panel12.Size = new System.Drawing.Size(155, 512);
            this.panel12.TabIndex = 75;
            // 
            // listViewInitImages
            // 
            this.listViewInitImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(5)))), ((int)(((byte)(10)))));
            this.listViewInitImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewInitImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImagesList});
            this.listViewInitImages.ContextMenuStrip = this.contextMenuStripImageList;
            this.listViewInitImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewInitImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInitImages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewInitImages.ForeColor = System.Drawing.Color.Silver;
            this.listViewInitImages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewInitImages.Location = new System.Drawing.Point(3, 3);
            this.listViewInitImages.Name = "listViewInitImages";
            this.listViewInitImages.Size = new System.Drawing.Size(149, 506);
            this.listViewInitImages.TabIndex = 55;
            this.listViewInitImages.UseCompatibleStateImageBehavior = false;
            this.listViewInitImages.View = System.Windows.Forms.View.Details;
            this.listViewInitImages.SelectedIndexChanged += new System.EventHandler(this.listViewInitImages_SelectedIndexChanged);
            this.listViewInitImages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewInitImages_KeyDown);
            // 
            // ImagesList
            // 
            this.ImagesList.Text = "Images List";
            this.ImagesList.Width = 128;
            // 
            // contextMenuStripImageList
            // 
            this.contextMenuStripImageList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpenI,
            this.toolStripMenuItemSetInitImage,
            this.ToolStripMenuItemDeleteI});
            this.contextMenuStripImageList.Name = "contextMenuStrip1";
            this.contextMenuStripImageList.Size = new System.Drawing.Size(173, 70);
            // 
            // ToolStripMenuItemOpenI
            // 
            this.ToolStripMenuItemOpenI.Name = "ToolStripMenuItemOpenI";
            this.ToolStripMenuItemOpenI.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItemOpenI.Text = "Open";
            this.ToolStripMenuItemOpenI.Click += new System.EventHandler(this.ToolStripMenuItemOpenI_Click);
            // 
            // toolStripMenuItemSetInitImage
            // 
            this.toolStripMenuItemSetInitImage.Name = "toolStripMenuItemSetInitImage";
            this.toolStripMenuItemSetInitImage.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemSetInitImage.Text = "Set as Initial Image";
            this.toolStripMenuItemSetInitImage.Click += new System.EventHandler(this.toolStripMenuItemSetInitImage_Click);
            // 
            // ToolStripMenuItemDeleteI
            // 
            this.ToolStripMenuItemDeleteI.Name = "ToolStripMenuItemDeleteI";
            this.ToolStripMenuItemDeleteI.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItemDeleteI.Text = "Delete";
            this.ToolStripMenuItemDeleteI.Click += new System.EventHandler(this.ToolStripMenuItemDeleteI_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(3, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TabBrowseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelTabBrowser);
            this.Name = "TabBrowseControl";
            this.Size = new System.Drawing.Size(680, 680);
            this.panelTabBrowser.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextMenuStripFolderList.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.contextMenuStripPreset.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.contextMenuStripImageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTabBrowser;
        private Panel panel12;
        private ListView listViewInitImages;
        private ColumnHeader ImagesList;
        private PictureBox pictureBox1;
        private Panel panel8;
        private ListBox listBoxPreset;
        private Panel panel1;
        private ListBox listBoxFolderList;
        private Panel panel2;
        private ListBox listBoxResultSettings;
        private System.Windows.Forms.Timer timer1;
        private ContextMenuStrip contextMenuStripFolderList;
        private ToolStripMenuItem ToolStripMenuItemFopen;
        private ToolStripMenuItem ToolStripMenuItemDeleteF;
        private ToolStripMenuItem ToolStripMenuItemRenameF;
        private ToolStripMenuItem ToolStripMenuItemCopyPreset;
        private ToolStripMenuItem ToolStripMenuItemCopyAll;
        private ToolStripMenuItem ToolStripMenuItemCopyPrompt;
        private ToolStripMenuItem ToolStripMenuItemCopyStyles;
        private ToolStripMenuItem ToolStripMenuItemCopySettings;
        private ToolStripMenuItem ToolStripMenuItemMoveF;
        private ContextMenuStrip contextMenuStripPreset;
        private ToolStripMenuItem ToolStripMenuItemOpenP;
        private ToolStripMenuItem ToolStripMenuItemRenameP;
        private ToolStripMenuItem ToolStripMenuItemDeleteP;
        private ContextMenuStrip contextMenuStripImageList;
        private ToolStripMenuItem ToolStripMenuItemOpenI;
        private ToolStripMenuItem toolStripMenuItemSetInitImage;
        private ToolStripMenuItem ToolStripMenuItemDeleteI;
    }
}
