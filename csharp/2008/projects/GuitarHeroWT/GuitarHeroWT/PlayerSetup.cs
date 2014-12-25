using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuitarHeroWT
{
    public partial class PlayerSetup : Form
    {
        int counter = 0;

        public PlayerSetup()
        {
            InitializeComponent();
            prgPlayerNames.Minimum = 0;
            prgPlayerNames.Maximum = GlobalVars.numberOfPlayers * 20;
            lblPlyrNamePrg.Text = "1/" + GlobalVars.numberOfPlayers;
        }

        private void btnAddPlyr_Click(object sender, EventArgs e)
        {
            if (counter < GlobalVars.numberOfPlayers)
            {
                counter++;
                if (txtPlyrName.Text == "")
                {
                    MessageBox.Show("Please enter a name for player number " + counter + ".");
                    counter--;
                }
                else
                {
                    prgPlayerNames.Value = counter * 20;
                    GlobalVars.players[counter - 1] = new Player();
                    GlobalVars.players[counter - 1].name = txtPlyrName.Text;
                    GlobalVars.players[counter - 1].playerId = counter - 1;
                    GlobalVars.players[counter - 1].playedSongs = 0;
                    GlobalVars.players[counter - 1].playerScore = 0;
                    GlobalVars.players[counter - 1].playedSongsId = new int[GlobalVars.numberOfSongs];
                    txtPlyrName.Clear();
                    if (counter < GlobalVars.numberOfPlayers)
                        lblPlyrNamePrg.Text = (counter + 1) + "/" + GlobalVars.numberOfPlayers;
                    else
                        this.Dispose();
                    txtPlyrName.Focus();
                }
            }
            else
            {
                this.Dispose();
            }
        }
    }
}