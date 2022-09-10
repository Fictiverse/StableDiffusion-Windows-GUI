namespace StableDiffusion
{
    partial class TrackBarControl
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
            this.paneltb = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // paneltb
            // 
            this.paneltb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.paneltb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltb.Location = new System.Drawing.Point(5, 5);
            this.paneltb.Name = "paneltb";
            this.paneltb.Size = new System.Drawing.Size(140, 35);
            this.paneltb.TabIndex = 0;
            this.paneltb.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltb_Paint);
            this.paneltb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltb_MouseDown);
            this.paneltb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneltb_MouseMove);
            this.paneltb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneltb_MouseUp);
            // 
            // TrackBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paneltb);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TrackBarControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(150, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel paneltb;
    }
}
