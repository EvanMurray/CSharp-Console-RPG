using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRpg
{
    class Battle
    {
        private bool isBattling;
        private Player CurrentPlayer;
        private Monster CurrentMonster;

        public Battle(Player player, Monster monster)
        {
            CurrentPlayer = player;
            CurrentMonster = monster;
            isBattling = true;
        }

        public void commenceBattle()
        {
            bool playersTurn = true;
            int input;
            Console.WriteLine("You have encountered a " + CurrentMonster.Name + "!");
            while (isBattling)
            {
                
                if (playersTurn)
                {
                    Console.WriteLine("Press 1 to attack or 2 to run away: ");
                    try
                    {
                        input = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Input: " + input);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Incorrect value. Try again. Exeception: {ex.ToString()}");
                        continue;
                    }
                    
                    switch (input)
                    {
                        case 1:
                            CurrentMonster.MonsterStats.Health -= CurrentPlayer.MyStats.Strength;
                            Console.WriteLine("You attacked the " + CurrentMonster.Name + " with a " + CurrentPlayer.EquippedWeapon.Name + " for " + CurrentPlayer.MyStats.Strength + " damage!");
                            if (CurrentMonster.MonsterStats.Health > 0)
                            {
                                Console.WriteLine("The monster is left with " + CurrentMonster.MonsterStats.Health + " health.");
                                playersTurn = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have defeated the monster!");
                                CurrentPlayer.Exp += CurrentMonster.ExpGiven;
                                Console.WriteLine("You gained " + CurrentMonster.ExpGiven + " EXP!");
                                if(CurrentPlayer.Exp >= 100)
                                {
                                    CurrentPlayer.LevelUp();
                                }
                                isBattling = false;
                                break;
                            }


                        case 2:
                            Console.WriteLine("You ran away.");
                            CurrentPlayer.RunAwayCount++;
                            isBattling = false;
                            break;
                        default:
                            Console.WriteLine("The number you entered was not a choice. Try again.");
                            continue;
                    }
                }
                else
                {
                    CurrentPlayer.MyStats.Health -= CurrentMonster.MonsterStats.Strength;
                    Console.WriteLine("The monster attacked you for " + CurrentMonster.MonsterStats.Strength + " damage!");
                    if(CurrentPlayer.MyStats.Health > 0)
                    {
                        Console.WriteLine("You are left with " + CurrentPlayer.MyStats.Health + " health.");
                        playersTurn = true;
                        
                    }
                    else
                    {
                        Console.WriteLine("You have no more Health! Game Over.");
                        isBattling = false;
                    }

                }
            }
        }
    }
}

