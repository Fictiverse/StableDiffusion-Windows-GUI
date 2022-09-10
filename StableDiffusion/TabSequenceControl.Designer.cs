namespace StableDiffusion
{
    partial class TabSequenceControl
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
            this.panelTabSequence = new System.Windows.Forms.Panel();
            this.buttonWorkInProgress1 = new System.Windows.Forms.Button();
            this.panelTabSequence.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTabSequence
            // 
            this.panelTabSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelTabSequence.Controls.Add(this.buttonWorkInProgress1);
            this.panelTabSequence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabSequence.Location = new System.Drawing.Point(0, 0);
            this.panelTabSequence.Margin = new System.Windows.Forms.Padding(0);
            this.panelTabSequence.Name = "panelTabSequence";
            this.panelTabSequence.Padding = new System.Windows.Forms.Padding(3);
            this.panelTabSequence.Size = new System.Drawing.Size(680, 680);
            this.panelTabSequence.TabIndex = 59;
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
            // TabSequenceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelTabSequence);
            this.Name = "TabSequenceControl";
            this.Size = new System.Drawing.Size(680, 680);
            this.panelTabSequence.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTabSequence;
        private Button buttonWorkInProgress1;
    }
}
