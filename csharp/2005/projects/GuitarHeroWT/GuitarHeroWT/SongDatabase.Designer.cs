namespace GuitarHeroWT
{
    partial class SongDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongDatabase));
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblYouTubeLnk = new System.Windows.Forms.Label();
            this.lblLyricsLnk = new System.Windows.Forms.Label();
            this.cmbListOfSongs = new System.Windows.Forms.ComboBox();
            this.lblSongNameCh = new System.Windows.Forms.Label();
            this.lblArtistCh = new System.Windows.Forms.Label();
            this.btnYouTubeLnk = new System.Windows.Forms.Button();
            this.btnLyricsLnk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSongName.Location = new System.Drawing.Point(12, 46);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(76, 13);
            this.lblSongName.TabIndex = 0;
            this.lblSongName.Text = "Song Name:";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblArtist.Location = new System.Drawing.Point(12, 70);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(40, 13);
            this.lblArtist.TabIndex = 0;
            this.lblArtist.Text = "Artist:";
            // 
            // lblYouTubeLnk
            // 
            this.lblYouTubeLnk.AutoSize = true;
            this.lblYouTubeLnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblYouTubeLnk.Location = new System.Drawing.Point(12, 94);
            this.lblYouTubeLnk.Name = "lblYouTubeLnk";
            this.lblYouTubeLnk.Size = new System.Drawing.Size(98, 13);
            this.lblYouTubeLnk.TabIndex = 0;
            this.lblYouTubeLnk.Text = "YouTube Video:";
            // 
            // lblLyricsLnk
            // 
            this.lblLyricsLnk.AutoSize = true;
            this.lblLyricsLnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLyricsLnk.Location = new System.Drawing.Point(12, 118);
            this.lblLyricsLnk.Name = "lblLyricsLnk";
            this.lblLyricsLnk.Size = new System.Drawing.Size(77, 13);
            this.lblLyricsLnk.TabIndex = 0;
            this.lblLyricsLnk.Text = "Song Lyrics:";
            // 
            // cmbListOfSongs
            // 
            this.cmbListOfSongs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListOfSongs.FormattingEnabled = true;
            this.cmbListOfSongs.Location = new System.Drawing.Point(12, 12);
            this.cmbListOfSongs.Name = "cmbListOfSongs";
            this.cmbListOfSongs.Size = new System.Drawing.Size(297, 21);
            this.cmbListOfSongs.TabIndex = 1;
            this.cmbListOfSongs.SelectionChangeCommitted += new System.EventHandler(this.cmbListOfSongs_SelectionChangeCommitted);
            // 
            // lblSongNameCh
            // 
            this.lblSongNameCh.AutoSize = true;
            this.lblSongNameCh.Location = new System.Drawing.Point(86, 46);
            this.lblSongNameCh.Name = "lblSongNameCh";
            this.lblSongNameCh.Size = new System.Drawing.Size(0, 13);
            this.lblSongNameCh.TabIndex = 2;
            // 
            // lblArtistCh
            // 
            this.lblArtistCh.AutoSize = true;
            this.lblArtistCh.Location = new System.Drawing.Point(50, 70);
            this.lblArtistCh.Name = "lblArtistCh";
            this.lblArtistCh.Size = new System.Drawing.Size(0, 13);
            this.lblArtistCh.TabIndex = 2;
            // 
            // btnYouTubeLnk
            // 
            this.btnYouTubeLnk.Location = new System.Drawing.Point(110, 90);
            this.btnYouTubeLnk.Name = "btnYouTubeLnk";
            this.btnYouTubeLnk.Size = new System.Drawing.Size(38, 20);
            this.btnYouTubeLnk.TabIndex = 3;
            this.btnYouTubeLnk.Tag = "";
            this.btnYouTubeLnk.Text = "Click";
            this.btnYouTubeLnk.UseVisualStyleBackColor = true;
            this.btnYouTubeLnk.Visible = false;
            this.btnYouTubeLnk.Click += new System.EventHandler(this.btnYouTubeLnk_Click);
            // 
            // btnLyricsLnk
            // 
            this.btnLyricsLnk.Location = new System.Drawing.Point(89, 114);
            this.btnLyricsLnk.Name = "btnLyricsLnk";
            this.btnLyricsLnk.Size = new System.Drawing.Size(38, 20);
            this.btnLyricsLnk.TabIndex = 3;
            this.btnLyricsLnk.Text = "Click";
            this.btnLyricsLnk.UseVisualStyleBackColor = true;
            this.btnLyricsLnk.Visible = false;
            this.btnLyricsLnk.Click += new System.EventHandler(this.btnLyricsLnk_Click);
            // 
            // SongDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 143);
            this.Controls.Add(this.btnLyricsLnk);
            this.Controls.Add(this.btnYouTubeLnk);
            this.Controls.Add(this.lblArtistCh);
            this.Controls.Add(this.lblSongNameCh);
            this.Controls.Add(this.cmbListOfSongs);
            this.Controls.Add(this.lblLyricsLnk);
            this.Controls.Add(this.lblYouTubeLnk);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblSongName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SongDatabase";
            this.Text = "Song Database for Guitar Hero: World Tour";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SongDatabase_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblYouTubeLnk;
        private System.Windows.Forms.Label lblLyricsLnk;
        private System.Windows.Forms.ComboBox cmbListOfSongs;
        private System.Windows.Forms.Label lblSongNameCh;
        private System.Windows.Forms.Label lblArtistCh;
        private System.Windows.Forms.Button btnYouTubeLnk;
        private System.Windows.Forms.Button btnLyricsLnk;
    }
}