namespace GuitarHeroWT
{
    partial class Start
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
            this.numOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblHwMnyPlyrs = new System.Windows.Forms.Label();
            this.numOfSongs = new System.Windows.Forms.NumericUpDown();
            this.lblSngsForEachPlyr = new System.Windows.Forms.Label();
            this.btnStartOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOfPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // numOfPlayers
            // 
            this.numOfPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOfPlayers.Location = new System.Drawing.Point(134, 8);
            this.numOfPlayers.Name = "numOfPlayers";
            this.numOfPlayers.ReadOnly = true;
            this.numOfPlayers.Size = new System.Drawing.Size(40, 20);
            this.numOfPlayers.TabIndex = 0;
            this.numOfPlayers.TabStop = false;
            // 
            // lblHwMnyPlyrs
            // 
            this.lblHwMnyPlyrs.AutoSize = true;
            this.lblHwMnyPlyrs.Location = new System.Drawing.Point(12, 11);
            this.lblHwMnyPlyrs.Name = "lblHwMnyPlyrs";
            this.lblHwMnyPlyrs.Size = new System.Drawing.Size(99, 13);
            this.lblHwMnyPlyrs.TabIndex = 1;
            this.lblHwMnyPlyrs.Text = "How many players?";
            // 
            // numOfSongs
            // 
            this.numOfSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOfSongs.Location = new System.Drawing.Point(134, 33);
            this.numOfSongs.Name = "numOfSongs";
            this.numOfSongs.ReadOnly = true;
            this.numOfSongs.Size = new System.Drawing.Size(40, 20);
            this.numOfSongs.TabIndex = 0;
            this.numOfSongs.TabStop = false;
            // 
            // lblSngsForEachPlyr
            // 
            this.lblSngsForEachPlyr.AutoSize = true;
            this.lblSngsForEachPlyr.Location = new System.Drawing.Point(12, 37);
            this.lblSngsForEachPlyr.Name = "lblSngsForEachPlyr";
            this.lblSngsForEachPlyr.Size = new System.Drawing.Size(116, 13);
            this.lblSngsForEachPlyr.TabIndex = 1;
            this.lblSngsForEachPlyr.Text = "Songs for each player?";
            // 
            // btnStartOk
            // 
            this.btnStartOk.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOk.Location = new System.Drawing.Point(181, 7);
            this.btnStartOk.Name = "btnStartOk";
            this.btnStartOk.Size = new System.Drawing.Size(94, 46);
            this.btnStartOk.TabIndex = 0;
            this.btnStartOk.Text = "OK!";
            this.btnStartOk.UseVisualStyleBackColor = true;
            this.btnStartOk.Click += new System.EventHandler(this.btnStartOk_Click);
            // 
            // Start
            // 
            this.AcceptButton = this.btnStartOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 62);
            this.ControlBox = false;
            this.Controls.Add(this.btnStartOk);
            this.Controls.Add(this.lblSngsForEachPlyr);
            this.Controls.Add(this.lblHwMnyPlyrs);
            this.Controls.Add(this.numOfSongs);
            this.Controls.Add(this.numOfPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.numOfPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numOfPlayers;
        private System.Windows.Forms.Label lblHwMnyPlyrs;
        private System.Windows.Forms.NumericUpDown numOfSongs;
        private System.Windows.Forms.Label lblSngsForEachPlyr;
        private System.Windows.Forms.Button btnStartOk;
    }
}

