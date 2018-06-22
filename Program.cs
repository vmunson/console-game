using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            RedMage enemyOne = new RedMage();
            GreenBeast enemyTwo = new GreenBeast();
            BlueDragon enemyThree = new BlueDragon();
            
            Console.WriteLine("Hello, please enter your player name");

            string myName = Console.ReadLine();
            player.PlayerName = myName;

            Console.WriteLine($"Welcome, {player.PlayerName}");

            player.HealthPoints = 100;
            player.Heal = true;
            enemyOne.HealthPoints = 50;
            enemyTwo.HealthPoints = 75;
            enemyThree.HealthPoints = 100;

            while (player.HealthPoints > 0)
            {
                if(player.Heal && player.HealthPoints >= 1 && player.HealthPoints <= 10)
                {
                    Console.WriteLine("Would you like to use a one time heal?");
                    string result = Console.ReadLine();
                    if(result.ToLower() == "yes")
                    {
                        player.PlayerHeal();
                        Console.WriteLine($"Your health has increased to {player.HealthPoints}");
                    }
                }
                
                player.PlayerAttack();
                if(enemyOne.HealthPoints > 0)
                {
                    Console.WriteLine($"You have attacked Red Mage for {player.AttackPoints}");
                    enemyOne.EnemyHealth(enemyOne.HealthPoints, player.AttackPoints);
                    Console.WriteLine($"Red Mage now has {enemyOne.HealthPoints}HP");
                }
                else if(enemyTwo.HealthPoints > 0)
                {
                    Console.WriteLine($"You have attacked Green Beast for {player.AttackPoints}");
                    enemyOne.EnemyHealth(enemyTwo.HealthPoints, player.AttackPoints);
                    Console.WriteLine($"Green Beast now has {enemyTwo.HealthPoints}HP");
                }
                else if(enemyThree.HealthPoints > 0)
                {
                    Console.WriteLine($"You have attacked Blue Dragon for {player.AttackPoints}");
                    enemyOne.EnemyHealth(enemyThree.HealthPoints, player.AttackPoints);
                    Console.WriteLine($"Blue Dragon now has {enemyThree.HealthPoints}HP");
                }
                player.HealthPoints = player.HealthPoints - 10;
            }


        }
    }
}
