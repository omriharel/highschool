using System;

namespace GuitarHeroWT
{
    public class Song
    {
        public int[] playersIds;
        public int[] playersInstIds;
        public int[] playersDiffIds;
        public int percent;
        public int stars;
        public int songScore;
        public int songDataId;
        public int songId;

        public string difficultyToStr(int diff)
        {
            switch (diff)
            {
                case 1:
                    return "Beginner";
                case 2:
                    return "Easy";
                case 3:
                    return "Medium";
                case 4:
                    return "Hard";
                case 5:
                    return "Expert";
                default:
                    return "";
            }
        }
        public string instrumentToStr(int inst)
        {
            switch (inst)
            {
                case 1:
                    return "Guitar";
                case 2:
                    return "Bass";
                case 3:
                    return "Drums";
                case 4:
                    return "Microphone";
                default:
                    return "";
            }
        }
    }
}
