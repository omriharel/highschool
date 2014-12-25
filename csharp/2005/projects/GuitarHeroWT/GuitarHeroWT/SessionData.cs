using System;

namespace GuitarHeroWT
{
    public class SessionData
    {
        public Song[] songs;
        public Player[] players;

        public int numberOfSongs;
        public int numberOfPlayers;
        public int totalSongsPlayed = 0;
        public int totalScore = 0;
    }
}
