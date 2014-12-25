using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuitarHeroWT
{
    public partial class AddSong : Form
    {
        ComboBox[] nameArray;
        ComboBox[] instArray;
        ComboBox[] diffArray;

        public AddSong()
        {
            InitializeComponent();
            cmbListOfSongs.Items.Add("Select Song:");
            for (int i = 0; i < Program.mySongs.songName.Length; i++)
            {
                cmbListOfSongs.Items.Add(Program.mySongs.songName[i].ToString() + " - " + Program.mySongs.songArtist[i].ToString());
            }

            #region PlayerLists
            cmbListOfSongs.SelectedItem = cmbListOfSongs.Items[0];
            cmbPlyr1.Items.Add("Player 1:");
            for (int i = 0; i < GlobalVars.players.Length; i++)
            {
                cmbPlyr1.Items.Add(GlobalVars.players[i].name);
            }
            cmbPlyr1.SelectedItem = cmbPlyr1.Items[0];
            cmbPlyr2.Items.Add("Player 2:");
            for (int i = 0; i < GlobalVars.players.Length; i++)
            {
                cmbPlyr2.Items.Add(GlobalVars.players[i].name);
            }
            cmbPlyr2.SelectedItem = cmbPlyr2.Items[0];
            cmbPlyr3.Items.Add("Player 3:");
            for (int i = 0; i < GlobalVars.players.Length; i++)
            {
                cmbPlyr3.Items.Add(GlobalVars.players[i].name);
            }
            cmbPlyr3.SelectedItem = cmbPlyr3.Items[0];
            cmbPlyr4.Items.Add("Player 4:");
            for (int i = 0; i < GlobalVars.players.Length; i++)
            {
                cmbPlyr4.Items.Add(GlobalVars.players[i].name);
            }
            cmbPlyr4.SelectedItem = cmbPlyr4.Items[0]; 
            #endregion

            #region OtherLists
            cmbInst1.Items.AddRange(new string[] { "Instrument:", "Guitar", "Bass", "Drums", "Microphone" });
            cmbInst1.SelectedItem = cmbInst1.Items[0];
            cmbInst2.Items.AddRange(new string[] { "Instrument:", "Guitar", "Bass", "Drums", "Microphone" });
            cmbInst2.SelectedItem = cmbInst1.Items[0];
            cmbInst3.Items.AddRange(new string[] { "Instrument:", "Guitar", "Bass", "Drums", "Microphone" });
            cmbInst3.SelectedItem = cmbInst1.Items[0];
            cmbInst4.Items.AddRange(new string[] { "Instrument:", "Guitar", "Bass", "Drums", "Microphone" });
            cmbInst4.SelectedItem = cmbInst1.Items[0];
            cmbDiff1.Items.AddRange(new string[] { "Difficulty:", "Beginner", "Easy", "Medium", "Hard", "Expert" });
            cmbDiff1.SelectedItem = cmbDiff1.Items[0];
            cmbDiff2.Items.AddRange(new string[] { "Difficulty:", "Beginner", "Easy", "Medium", "Hard", "Expert" });
            cmbDiff2.SelectedItem = cmbDiff2.Items[0];
            cmbDiff3.Items.AddRange(new string[] { "Difficulty:", "Beginner", "Easy", "Medium", "Hard", "Expert" });
            cmbDiff3.SelectedItem = cmbDiff3.Items[0];
            cmbDiff4.Items.AddRange(new string[] { "Difficulty:", "Beginner", "Easy", "Medium", "Hard", "Expert" });
            cmbDiff4.SelectedItem = cmbDiff4.Items[0]; 
            #endregion

            nameArray = new ComboBox[] {cmbPlyr1, cmbPlyr2, cmbPlyr3, cmbPlyr4};
            instArray = new ComboBox[] {cmbInst1, cmbInst2, cmbInst3, cmbInst4};
            diffArray = new ComboBox[] {cmbDiff1, cmbDiff2, cmbDiff3, cmbDiff4};

            lblPercentValue.Text = trcPercent.Value + "%";
            radFourStars.Checked = true;
            radFourStars.Checked = false;
        }

        private void AddSong_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainScreen.canAddSong = true;
        }

        private void cmbListOfSongs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbListOfSongs.SelectedIndex)
            {
                case 0:
                    {
                        btnAccept.Enabled = false;
                        cmbPlyr1.Enabled = false;
                        cmbPlyr1.SelectedItem = cmbPlyr1.Items[0];
                        cmbPlyr2.Enabled = false;
                        cmbPlyr2.SelectedItem = cmbPlyr2.Items[0];
                        cmbPlyr3.Enabled = false;
                        cmbPlyr3.SelectedItem = cmbPlyr3.Items[0];
                        cmbPlyr4.Enabled = false;
                        cmbPlyr4.SelectedItem = cmbPlyr4.Items[0];
                        cmbInst1.Enabled = false;
                        cmbInst1.SelectedIndex = 0;
                        cmbInst2.Enabled = false;
                        cmbInst2.SelectedIndex = 0;
                        cmbInst3.Enabled = false;
                        cmbInst3.SelectedIndex = 0;
                        cmbInst4.Enabled = false;
                        cmbInst4.SelectedIndex = 0;
                        cmbDiff1.Enabled = false;
                        cmbDiff1.SelectedIndex = 0;
                        cmbDiff2.Enabled = false;
                        cmbDiff2.SelectedIndex = 0;
                        cmbDiff3.Enabled = false;
                        cmbDiff3.SelectedIndex = 0;
                        cmbDiff4.Enabled = false;
                        cmbDiff4.SelectedIndex = 0;
                    }
                    break;
                default:
                    {
                        cmbPlyr1.Enabled = true;
                    }
                    break;
            }
        }

        private void cmbPlyr1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbPlyr1.SelectedIndex)
            {
                case 0:
                    {
                        btnAccept.Enabled = false;
                        cmbPlyr2.Enabled = false;
                        cmbPlyr2.SelectedItem = cmbPlyr2.Items[0];
                        cmbPlyr3.Enabled = false;
                        cmbPlyr3.SelectedItem = cmbPlyr3.Items[0];
                        cmbPlyr4.Enabled = false;
                        cmbPlyr4.SelectedItem = cmbPlyr4.Items[0];
                        cmbDiff1.Enabled = false;
                        cmbInst1.Enabled = false;
                        cmbDiff2.Enabled = false;
                        cmbInst2.Enabled = false;
                        cmbDiff3.Enabled = false;
                        cmbInst3.Enabled = false;
                        cmbDiff4.Enabled = false;
                        cmbInst4.Enabled = false;
                    }
                    break;
                default:
                    {
                        btnAccept.Enabled = true;
                        cmbPlyr2.Enabled = true;
                        cmbDiff1.Enabled = true;
                        cmbInst1.Enabled = true;
                    }
                    break;
            }
        }

        private void cmbPlyr2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbPlyr2.SelectedIndex)
            {
                case 0:
                    {
                        cmbPlyr3.Enabled = false;
                        cmbPlyr3.SelectedItem = cmbPlyr3.Items[0];
                        cmbPlyr4.Enabled = false;
                        cmbPlyr4.SelectedItem = cmbPlyr4.Items[0];
                        cmbDiff2.Enabled = false;
                        cmbInst2.Enabled = false;
                        cmbDiff3.Enabled = false;
                        cmbInst3.Enabled = false;
                        cmbDiff4.Enabled = false;
                        cmbInst4.Enabled = false;
                    }
                    break;
                default:
                    {
                        cmbPlyr3.Enabled = true;
                        cmbDiff2.Enabled = true;
                        cmbInst2.Enabled = true;
                    }
                    break;
            }
        }

        private void trcPercent_ValueChanged(object sender, EventArgs e)
        {
            lblPercentValue.Text = trcPercent.Value + "%";
        }

        private void cmbPlyr3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbPlyr3.SelectedIndex)
            {
                case 0:
                    {
                        cmbPlyr4.Enabled = false;
                        cmbPlyr4.SelectedItem = cmbPlyr4.Items[0];
                        cmbDiff3.Enabled = false;
                        cmbInst3.Enabled = false;
                        cmbDiff4.Enabled = false;
                        cmbInst4.Enabled = false;
                    }
                    break;
                default:
                    {
                        cmbPlyr4.Enabled = true;
                        cmbDiff3.Enabled = true;
                        cmbInst3.Enabled = true;
                    }
                    break;
            }
        }

        private void cmbPlyr4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbPlyr3.SelectedIndex)
            {
                case 0:
                    {
                        cmbDiff4.Enabled = false;
                        cmbInst4.Enabled = false;
                    }
                    break;
                default:
                    {
                        cmbDiff4.Enabled = true;
                        cmbInst4.Enabled = true;
                    }
                    break;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool starsOk = false;
            bool multiplePlayersOk = true;
            bool playerInterCommOk = true;
            bool playerInstCommOk = true;

            if (!(!radThreeStars.Checked && !radFourStars.Checked && !radFiveStars.Checked))
                starsOk = true;

            for (int i = 0; i < nameArray.Length; i++)
            {
                for (int j = 0; j < nameArray.Length; j++)
                {
                    if (!(i == j))
                    {
                        if (nameArray[i].SelectedIndex == nameArray[j].SelectedIndex && nameArray[i].SelectedIndex != 0)
                        {
                            multiplePlayersOk = false;
                        }
                    }
                }
            }

            for (int i = 0; i < nameArray.Length; i++)
            {
                if ((nameArray[i].SelectedIndex != 0) && ((instArray[i].SelectedIndex == 0 || diffArray[i].SelectedIndex == 0)))
                {
                    playerInterCommOk = false;
                }
            }

            int activePlayersForSong = 0;
            {
                for (int i = 0; i < nameArray.Length; i++)
                {
                    if (nameArray[i].SelectedIndex == 0)
                        continue;
                    else
                        activePlayersForSong++;
                }

                if (activePlayersForSong > 1)
                {
                    for (int i = 0; i < activePlayersForSong; i++)
                    {
                        for (int j = 0; j < activePlayersForSong; j++)
                        {
                            if (!(i == j))
                            {
                                if (instArray[i].SelectedIndex == instArray[j].SelectedIndex && instArray[i].SelectedIndex != 0)
                                {
                                    playerInstCommOk = false;
                                } 
                            }
                        }
                    }  
                }
            }

            if (!(multiplePlayersOk && playerInterCommOk && playerInstCommOk && starsOk))
            {
                string reason = "The song cannot be added because your selections interfere each other in the following way(s):";
                if (!multiplePlayersOk)
                    reason += "\n   - Two or more players are trying to have the same name.";
                if (!playerInterCommOk)
                    reason += "\n   - One or more of the players does or do not have a set instrument or difficulty.";
                if (!playerInstCommOk)
                    reason += "\n   - Two or more players are trying to play the same instrument.";
                if (!starsOk)
                    reason += "\n   - You have not chosen the stars on which the song was completed";
                MessageBox.Show(this, reason, "Song cannot be added");
            }
            else
            {
                #region CheckRadio
                int stars = 0;
                if (radFiveStars.Checked)
                    stars = 5;
                else if (radFourStars.Checked)
                    stars = 4;
                else if (radThreeStars.Checked)
                    stars = 3;
                #endregion
                GlobalVars.songs[GlobalVars.totalSongsPlayed] = new Song();
                GlobalVars.songs[GlobalVars.totalSongsPlayed].songId = GlobalVars.totalSongsPlayed;
                GlobalVars.songs[GlobalVars.totalSongsPlayed].stars = stars;
                GlobalVars.songs[GlobalVars.totalSongsPlayed].percent = trcPercent.Value;
                int score = 0;
                score += stars * 50;
                score += (int)(Math.Ceiling((trcPercent.Value - 60) * 18.75));
                GlobalVars.songs[GlobalVars.totalSongsPlayed].playersIds = new int[activePlayersForSong];
                GlobalVars.songs[GlobalVars.totalSongsPlayed].playersInstIds = new int[activePlayersForSong];
                GlobalVars.songs[GlobalVars.totalSongsPlayed].playersDiffIds = new int[activePlayersForSong];
                for (int i = 0; i < activePlayersForSong; i++)
                {
                    Player player = GlobalVars.players[nameArray[i].SelectedIndex - 1];
                    player.playedSongsId[player.playedSongs] = GlobalVars.songs[GlobalVars.totalSongsPlayed].songId;
                    player.playedSongs++;
                    player.playerScore += score;
                    GlobalVars.songs[GlobalVars.totalSongsPlayed].playersIds[i] = player.playerId;
                    GlobalVars.songs[GlobalVars.totalSongsPlayed].playersInstIds[i] = instArray[i].SelectedIndex;
                    GlobalVars.songs[GlobalVars.totalSongsPlayed].playersDiffIds[i] = diffArray[i].SelectedIndex;
                }
                GlobalVars.songs[GlobalVars.totalSongsPlayed].songScore = score;
                GlobalVars.songs[GlobalVars.totalSongsPlayed].songDataId = cmbListOfSongs.SelectedIndex - 1;
                if (score <= 350)
                    MessageBox.Show(this, ("Song added successfully!\nP.S: You suck.\n" + score + " points is just lame."), "Song added");
                else
                    MessageBox.Show(this, ("Song added successfully!\nScore is " + score + "/1000 points."), "Song added");
                GlobalVars.totalScore += score;
                GlobalVars.totalSongsPlayed++;
                this.Owner.Activate();
                this.Close();
            }
        }
    }
}