using System;
using System.Windows.Forms;

namespace PointSystem
{
    class Program
    {
        public static int n;
        public static MyPoint pt = new MyPoint();

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            pt = new MyPoint();
            pt.X = 200;
            pt.Y = 200;
            Drawer dr = new Drawer();
            dr.ShowDialog();
        }
    }
}
