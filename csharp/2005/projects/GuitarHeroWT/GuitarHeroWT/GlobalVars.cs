using System;

namespace GuitarHeroWT
{
    class GlobalVars
    {
        public static Song[] songs;
        public static Player[] players;

        public const int maxPlayers = 10;
        public const int minPlayers = 1;
        public const int minSongs = 1;
        public const int maxSongs = 100;

        public static int numberOfSongs;
        public static int numberOfPlayers;
        public static int totalSongsPlayed = 0;
        public static int totalScore = 0;
    }
}
