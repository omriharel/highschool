namespace GuitarHeroWT
{
    partial class PlayerSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerSetup));
            this.prgPlayerNames = new System.Windows.Forms.ProgressBar();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblPlyrNamePrg = new System.Windows.Forms.Label();
            this.txtPlyrName = new System.Windows.Forms.TextBox();
            this.btnAddPlyr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prgPlayerNames
            // 
            this.prgPlayerNames.Location = new System.Drawing.Point(9, 59);
            this.prgPlayerNames.Name = "prgPlayerNames";
            this.prgPlayerNames.Size = new System.Drawing.Size(191, 22);
            this.prgPlayerNames.Step = 40;
            this.prgPlayerNames.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgPlayerNames.TabIndex = 0;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(7, 8);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(152, 13);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter the name of each player:";
            // 
            // lblPlyrNamePrg
            // 
            this.lblPlyrNamePrg.AutoSize = true;
            this.lblPlyrNamePrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlyrNamePrg.Location = new System.Drawing.Point(8, 32);
            this.lblPlyrNamePrg.Name = "lblPlyrNamePrg";
            this.lblPlyrNamePrg.Size = new System.Drawing.Size(0, 13);
            this.lblPlyrNamePrg.TabIndex = 2;
            // 
            // txtPlyrName
            // 
            this.txtPlyrName.Location = new System.Drawing.Point(52, 29);
            this.txtPlyrName.MaxLength = 20;
            this.txtPlyrName.Name = "txtPlyrName";
            this.txtPlyrName.Size = new System.Drawing.Size(104, 20);
            this.txtPlyrName.TabIndex = 0;
            // 
            // btnAddPlyr
            // 
            this.btnAddPlyr.Location = new System.Drawing.Point(163, 29);
            this.btnAddPlyr.Name = "btnAddPlyr";
            this.btnAddPlyr.Size = new System.Drawing.Size(35, 20);
            this.btnAddPlyr.TabIndex = 3;
            this.btnAddPlyr.TabStop = false;
            this.btnAddPlyr.Text = "Add";
            this.btnAddPlyr.UseVisualStyleBackColor = true;
            this.btnAddPlyr.Click += new System.EventHandler(this.btnAddPlyr_Click);
            // 
            // PlayerSetup
            // 
            this.AcceptButton = this.btnAddPlyr;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 90);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddPlyr);
            this.Controls.Add(this.txtPlyrName);
            this.Controls.Add(this.lblPlyrNamePrg);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.prgPlayerNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerSetup";
            this.Text = "Player Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgPlayerNames;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblPlyrNamePrg;
        private System.Windows.Forms.TextBox txtPlyrName;
        private System.Windows.Forms.Button btnAddPlyr;
    }
}