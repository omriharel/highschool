using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuitarHeroWT
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.Text = "Guitar Hero World Tour Score Manager " + Program.version;
            lblCurPlyrs.Text = "There are currently " + GlobalVars.numberOfPlayers + " players.";
            lblCurSongs.Text = "So far, " + GlobalVars.totalSongsPlayed + " songs have been played.";
            GlobalVars.updateTotalScore();
            lblTotScore.Text = "Total score is currently " + GlobalVars.totalScore + " points.";
        }
    }
}
