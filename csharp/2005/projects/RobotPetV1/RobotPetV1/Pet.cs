using System;
using System.Collections.Generic;
using System.Text;

namespace RobotPetV1
{
    class Pet
    {
        #region Name Variables
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        #endregion

        #region Level Variables
        private int level;
        private int exp;
        private int[] toNextLevel = new int[]
        { 
            0, 500, 1324, 3045, 5680, 13405, 21420, 34532, 49829, 65291
        }; 
        #endregion

        #region Status Variables
        private int health, happiness, hygiene;

        const int STATUS_MAX_VALUE = 100;
        const int STATUS_MIN_VALUE = 0;

        public int Health
        {
            get { return health; }
            set
            {
                health = value;
            }
        }

        public int Happiness
        {
            get { return happiness; }
            set
            {
                happiness = value;
            }
        }

        public int Hygiene
        {
            get { return hygiene; }
            set
            {
                hygiene = value;
            }
        }
        #endregion

        public Pet(string name)
        {
            this.name = name;
            level = 1;
            exp = 0;
        }

        public void GainExp(int amount)
        {
            exp += amount;
            CheckLevelUp();
        }
        private void CheckLevelUp()
        {
            if (level <= toNextLevel.GetUpperBound(0))
            {
                if (exp >= toNextLevel[level])
                {
                    level++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations! " + Name + " has leveled up to level " + level + "!");
                    Console.ResetColor();
                    CheckLevelUp();
                }
            }
        }

        public void GainHealth(int amount)
        {
            if (Health + amount > STATUS_MAX_VALUE)
                Health = STATUS_MAX_VALUE;
            else if (Health + amount < STATUS_MIN_VALUE)
                Health = STATUS_MIN_VALUE;
            else
                Health += amount;
        }
        public void SetHealth(int amount)
        {
            if (Health + amount > STATUS_MAX_VALUE)
                Health = STATUS_MAX_VALUE;
            else if (Health + amount < STATUS_MIN_VALUE)
                Health = STATUS_MIN_VALUE;
            else
                Health = amount;
        }
        public void GainHappiness(int amount)
        {
            if (Happiness + amount > STATUS_MAX_VALUE)
                Happiness = STATUS_MAX_VALUE;
            else if (Happiness + amount < STATUS_MIN_VALUE)
                Happiness = STATUS_MIN_VALUE;
            else
                Happiness += amount;
        }
        public void SetHappiness(int amount)
        {
            if (Happiness + amount > STATUS_MAX_VALUE)
                Happiness = STATUS_MAX_VALUE;
            else if (Happiness + amount < STATUS_MIN_VALUE)
                Happiness = STATUS_MIN_VALUE;
            else
                Happiness = amount;
        }
        public void GainHygiene(int amount)
        {
            if (Hygiene + amount > STATUS_MAX_VALUE)
                Hygiene = STATUS_MAX_VALUE;
            else if (Hygiene + amount < STATUS_MIN_VALUE)
                Hygiene = STATUS_MIN_VALUE;
            else
                Hygiene += amount;
        }
        public void SetHygiene(int amount)
        {
            if (Hygiene + amount > STATUS_MAX_VALUE)
                Hygiene = STATUS_MAX_VALUE;
            else if (Hygiene + amount < STATUS_MIN_VALUE)
                Hygiene = STATUS_MIN_VALUE;
            else
                Hygiene = amount;
        }
    }
}
