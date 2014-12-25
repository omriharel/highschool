using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace colorPicker
{
    public partial class Picker : Form
    {
        SolidBrush myBrush = new SolidBrush(Color.Black);
        Rectangle myRect = new Rectangle(244, 23, 60, 60);

        public Picker()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(f1_paint);
        }

        private void trcRed_ValueChanged(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(Color.FromArgb(trcRed.Value, myBrush.Color.G, myBrush.Color.B));
            this.CreateGraphics().FillRectangle(myBrush, myRect);
            lblRedVal.Text = trcRed.Value.ToString();
            lblHex.Text = "Hexadecimal: #" + toHex(Color.FromArgb(trcRed.Value, myBrush.Color.G, myBrush.Color.B));
        }

        private void f1_paint(object sender, PaintEventArgs e)
        {
            Graphics myGr = this.CreateGraphics();
            Pen myPen = new Pen(Color.Black, 2);
            myGr.DrawRectangle(myPen, myRect);
            myGr.FillRectangle(myBrush, myRect);
        }

        private void trcBlue_ValueChanged(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(Color.FromArgb(myBrush.Color.R, myBrush.Color.G, trcBlue.Value));
            this.CreateGraphics().FillRectangle(myBrush, myRect);
            lblBlueVal.Text = trcBlue.Value.ToString();
            lblHex.Text = "Hexadecimal: #" + toHex(Color.FromArgb(myBrush.Color.R, myBrush.Color.G, trcBlue.Value));
        }

        private void trcGreen_ValueChanged(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(Color.FromArgb(myBrush.Color.R, trcGreen.Value, myBrush.Color.B));
            this.CreateGraphics().FillRectangle(myBrush, myRect);
            lblGreenVal.Text = trcGreen.Value.ToString();
            lblHex.Text = "Hexadecimal: #" + toHex(Color.FromArgb(myBrush.Color.R, trcGreen.Value, myBrush.Color.B));
        }

        private void trcOpacity_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = trcOpacity.Value * 0.01;
        }

        private void lnkCopyright2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://trac.assembla.com/omriharel/timeline");
        }

        public string toHex(Color myCol)
        {
            int[] rgb = new int[3];
            rgb[0] = myCol.R;
            rgb[1] = myCol.G;
            rgb[2] = myCol.B;
            string hexChars = "0123456789ABCDEF";
            string hexValue = "";
            for (int i = 0; i < 3; i++)
            {
                char j, k;
                j = hexChars[(rgb[i] / 16)];
                k = hexChars[(rgb[i] % 16)];
                hexValue += j;
                hexValue += k;
            }
            return hexValue;
        }
    }
}