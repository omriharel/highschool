using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace GuitarHeroWT
{
    public partial class MainScreen : Form
    {
        public static bool canShowDatabase = true;
        public static bool canShowResults = true;
        public static bool canAddSong = true;

        public MainScreen()
        {
            InitializeComponent();
            this.Text = "GH: World Tour Score Manager " + Program.version;
        }

        private void updateLabels(object sender, EventArgs e)
        {
            if (GlobalVars.numberOfPlayers == 1)
                lblCurPlyrs.Text = "There is currently one player.";
            else
                lblCurPlyrs.Text = "There are currently " + GlobalVars.numberOfPlayers + " players.";
            if (GlobalVars.totalSongsPlayed == 1)
                lblCurSongs.Text = "So far, one song has been played.";
            else if (GlobalVars.totalSongsPlayed == 0)
                lblCurSongs.Text = "No songs have been played yet.";
            else
                lblCurSongs.Text = "So far, " + GlobalVars.totalSongsPlayed + " songs have been played.";
            lblTotScore.Text = "Total score is currently " + GlobalVars.totalScore + " points.";
        }

        private void btnSongDb_Click(object sender, EventArgs e)
        {
            if (canShowDatabase)
            {
                Form songDatabase = new SongDatabase();
                songDatabase.Show();
                canShowDatabase = false;
            }
        }

        private void btnDispResults_Click(object sender, EventArgs e)
        {
            if (canShowResults && GlobalVars.totalSongsPlayed > 0)
            {
                Form displayResults = new DisplayResults();
                displayResults.Show();
                canShowResults = false;
            }
            else if (canShowResults && GlobalVars.totalSongsPlayed <= 0)
            {
                MessageBox.Show(this, "No results can be displayed yet, play a song first.", "Cannot display results");
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (GlobalVars.totalSongsPlayed < GlobalVars.numberOfSongs)
            {
                if (canAddSong)
                {
                    Form addSong = new AddSong();
                    addSong.Show(this);
                    canAddSong = false;
                }
            }
            else
                MessageBox.Show(this, "You have already played the maximal number of songs you have declared.", "Cannot add more songs");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.ShowDialog();
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveLog = new SaveFileDialog();
            saveLog.AddExtension = true;
            saveLog.Title = "Save log in:";
            saveLog.DefaultExt = "txt";
            saveLog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveLog.Filter = "Text Files|*.txt|All Files|*.*";
            saveLog.FileName = "GHWT_log";
            Stream log;
            if (saveLog.ShowDialog() == DialogResult.OK)
            {
                if ((log = saveLog.OpenFile()) != null)
                {
                    StreamWriter sw = new StreamWriter(log);
                    sw.WriteLine("----- Guitar Hero: World Tour Score Manager " + Program.version + " log file -----");
                    sw.WriteLine("This log file had been automatically generated.");
                    string time = System.DateTime.Now.DayOfWeek.ToString().Substring(0,3) + ", ";
                    time += System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/";
                    time += System.DateTime.Now.Year.ToString().Substring(2, 2) + " - ";
                    TimeSpan myTime = System.DateTime.Now.TimeOfDay;
                    time += myTime.ToString().Substring(0,8) + ".";
                    sw.WriteLine("Time: " + time);
                    sw.WriteLine("-------------------------------------------------------------------------");
                    sw.WriteLine("--- GENERAL STATISTICS ---");
                    sw.WriteLine("Total players: " + GlobalVars.numberOfPlayers);
                    sw.WriteLine("Total songs played: " + GlobalVars.totalSongsPlayed + "/" + GlobalVars.numberOfSongs);
                    sw.WriteLine("Total points gained: " + GlobalVars.totalScore);
                    sw.WriteLine("-------------------------------------------------------------------------");
                    sw.WriteLine("--- PLAYER STATISTICS ---");
                    foreach (Player player in GlobalVars.players)
                    {
                        sw.WriteLine("   - " + player.name + " - Played " + player.playedSongs + " song(s). Player score: " + player.playerScore);
                    }
                    sw.WriteLine("-------------------------------------------------------------------------");
                    sw.WriteLine("--- SONG STATISTICS ---");
                    if (GlobalVars.totalSongsPlayed > 0)
                    {
                        for (int i = 0; i < GlobalVars.totalSongsPlayed; i++)
                        {
                            Song song = GlobalVars.songs[i];
                            sw.WriteLine("   - " + (song.songId + 1) + ". " + Program.mySongs.songName[song.songDataId] + ":");
                            sw.WriteLine("      Artist: " + Program.mySongs.songArtist[song.songDataId]);
                            sw.WriteLine("      Played by:");
                            for (int j = 0; j < song.playersIds.Length; j++)
                            {
                                sw.WriteLine("         " + (j + 1) + ". " +
                                    GlobalVars.players[song.playersIds[j]].name + " - " +
                                    song.instrumentToStr(song.playersInstIds[j]) + " on " +
                                    song.difficultyToStr(song.playersDiffIds[j]));
                            }
                            sw.WriteLine("      Stars: " + song.stars + "/5");
                            sw.WriteLine("      Percent: " + song.percent + "%");
                            sw.WriteLine("      Final Score: " + song.songScore + "/1000");
                            if (song.songId < (GlobalVars.totalSongsPlayed - 1))
                                sw.WriteLine();
                        }
                    }
                    else
                        sw.WriteLine("No songs have been played.");
                    sw.Close();
                    log.Close();
                }
            }
        }

        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveSession = new SaveFileDialog();
            saveSession.AddExtension = true;
            saveSession.Title = "Save session in:";
            saveSession.DefaultExt = "xml";
            saveSession.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveSession.Filter = "XML File|*.xml";
            saveSession.FileName = "GHWT_session";
            Stream session;
            if (saveSession.ShowDialog() == DialogResult.OK)
            {
                if ((session = saveSession.OpenFile()) != null)
                {
                    SessionData sd = new SessionData();
                    sd.songs = GlobalVars.songs;
                    sd.players = GlobalVars.players;
                    sd.numberOfPlayers = GlobalVars.numberOfPlayers;
                    sd.numberOfSongs = GlobalVars.numberOfSongs;
                    sd.totalScore = GlobalVars.totalScore;
                    sd.totalSongsPlayed = GlobalVars.totalSongsPlayed;
                    StreamWriter sw = new StreamWriter(session);
                    XmlSerializer xmlSerializer = new XmlSerializer(sd.GetType());
                    xmlSerializer.Serialize(sw, sd);
                    sw.Close();
                    session.Close();
                }
            }
        }

        private void btnLoadSession_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadSession = new OpenFileDialog();
            loadSession.Title = "Load session from:";
            loadSession.Filter = "XML Files|*.xml";
            loadSession.AddExtension = true;
            loadSession.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Stream session;
            if (loadSession.ShowDialog() == DialogResult.OK)
            {
                if ((session = loadSession.OpenFile()) != null)
                {
                    SessionData sd = new SessionData();
                    StreamReader sr = new StreamReader(session);
                    XmlSerializer xmlSerializer = new XmlSerializer(sd.GetType());
                    sd = (SessionData)xmlSerializer.Deserialize(sr);
                    GlobalVars.songs = sd.songs;
                    GlobalVars.players = sd.players;
                    GlobalVars.numberOfPlayers = sd.numberOfPlayers;
                    GlobalVars.numberOfSongs = sd.numberOfSongs;
                    GlobalVars.totalScore = sd.totalScore;
                    GlobalVars.totalSongsPlayed = sd.totalSongsPlayed;
                    sr.Close();
                    session.Close();
                    updateLabels(null, null);
                }
            }
        }
    }
}
