using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuitarHeroWT
{
    public partial class PlayerDetails : Form
    {
        int playerId = DisplayResults.playerIdToUse;

        public PlayerDetails()
        {
            InitializeComponent();
            Player player = GlobalVars.players[playerId];
            this.Text = "Player Profile: " + player.name;
            lblRPlayerName.Text = player.name;
            lblRPlayerScore.Text = player.playerScore.ToString();
            lblRSongsPlayed.Text = player.playedSongs.ToString();
            for (int i = 0; i < player.playedSongs; i++)
            {
                lstListOfSongs.Items.Add(Program.mySongs.songName[GlobalVars.songs[player.playedSongsId[i]].songDataId]);
            } 
        }

        private void PlayerDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.canOpenPlayerDetails = true;
        }

        private void lstListOfSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListOfSongs.SelectedIndex != -1)
            {
                Player player = GlobalVars.players[playerId];
                Song song = GlobalVars.songs[player.playedSongsId[lstListOfSongs.SelectedIndex]];
                lblRSongName.Text = Program.mySongs.songName[song.songDataId];
                lblRArtist.Text = Program.mySongs.songArtist[song.songDataId];
                int whichPlayer = 0;
                for (int i = 0; i < song.playersIds.Length; i++)
                {
                    if (song.playersIds[i] == player.playerId)
                        whichPlayer = i;
                }
                lblPlyr1.Text = song.instrumentToStr(song.playersInstIds[whichPlayer]) + " on " + song.difficultyToStr(song.playersDiffIds[whichPlayer]);
                lblRPercent.Text = song.percent.ToString() + "%";
                lblRStars.Text = song.stars.ToString() + "/5";
                lblRFinalScore.Text = song.songScore.ToString() + "/1000";
            }
            else
            {
                lblRSongName.ResetText();
                lblRArtist.ResetText();
                lblPlyr1.ResetText();
                lblRPercent.ResetText();
                lblRStars.ResetText();
                lblRFinalScore.ResetText();
            }
        }
    }
}