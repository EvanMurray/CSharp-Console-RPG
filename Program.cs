using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRpg
{
    class Program
    {
        static void Main()
        {
            Player player = new Player();

            retrieveName(player);

            player.Prof = new Warrior();
            player.UpdateStats();
            
            Item potion = new Item("Potion" , 1);

            Item sword = new Weapon("Sword", 1);

            player.EquippedWeapon = (Weapon)sword;
            player.HasWeaponEquipped = true;

            player.UpdateStats();
            
            
            Monster goblin = new Monster("Goblin", 101, new Stats(2, 15, 0));
            Battle firstBattle = new Battle(player, goblin);
            firstBattle.commenceBattle();

        }

        public static Player retrieveName(Player p)
        {
            while (true)
            {
                Console.WriteLine("Please enter in your name: ");

                p.Name = Console.ReadLine();
                if (!(string.IsNullOrEmpty(p.Name)))
                {
                    return p;
                }
                else
                {
                    Console.WriteLine("Please make sure you entered your name!");
                    continue;
                }
            }
        }

       
    }
}
