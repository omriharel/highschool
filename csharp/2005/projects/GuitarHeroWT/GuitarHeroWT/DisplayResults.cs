using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuitarHeroWT
{
    public partial class DisplayResults : Form
    {
        public DisplayResults()
        {
            InitializeComponent();
            cmbPlayerDetails.Items.Add("Select player for more details:");
            for (int i = 0; i < GlobalVars.players.Length; i++)
            {
                cmbPlayerDetails.Items.Add(GlobalVars.players[i].name.ToString());
            }
            cmbPlayerDetails.SelectedIndex = 0;
            cmbSongDetails.Items.Add("Select song for more details:");
            for (int i = 0; i < GlobalVars.totalSongsPlayed; i++)
            {
                cmbSongDetails.Items.Add(Program.mySongs.songName[GlobalVars.songs[i].songDataId]);
            }
            cmbSongDetails.SelectedIndex = 0;
            Song latestSong = GlobalVars.songs[GlobalVars.totalSongsPlayed - 1];
            lblRSongName.Text = Program.mySongs.songName[latestSong.songDataId];
            lblRArtist.Text = Program.mySongs.songArtist[latestSong.songDataId];
            lblRPercent.Text = latestSong.percent.ToString() + "%";
            lblRStars.Text = latestSong.stars.ToString() + "/5";
            lblRFinalScore.Text = latestSong.songScore.ToString() + "/1000";
            Label[] myPlayers = new Label[] { lblPlyr1, lblPlyr2, lblPlyr3, lblPlyr4 };
            for (int i = 0; i < latestSong.playersIds.Length; i++)
            {
                string toAssign = "";
                toAssign += GlobalVars.players[latestSong.playersIds[i]].name + " played ";
                toAssign += latestSong.instrumentToStr(latestSong.playersInstIds[i]) + " on ";
                toAssign += latestSong.difficultyToStr(latestSong.playersDiffIds[i]);
                myPlayers[i].Text = toAssign;
            }
        }

        private void DisplayResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainScreen.canShowResults = true;
        }

        public static int playerIdToUse = 0, songIdToUse = 0;

        private void btnGoPlayer_Click(object sender, EventArgs e)
        {
            if (cmbPlayerDetails.SelectedIndex != 0 && Program.canOpenPlayerDetails)
            {
                playerIdToUse = cmbPlayerDetails.SelectedIndex - 1;
                Form playerDetails = new PlayerDetails();
                playerDetails.Show();
                Program.canOpenPlayerDetails = false;
            }
        }

        private void btnGoSong_Click(object sender, EventArgs e)
        {
            if (cmbSongDetails.SelectedIndex != 0 && Program.canOpenSongDetails)
            {
                songIdToUse = cmbSongDetails.SelectedIndex - 1;
                Form songDetails = new SongDetails();
                songDetails.Show();
                Program.canOpenSongDetails = false;
            }
        }
    }
}