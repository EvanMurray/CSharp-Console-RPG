using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRpg
{
    class Monster
    {
        public string Name { get; protected set; }
        public int ExpGiven;
        public Stats MonsterStats;

       
        public Monster(string n, int e, Stats stats)
        {
            Name = n;
            ExpGiven = e;
            MonsterStats = stats;
        }

    }
}
