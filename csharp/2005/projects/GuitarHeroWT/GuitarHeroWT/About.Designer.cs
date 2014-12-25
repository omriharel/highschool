namespace GuitarHeroWT
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lnkMyTrac = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblVisit = new System.Windows.Forms.Label();
            this.lblForMore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(163, 204);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // lnkMyTrac
            // 
            this.lnkMyTrac.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lnkMyTrac.AutoSize = true;
            this.lnkMyTrac.Location = new System.Drawing.Point(203, 201);
            this.lnkMyTrac.Name = "lnkMyTrac";
            this.lnkMyTrac.Size = new System.Drawing.Size(60, 13);
            this.lnkMyTrac.TabIndex = 24;
            this.lnkMyTrac.TabStop = true;
            this.lnkMyTrac.Text = "Omri\'s Trac";
            this.lnkMyTrac.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkMyTrac.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMyTrac_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(181, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(196, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Guitar Hero: World Tour Score Manager";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(181, 29);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 25;
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(181, 46);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(100, 13);
            this.lblCreator.TabIndex = 25;
            this.lblCreator.Text = "Made by Omri Harel";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(181, 117);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 13);
            this.lblDesc.TabIndex = 26;
            // 
            // lblVisit
            // 
            this.lblVisit.AutoSize = true;
            this.lblVisit.Location = new System.Drawing.Point(181, 201);
            this.lblVisit.Name = "lblVisit";
            this.lblVisit.Size = new System.Drawing.Size(26, 13);
            this.lblVisit.TabIndex = 25;
            this.lblVisit.Text = "Visit";
            // 
            // lblForMore
            // 
            this.lblForMore.AutoSize = true;
            this.lblForMore.Location = new System.Drawing.Point(259, 201);
            this.lblForMore.Name = "lblForMore";
            this.lblForMore.Size = new System.Drawing.Size(48, 13);
            this.lblForMore.TabIndex = 25;
            this.lblForMore.Text = "for more!";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 228);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblForMore);
            this.Controls.Add(this.lblVisit);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lnkMyTrac);
            this.Controls.Add(this.logoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.LinkLabel lnkMyTrac;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblVisit;
        private System.Windows.Forms.Label lblForMore;
    }
}
