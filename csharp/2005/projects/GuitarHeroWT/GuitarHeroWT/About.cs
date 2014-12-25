using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace GuitarHeroWT
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = "About this program";
            lblVersion.Text = Program.version;
            lblDesc.Text = "Special thanks to:\n" +
                           "- Or Dotan and Roy Ovadia for data collection and support.\n" +
                           "- YouTube.com for video clips.\n" + 
                           "- Various (too many) lyrics sites, for lyrics obviously.\n" + 
                           "- Guitar Hero: World Tour is copyright of Activision Publishing, Inc.\n" +
                           "Hope you enjoy!";
        }

        private void lnkMyTrac_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe","http://trac.assembla.com/omriharel/timeline");
        }
    }
}
