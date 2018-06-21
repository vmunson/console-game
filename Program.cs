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
            
            Console.WriteLine("Hello, please enter your player name");

            string myName = Console.ReadLine();
            player.PlayerName = myName;

            Console.WriteLine($"Welcome, {player.PlayerName}");

            while (player.HealthPoints > 0)
            {
                
            }


        }
    }
}
