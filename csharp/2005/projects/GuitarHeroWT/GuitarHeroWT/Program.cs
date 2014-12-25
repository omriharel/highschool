using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GuitarHeroWT
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string version = "v1.2";
        public static SongData mySongs = new SongData();
        public static bool canOpenPlayerDetails = true, canOpenSongDetails = true;

        [STAThreadAttribute]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form start = new Start();
            start.ShowDialog();
            while (start.Created) {}
            Form playerSetup = new PlayerSetup();
            playerSetup.ShowDialog();
            while (playerSetup.Created) {}
            Application.Run(new MainScreen());
        }
    }
}