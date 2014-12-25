using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PointSystem
{
    public partial class Drawer : Form
    {
        MyPoint pt;
        int n;
        Graphics gr;
        Pen pen = new Pen(new SolidBrush(Color.Black), 1);
        float angle;

        public Drawer()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gr.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            pt = Program.pt;
            n = Program.n;
            angle = (float)((n - 2) * 180) / n;
            this.Resize += new EventHandler(Drawer_Resize);
            this.Paint += new PaintEventHandler(Drawer_Paint);
        }

        void Drawer_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        void Drawer_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 1; i <= n; i++)
            {
                gr.ResetTransform();
                gr.TranslateTransform(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2);
                gr.RotateTransform(angle * i);
                Point pt1 = new Point(pt.X, pt.Y);
                Point pt2 = new Point(pt.X, -pt.Y);
                gr.DrawLine(pen, pt1, pt2);
            }
        }
    }
}