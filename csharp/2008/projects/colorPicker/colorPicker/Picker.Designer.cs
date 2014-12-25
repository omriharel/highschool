namespace colorPicker
{
    partial class Picker
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
            this.trcRed = new System.Windows.Forms.TrackBar();
            this.trcBlue = new System.Windows.Forms.TrackBar();
            this.trcGreen = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl255 = new System.Windows.Forms.Label();
            this.lblRedVal = new System.Windows.Forms.Label();
            this.lblGreenVal = new System.Windows.Forms.Label();
            this.lblBlueVal = new System.Windows.Forms.Label();
            this.trcOpacity = new System.Windows.Forms.TrackBar();
            this.lblOpacity30 = new System.Windows.Forms.Label();
            this.lblOpacity100 = new System.Windows.Forms.Label();
            this.lblCopyright1 = new System.Windows.Forms.Label();
            this.lnkCopyright2 = new System.Windows.Forms.LinkLabel();
            this.lblCopyright3 = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // trcRed
            // 
            this.trcRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trcRed.Location = new System.Drawing.Point(39, 15);
            this.trcRed.Maximum = 255;
            this.trcRed.Name = "trcRed";
            this.trcRed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trcRed.Size = new System.Drawing.Size(165, 45);
            this.trcRed.TabIndex = 0;
            this.trcRed.TabStop = false;
            this.trcRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcRed.ValueChanged += new System.EventHandler(this.trcRed_ValueChanged);
            // 
            // trcBlue
            // 
            this.trcBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trcBlue.Location = new System.Drawing.Point(39, 74);
            this.trcBlue.Maximum = 255;
            this.trcBlue.Name = "trcBlue";
            this.trcBlue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trcBlue.Size = new System.Drawing.Size(165, 45);
            this.trcBlue.TabIndex = 0;
            this.trcBlue.TabStop = false;
            this.trcBlue.TickFrequency = 13;
            this.trcBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcBlue.ValueChanged += new System.EventHandler(this.trcBlue_ValueChanged);
            // 
            // trcGreen
            // 
            this.trcGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trcGreen.Location = new System.Drawing.Point(39, 45);
            this.trcGreen.Maximum = 255;
            this.trcGreen.Name = "trcGreen";
            this.trcGreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trcGreen.Size = new System.Drawing.Size(165, 45);
            this.trcGreen.TabIndex = 0;
            this.trcGreen.TabStop = false;
            this.trcGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcGreen.ValueChanged += new System.EventHandler(this.trcGreen_ValueChanged);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRed.Location = new System.Drawing.Point(5, 18);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGreen.Location = new System.Drawing.Point(5, 50);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 1;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBlue.Location = new System.Drawing.Point(5, 80);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 1;
            this.lblBlue.Text = "Blue";
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(50, 101);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(13, 13);
            this.lbl0.TabIndex = 2;
            this.lbl0.Text = "0";
            // 
            // lbl255
            // 
            this.lbl255.AutoSize = true;
            this.lbl255.Location = new System.Drawing.Point(184, 103);
            this.lbl255.Name = "lbl255";
            this.lbl255.Size = new System.Drawing.Size(25, 13);
            this.lbl255.TabIndex = 2;
            this.lbl255.Text = "255";
            // 
            // lblRedVal
            // 
            this.lblRedVal.AutoSize = true;
            this.lblRedVal.Location = new System.Drawing.Point(208, 18);
            this.lblRedVal.Name = "lblRedVal";
            this.lblRedVal.Size = new System.Drawing.Size(13, 13);
            this.lblRedVal.TabIndex = 2;
            this.lblRedVal.Text = "0";
            // 
            // lblGreenVal
            // 
            this.lblGreenVal.AutoSize = true;
            this.lblGreenVal.Location = new System.Drawing.Point(208, 47);
            this.lblGreenVal.Name = "lblGreenVal";
            this.lblGreenVal.Size = new System.Drawing.Size(13, 13);
            this.lblGreenVal.TabIndex = 2;
            this.lblGreenVal.Text = "0";
            // 
            // lblBlueVal
            // 
            this.lblBlueVal.AutoSize = true;
            this.lblBlueVal.Location = new System.Drawing.Point(208, 77);
            this.lblBlueVal.Name = "lblBlueVal";
            this.lblBlueVal.Size = new System.Drawing.Size(13, 13);
            this.lblBlueVal.TabIndex = 2;
            this.lblBlueVal.Text = "0";
            // 
            // trcOpacity
            // 
            this.trcOpacity.Location = new System.Drawing.Point(280, 97);
            this.trcOpacity.Maximum = 100;
            this.trcOpacity.Minimum = 30;
            this.trcOpacity.Name = "trcOpacity";
            this.trcOpacity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcOpacity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trcOpacity.RightToLeftLayout = true;
            this.trcOpacity.Size = new System.Drawing.Size(45, 55);
            this.trcOpacity.TabIndex = 3;
            this.trcOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcOpacity.Value = 100;
            this.trcOpacity.ValueChanged += new System.EventHandler(this.trcOpacity_ValueChanged);
            // 
            // lblOpacity30
            // 
            this.lblOpacity30.AutoSize = true;
            this.lblOpacity30.Location = new System.Drawing.Point(187, 135);
            this.lblOpacity30.Name = "lblOpacity30";
            this.lblOpacity30.Size = new System.Drawing.Size(111, 13);
            this.lblOpacity30.TabIndex = 4;
            this.lblOpacity30.Text = "Window Opacity: 30%";
            // 
            // lblOpacity100
            // 
            this.lblOpacity100.AutoSize = true;
            this.lblOpacity100.Location = new System.Drawing.Point(265, 102);
            this.lblOpacity100.Name = "lblOpacity100";
            this.lblOpacity100.Size = new System.Drawing.Size(33, 13);
            this.lblOpacity100.TabIndex = 4;
            this.lblOpacity100.Text = "100%";
            // 
            // lblCopyright1
            // 
            this.lblCopyright1.AutoSize = true;
            this.lblCopyright1.Location = new System.Drawing.Point(0, 135);
            this.lblCopyright1.Name = "lblCopyright1";
            this.lblCopyright1.Size = new System.Drawing.Size(81, 13);
            this.lblCopyright1.TabIndex = 4;
            this.lblCopyright1.Text = "Color Picker by ";
            // 
            // lnkCopyright2
            // 
            this.lnkCopyright2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkCopyright2.AutoSize = true;
            this.lnkCopyright2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkCopyright2.Location = new System.Drawing.Point(75, 135);
            this.lnkCopyright2.Name = "lnkCopyright2";
            this.lnkCopyright2.Size = new System.Drawing.Size(56, 13);
            this.lnkCopyright2.TabIndex = 5;
            this.lnkCopyright2.TabStop = true;
            this.lnkCopyright2.Text = "Omri Harel";
            this.lnkCopyright2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkCopyright2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyright2_LinkClicked);
            // 
            // lblCopyright3
            // 
            this.lblCopyright3.AutoSize = true;
            this.lblCopyright3.Location = new System.Drawing.Point(129, 135);
            this.lblCopyright3.Name = "lblCopyright3";
            this.lblCopyright3.Size = new System.Drawing.Size(43, 13);
            this.lblCopyright3.TabIndex = 4;
            this.lblCopyright3.Text = "© 2008";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(0, 119);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(117, 13);
            this.lblHex.TabIndex = 6;
            this.lblHex.Text = "Hexadecimal: #000000";
            // 
            // Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 150);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lnkCopyright2);
            this.Controls.Add(this.lblOpacity100);
            this.Controls.Add(this.lblCopyright3);
            this.Controls.Add(this.lblCopyright1);
            this.Controls.Add(this.lblOpacity30);
            this.Controls.Add(this.trcOpacity);
            this.Controls.Add(this.lblBlueVal);
            this.Controls.Add(this.lblGreenVal);
            this.Controls.Add(this.lblRedVal);
            this.Controls.Add(this.lbl255);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.trcBlue);
            this.Controls.Add(this.trcGreen);
            this.Controls.Add(this.trcRed);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(334, 184);
            this.MinimumSize = new System.Drawing.Size(334, 184);
            this.Name = "Picker";
            this.Text = "C# Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trcRed;
        private System.Windows.Forms.TrackBar trcBlue;
        private System.Windows.Forms.TrackBar trcGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl255;
        private System.Windows.Forms.Label lblRedVal;
        private System.Windows.Forms.Label lblGreenVal;
        private System.Windows.Forms.Label lblBlueVal;
        private System.Windows.Forms.TrackBar trcOpacity;
        private System.Windows.Forms.Label lblOpacity30;
        private System.Windows.Forms.Label lblOpacity100;
        private System.Windows.Forms.Label lblCopyright1;
        private System.Windows.Forms.LinkLabel lnkCopyright2;
        private System.Windows.Forms.Label lblCopyright3;
        private System.Windows.Forms.Label lblHex;
    }
}

