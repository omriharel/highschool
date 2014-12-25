using System;

namespace GuitarHeroWT
{
    class Song
    {
        public string name;
        public int playersNum;
        public int[] playersId;
        public int percent;
        public int stars;
        public int difficultyInt;
        public int songScore;
        public int songId;

        public string difficultyToStr
        {
            get
            {
                switch (difficultyInt)
                {
                    case 1:
                        return "Easy";
                    case 2:
                        return "Medium";
                    case 3:
                        return "Hard";
                    case 4:
                        return "Expert";
                    default:
                        return "";
                }
            }
        }
    }
}
