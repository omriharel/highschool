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
            this.lblCurPlyrs = new System.Windows.Forms.Label();
            this.lblCurSongs = new System.Windows.Forms.Label();
            this.lblTotScore = new System.Windows.Forms.Label();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnDispResults = new System.Windows.Forms.Button();
            this.btnManagePlyrs = new System.Windows.Forms.Button();
            this.grpTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTasks
            // 
            this.grpTasks.Controls.Add(this.btnManagePlyrs);
            this.grpTasks.Controls.Add(this.btnDispResults);
            this.grpTasks.Controls.Add(this.btnAddSong);
            this.grpTasks.Location = new System.Drawing.Point(13, 86);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(445, 51);
            this.grpTasks.TabIndex = 0;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Available Tasks";
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
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(6, 15);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(99, 31);
            this.btnAddSong.TabIndex = 0;
            this.btnAddSong.Text = "Add New Song...";
            this.btnAddSong.UseVisualStyleBackColor = true;
            // 
            // btnDispResults
            // 
            this.btnDispResults.Location = new System.Drawing.Point(111, 15);
            this.btnDispResults.Name = "btnDispResults";
            this.btnDispResults.Size = new System.Drawing.Size(99, 31);
            this.btnDispResults.TabIndex = 1;
            this.btnDispResults.Text = "Display Results";
            this.btnDispResults.UseVisualStyleBackColor = true;
            // 
            // btnManagePlyrs
            // 
            this.btnManagePlyrs.Location = new System.Drawing.Point(216, 15);
            this.btnManagePlyrs.Name = "btnManagePlyrs";
            this.btnManagePlyrs.Size = new System.Drawing.Size(99, 31);
            this.btnManagePlyrs.TabIndex = 1;
            this.btnManagePlyrs.Text = "Manage Players";
            this.btnManagePlyrs.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 151);
            this.Controls.Add(this.lblTotScore);
            this.Controls.Add(this.lblCurSongs);
            this.Controls.Add(this.lblCurPlyrs);
            this.Controls.Add(this.grpTasks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.grpTasks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTasks;
        private System.Windows.Forms.Label lblCurPlyrs;
        private System.Windows.Forms.Label lblCurSongs;
        public System.Windows.Forms.Label lblTotScore;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnManagePlyrs;
        private System.Windows.Forms.Button btnDispResults;
    }
}