using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuitarHeroWT
{
    public partial class SongDatabase : Form
    {
        public SongDatabase()
        {
            InitializeComponent();
            cmbListOfSongs.Items.Add("Select Song:");
            for(int i = 0; i < Program.mySongs.songName.Length; i++)
            {
                cmbListOfSongs.Items.Add(Program.mySongs.songName[i].ToString() + " - " + Program.mySongs.songArtist[i].ToString());
            }
            cmbListOfSongs.SelectedItem = cmbListOfSongs.Items[0];
        }

        private void SongDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainScreen.canShowDatabase = true;
        }

        private void cmbListOfSongs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbListOfSongs.SelectedIndex)
            {
                case 0:
                    {
                        lblSongNameCh.ResetText();
                        lblArtistCh.ResetText();
                        btnYouTubeLnk.Visible = false;
                        btnLyricsLnk.Visible = false;
                    }
                    break;
                default:
                    {
                        lblSongNameCh.Text = Program.mySongs.songName[cmbListOfSongs.SelectedIndex - 1];
                        lblArtistCh.Text = Program.mySongs.songArtist[cmbListOfSongs.SelectedIndex - 1];
                        //btnYouTubeLnk.Tag = Program.mySongs.youTubeLink[cmbListOfSongs.SelectedIndex - 1];
                        btnYouTubeLnk.Visible = true;
                        btnLyricsLnk.Tag = Program.mySongs.lyricsLink[cmbListOfSongs.SelectedIndex - 1];
                        btnLyricsLnk.Visible = true;
                    }
                    break;
            }
        }

        private void btnYouTubeLnk_Click(object sender, EventArgs e)
        {
            if (btnYouTubeLnk.Tag != null && btnYouTubeLnk.Tag.ToString() != "Unavailable")
            System.Diagnostics.Process.Start("iexplore.exe", btnYouTubeLnk.Tag.ToString());
            else if (btnYouTubeLnk.Tag.ToString() == "Unavailable")
            MessageBox.Show(this, "A YouTube clip is not available for this song.", "YouTube clip unavailable");
        }

        private void btnLyricsLnk_Click(object sender, EventArgs e)
        {
            if (btnLyricsLnk.Tag != null && btnLyricsLnk.Tag.ToString() != "Unavailable")
                System.Diagnostics.Process.Start("iexplore.exe",btnLyricsLnk.Tag.ToString());
            else if (btnLyricsLnk.Tag.ToString() == "Unavailable")
                MessageBox.Show(this, "Lyrics are not available for this song.", "Lyrics unavailable");
        }
    }
}