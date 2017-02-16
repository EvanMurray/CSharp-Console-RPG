using System;
using System.Collections.Generic;
namespace myRpg
{
    class Player
    {
        public string Name {get; set;}
        public Profession Prof { get; set; }
        public int Exp { get; set; }
        public int Level { get; private set; } = 1;
        public Stats MyStats { get; private set; }
        public List<Item> Inventory { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public bool HasWeaponEquipped { get; set; }
        public int RunAwayCount { get; set; }
        
      


        public Player()
        {
            Name = "";
            Prof = new Profession();
            Inventory = new List<Item>();
            

        }
        

        public void AddToInventory(Item item)
        {
            Inventory.Add(item);
        }


        public void UpdateStats()
        {
            MyStats = Prof.ProfStats;
            if (EquippedWeapon != null)
            {
                if (HasWeaponEquipped)
                {
                    MyStats.Strength += EquippedWeapon.Damage;
                }
            }
        }

       
          
        

    public void LevelUp()
        {
           
           
            bool levelUp = true;
     
            while (levelUp)
            {

                Level += 1;
                Console.WriteLine("You leveled up to level "+ Level + "!");
                
                Exp -= 100;
                if (Exp >= 100)
                {
                    continue;
                }
                else
                {
                    levelUp = false;
                }

            }
            
        }

    }
}
