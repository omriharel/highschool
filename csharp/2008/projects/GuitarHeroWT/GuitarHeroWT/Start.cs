using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuitarHeroWT
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.Text = "Player Setup";
            numOfPlayers.Maximum = GlobalVars.maxPlayers;
            numOfPlayers.Minimum = GlobalVars.minPlayers;
            numOfSongs.Maximum = GlobalVars.maxSongs;
            numOfSongs.Minimum = GlobalVars.minSongs;
        }

        private void btnStartOk_Click(object sender, EventArgs e)
        {
            GlobalVars.numberOfPlayers = (int) numOfPlayers.Value;
            GlobalVars.numberOfSongs = (int) numOfSongs.Value;
            GlobalVars.songs = new Song[GlobalVars.numberOfPlayers, GlobalVars.numberOfSongs];
            GlobalVars.players = new Player[GlobalVars.numberOfPlayers];
            this.Dispose();
        }
    }
}