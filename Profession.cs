using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRpg
{
    class Profession
    {
        protected string ProfessionName;
        public Stats ProfStats { get; protected set; } 

        public Profession()
        {
            ProfessionName = "Villager";
            ProfStats = new Stats();

        }

        public string getProfessionName()
        {
            return ProfessionName;
        }

    }
}
