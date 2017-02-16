using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRpg
{
    class Warrior : Profession
    {
        public Warrior()
        {
            ProfessionName = "Warrior";
            ProfStats.Strength += 2;
            ProfStats.Health += 5;
            ProfStats.Mana -= 5;

        }
    }
}

