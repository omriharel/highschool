using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace my_calculator
{
    public partial class myCalculator : Form
    {
        double number1, number2;

        public myCalculator()
        {
            InitializeComponent();
        }

        private void lnkCopyright2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://trac.assembla.com/omriharel/timeline");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lowerIcon.Dispose();
            Close();
        }

        public bool checkInput()
        {
            bool ok = true;
            try
            {
                number1 = double.Parse(this.txtNumber1.Text);
                number2 = double.Parse(this.txtNumber2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("One or more of your inputs are illegal. Please try again.", "Format Exception");
                ok = false;
            }
            return ok;
        }

        public void calculate(int mode)
        {
            switch (mode)
            {
                case 1:
                    {
                        this.lblResult.Text = number1 + " + " + number2 + " = " + (number1 + number2);
                    }
                    break;
                case 2:
                    {
                        this.lblResult.Text = number1 + " - " + number2 + " = " + (number1 - number2);
                    }
                    break;
                case 3:
                    {
                        this.lblResult.Text = number1 + " x " + number2 + " = " + (number1 * number2);
                    }
                    break;
                case 4:
                    {
                        this.lblResult.Text = number1 + " ÷ " + number2 + " = " + (number1 / number2);
                    }
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInput())
                calculate(1);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInput())
                calculate(1);
        }

        private void substractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInput())
                calculate(2);
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            if (checkInput())
                calculate(2);
        }

        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInput())
                calculate(3);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (checkInput())
                calculate(3);
        }

        private void divideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInput())
                calculate(4);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (checkInput())
                calculate(4);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNumber1.Text = "";
            this.txtNumber2.Text = "";
            this.lblResult.Text = "";
        }

        private void trcOpacity_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = trcOpacity.Value * 0.01;
        }
    }
}