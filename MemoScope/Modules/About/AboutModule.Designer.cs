﻿namespace MemoScope.Modules.About
{
    partial class AboutModule
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
            this.tbApplicationName = new System.Windows.Forms.TextBox();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.lblGitHubUrl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbVersion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbApplicationName
            // 
            this.tbApplicationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApplicationName.Location = new System.Drawing.Point(139, 46);
            this.tbApplicationName.Name = "tbApplicationName";
            this.tbApplicationName.ReadOnly = true;
            this.tbApplicationName.Size = new System.Drawing.Size(417, 46);
            this.tbApplicationName.TabIndex = 0;
            this.tbApplicationName.Text = "MemoScope.Net";
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Location = new System.Drawing.Point(98, 131);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(276, 17);
            this.linkGitHub.TabIndex = 1;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "https://github.com/fremag/MemoScope.Net";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // lblGitHubUrl
            // 
            this.lblGitHubUrl.AutoSize = true;
            this.lblGitHubUrl.Location = new System.Drawing.Point(28, 131);
            this.lblGitHubUrl.Name = "lblGitHubUrl";
            this.lblGitHubUrl.Size = new System.Drawing.Size(64, 17);
            this.lblGitHubUrl.TabIndex = 2;
            this.lblGitHubUrl.Text = "Git Hub :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MemoScope.Properties.Resources.memoscope_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbVersion
            // 
            this.tbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVersion.Location = new System.Drawing.Point(430, 107);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.ReadOnly = true;
            this.tbVersion.Size = new System.Drawing.Size(114, 31);
            this.tbVersion.TabIndex = 4;
            // 
            // AboutModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGitHubUrl);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.tbApplicationName);
            this.Name = "AboutModule";
            this.Size = new System.Drawing.Size(559, 169);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbApplicationName;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.Label lblGitHubUrl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbVersion;
    }
}