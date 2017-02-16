using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRpg
{
    class Stats
    {
        public int Strength { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public Stats()
        {
            Strength = 1;
            Health = 10;
            Mana = 10;
        }

        public Stats(int str, int hp, int mp)
        {
            Strength = str;
            Health = hp;
            Mana = mp;
        }
        
    }
}
