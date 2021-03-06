using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuitarHeroSim
{
    public partial class MainScreen : Form
    {
        Rectangle rGreen = new Rectangle(20, 120, 68, 68);
        Rectangle rRed = new Rectangle(105, 120, 68, 68);
        Rectangle rYellow = new Rectangle(190, 120, 68, 68);
        Rectangle rBlue = new Rectangle(275, 120, 68, 68);
        Rectangle rOrange = new Rectangle(360, 120, 68, 68);
        SolidBrush bGreen = new SolidBrush(Color.FromArgb(255, 0, 255, 0));
        SolidBrush bRed = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
        SolidBrush bYellow = new SolidBrush(Color.FromName("Yellow"));
        SolidBrush bBlue = new SolidBrush(Color.FromArgb(255, 0, 0, 255));
        SolidBrush bOrange = new SolidBrush(Color.FromName("Orange"));
        SolidBrush bg = new SolidBrush(Color.Empty);
        Pen line = new Pen(Color.Black, 2);
        Graphics gr;
        Keys kGreen = Keys.D, kRed = Keys.F, kYellow = Keys.G,
            kBlue = Keys.H, kOrange = Keys.J;
        public MainScreen()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(MainScreen_MouseDown);
            this.MouseUp += new MouseEventHandler(MainScreen_MouseUp);
            this.KeyDown += new KeyEventHandler(MainScreen_KeyDown);
            this.KeyUp += new KeyEventHandler(MainScreen_KeyUp);
            bg.Color = this.BackColor;
            gr = this.CreateGraphics();
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Paint += new PaintEventHandler(MainScreen_Paint);
            this.Paint += new PaintEventHandler(MainScreen_PaintString);
        }

        void MainScreen_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        gr.FillRectangle(bg, new Rectangle(219, 60, 30, 55));
                    }
                    break;
                case MouseButtons.Right:
                    {
                        gr.FillRectangle(bg, new Rectangle(249, 60, 35, 55));
                    }
                    break;
            }
        }

        void MainScreen_PaintString(object sender, PaintEventArgs e)
        {
            gr.DrawString("Strum:", new Font("Tahoma", 24, FontStyle.Regular),
                new SolidBrush(Color.Black), new PointF(115.0f, 65.0f));
            gr.DrawString("Backspace to smooth graphics.", new Font("Arial", 8, FontStyle.Bold),
                new SolidBrush(Color.Black), new PointF(2.0f, 2.0f));
        }

        void MainScreen_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        gr.DrawString("↓", new Font("Arial", 30, FontStyle.Bold),
                new SolidBrush(Color.DarkViolet), new PointF(210.0f, 65.0f));
                    }
                    break;
                case MouseButtons.Right:
                    {
                        gr.DrawString("↑", new Font("Arial", 30, FontStyle.Bold),
                new SolidBrush(Color.DarkViolet), new PointF(240.0f, 65.0f));
                    }
                    break;
            }
        }

        void MainScreen_Paint(object sender, PaintEventArgs e)
        {
            gr.DrawEllipse(line, rGreen);
            gr.DrawEllipse(line, rRed);
            gr.DrawEllipse(line, rYellow);
            gr.DrawEllipse(line, rBlue);
            gr.DrawEllipse(line, rOrange);
        }

        void MainScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == kGreen)
                    gr.FillEllipse(bg, rGreen);
            if (e.KeyData == kRed)
                    gr.FillEllipse(bg, rRed);
            if (e.KeyData == kYellow)
                    gr.FillEllipse(bg, rYellow);
            if (e.KeyData == kBlue)
                    gr.FillEllipse(bg, rBlue);
            if (e.KeyData == kOrange)
                    gr.FillEllipse(bg, rOrange);
            MainScreen_Paint(null, null);
        }

        void MainScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == kGreen)
                gr.FillEllipse(bGreen, rGreen);
            if (e.KeyData == kRed)
                gr.FillEllipse(bRed, rRed);
            if (e.KeyData == kYellow)
                gr.FillEllipse(bYellow, rYellow);
            if (e.KeyData == kBlue)
                gr.FillEllipse(bBlue, rBlue);
            if (e.KeyData == kOrange)
                gr.FillEllipse(bOrange, rOrange);
            if (e.KeyData == Keys.Back)
                this.Refresh();
            MainScreen_Paint(null, null);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            btnGreen.KeyDown += new KeyEventHandler(green_KeyDown);
        }

        void green_KeyDown(object sender, KeyEventArgs e)
        {
            Button myB = (Button)sender;
            myB.Text = e.KeyData.ToString();
            if (e.KeyData != Keys.Back)
                kGreen = e.KeyData;
            btnGreen.Enabled = false;
            btnGreen.Enabled = true;
            btnGreen.KeyDown -= new KeyEventHandler(green_KeyDown);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            btnRed.KeyDown += new KeyEventHandler(red_KeyDown);
        }

        void red_KeyDown(object sender, KeyEventArgs e)
        {
            Button myB = (Button)sender;
            myB.Text = e.KeyData.ToString();
            if (e.KeyData != Keys.Back)
                kRed = e.KeyData;
            btnRed.Enabled = false;
            btnRed.Enabled = true;
            btnRed.KeyDown -= new KeyEventHandler(red_KeyDown);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            btnYellow.KeyDown += new KeyEventHandler(yellow_KeyDown);
        }

        void yellow_KeyDown(object sender, KeyEventArgs e)
        {
            Button myB = (Button)sender;
            myB.Text = e.KeyData.ToString();
            if (e.KeyData != Keys.Back)
                kYellow = e.KeyData;
            btnYellow.Enabled = false;
            btnYellow.Enabled = true;
            btnYellow.KeyDown -= new KeyEventHandler(yellow_KeyDown);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            btnBlue.KeyDown += new KeyEventHandler(blue_KeyDown);
        }
        
        void blue_KeyDown(object sender, KeyEventArgs e)
        {
            Button myB = (Button)sender;
            myB.Text = e.KeyData.ToString();
            if (e.KeyData != Keys.Back)
                kBlue = e.KeyData;
            btnBlue.Enabled = false;
            btnBlue.Enabled = true;
            btnBlue.KeyDown -= blue_KeyDown;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            btnOrange.KeyDown += new KeyEventHandler(orange_KeyDown);
        }

        void orange_KeyDown(object sender, KeyEventArgs e)
        {
            Button myB = (Button)sender;
            myB.Text = e.KeyData.ToString();
            if (e.KeyData != Keys.Back)
                kOrange = e.KeyData;
            btnOrange.Enabled = false;
            btnOrange.Enabled = true;
            btnOrange.KeyDown -= new KeyEventHandler(orange_KeyDown);
        }
    }
}