using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRpg
{
    class Weapon : Item
    {

        public int Damage { get; protected set; }
        
        
        
        public Weapon(string name, int damage) : base("", 1)
        {
            Name = name;
            Damage = damage;
        }
        
    }
}
