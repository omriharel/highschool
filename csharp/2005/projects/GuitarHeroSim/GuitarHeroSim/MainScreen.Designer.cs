namespace GuitarHeroSim
{
    partial class MainScreen
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
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrange.Location = new System.Drawing.Point(396, 3);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(51, 21);
            this.btnOrange.TabIndex = 0;
            this.btnOrange.TabStop = false;
            this.btnOrange.Text = "J";
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBlue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBlue.Location = new System.Drawing.Point(344, 3);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(51, 21);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.TabStop = false;
            this.btnBlue.Text = "H";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnYellow.Location = new System.Drawing.Point(292, 3);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(51, 21);
            this.btnYellow.TabIndex = 0;
            this.btnYellow.TabStop = false;
            this.btnYellow.Text = "G";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRed.Location = new System.Drawing.Point(240, 3);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(51, 21);
            this.btnRed.TabIndex = 0;
            this.btnRed.TabStop = false;
            this.btnRed.Text = "F";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Lime;
            this.btnGreen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGreen.Location = new System.Drawing.Point(188, 3);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(51, 21);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.TabStop = false;
            this.btnGreen.Text = "D";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(449, 207);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnOrange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Guitar Hero Simulator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;

    }
}

