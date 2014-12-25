using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuitarHeroWT
{
    public partial class SongDetails : Form
    {
        public SongDetails()
        {
            InitializeComponent();
            int songId = DisplayResults.songIdToUse;
            Song song = GlobalVars.songs[songId];
            this.Text = "Song Details: " + Program.mySongs.songName[song.songDataId];
            lblRSongName.Text = Program.mySongs.songName[song.songDataId];
            lblRArtist.Text = Program.mySongs.songArtist[song.songDataId];
            lblRPercent.Text = song.percent.ToString() + "%";
            lblRStars.Text = song.stars.ToString() + "/5";
            lblRFinalScore.Text = song.songScore.ToString() + "/1000";
            Label[] myPlayers = new Label[] { lblPlyr1, lblPlyr2, lblPlyr3, lblPlyr4 };
            for (int i = 0; i < song.playersIds.Length; i++)
            {
                string toAssign = "";
                toAssign += GlobalVars.players[song.playersIds[i]].name + " played ";
                toAssign += song.instrumentToStr(song.playersInstIds[i]) + " on ";
                toAssign += song.difficultyToStr(song.playersDiffIds[i]);
                myPlayers[i].Text = toAssign;
            }
        }

        private void SongDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.canOpenSongDetails = true;
        }
    }
}