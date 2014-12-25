namespace GuitarHeroWT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.btnSongDb = new System.Windows.Forms.Button();
            this.btnDispResults = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lblCurPlyrs = new System.Windows.Forms.Label();
            this.lblCurSongs = new System.Windows.Forms.Label();
            this.lblTotScore = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.btnSaveSession = new System.Windows.Forms.Button();
            this.btnLoadSession = new System.Windows.Forms.Button();
            this.grpTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTasks
            // 
            this.grpTasks.Controls.Add(this.btnSongDb);
            this.grpTasks.Controls.Add(this.btnDispResults);
            this.grpTasks.Controls.Add(this.btnAddSong);
            this.grpTasks.Location = new System.Drawing.Point(13, 86);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(322, 51);
            this.grpTasks.TabIndex = 0;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Available Tasks";
            // 
            // btnSongDb
            // 
            this.btnSongDb.Location = new System.Drawing.Point(216, 14);
            this.btnSongDb.Name = "btnSongDb";
            this.btnSongDb.Size = new System.Drawing.Size(99, 31);
            this.btnSongDb.TabIndex = 3;
            this.btnSongDb.Text = "Song Database";
            this.btnSongDb.UseVisualStyleBackColor = true;
            this.btnSongDb.Click += new System.EventHandler(this.btnSongDb_Click);
            // 
            // btnDispResults
            // 
            this.btnDispResults.Location = new System.Drawing.Point(111, 15);
            this.btnDispResults.Name = "btnDispResults";
            this.btnDispResults.Size = new System.Drawing.Size(99, 31);
            this.btnDispResults.TabIndex = 1;
            this.btnDispResults.Text = "Display Results";
            this.btnDispResults.UseVisualStyleBackColor = true;
            this.btnDispResults.Click += new System.EventHandler(this.btnDispResults_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(6, 14);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(99, 31);
            this.btnAddSong.TabIndex = 0;
            this.btnAddSong.Text = "Add New Song...";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lblCurPlyrs
            // 
            this.lblCurPlyrs.AutoSize = true;
            this.lblCurPlyrs.Location = new System.Drawing.Point(12, 22);
            this.lblCurPlyrs.Name = "lblCurPlyrs";
            this.lblCurPlyrs.Size = new System.Drawing.Size(0, 13);
            this.lblCurPlyrs.TabIndex = 1;
            // 
            // lblCurSongs
            // 
            this.lblCurSongs.AutoSize = true;
            this.lblCurSongs.Location = new System.Drawing.Point(12, 41);
            this.lblCurSongs.Name = "lblCurSongs";
            this.lblCurSongs.Size = new System.Drawing.Size(0, 13);
            this.lblCurSongs.TabIndex = 1;
            // 
            // lblTotScore
            // 
            this.lblTotScore.AutoSize = true;
            this.lblTotScore.Location = new System.Drawing.Point(12, 60);
            this.lblTotScore.Name = "lblTotScore";
            this.lblTotScore.Size = new System.Drawing.Size(0, 13);
            this.lblTotScore.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(229, 9);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(108, 21);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About this program";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Location = new System.Drawing.Point(229, 36);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(108, 21);
            this.btnSaveLog.TabIndex = 2;
            this.btnSaveLog.TabStop = false;
            this.btnSaveLog.Text = "Save log file...";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.Location = new System.Drawing.Point(229, 63);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(51, 21);
            this.btnSaveSession.TabIndex = 3;
            this.btnSaveSession.Text = "Save...";
            this.btnSaveSession.UseVisualStyleBackColor = true;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // btnLoadSession
            // 
            this.btnLoadSession.Location = new System.Drawing.Point(286, 63);
            this.btnLoadSession.Name = "btnLoadSession";
            this.btnLoadSession.Size = new System.Drawing.Size(51, 21);
            this.btnLoadSession.TabIndex = 3;
            this.btnLoadSession.Text = "Load...";
            this.btnLoadSession.UseVisualStyleBackColor = true;
            this.btnLoadSession.Click += new System.EventHandler(this.btnLoadSession_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 151);
            this.Controls.Add(this.btnLoadSession);
            this.Controls.Add(this.btnSaveSession);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblTotScore);
            this.Controls.Add(this.lblCurSongs);
            this.Controls.Add(this.lblCurPlyrs);
            this.Controls.Add(this.grpTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Activated += new System.EventHandler(this.updateLabels);
            this.grpTasks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTasks;
        public System.Windows.Forms.Label lblTotScore;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnDispResults;
        private System.Windows.Forms.Button btnSongDb;
        public System.Windows.Forms.Label lblCurPlyrs;
        public System.Windows.Forms.Label lblCurSongs;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.Button btnSaveSession;
        private System.Windows.Forms.Button btnLoadSession;
    }
}