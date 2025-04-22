using System;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino"; //constant string for the casino name
            Console.WriteLine("Welcome to the {0}! What is your name?" , casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("Hello " + playerName + "! How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great! You have " + bank + " dollars. Would you like to play a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower(); 
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "yep")
            {
                Player player = new Player (playerName, bank);
                Game game = new TwentyOneGame(); //polymorphism, the game variable is of type Game but it is assigned an object of type TwentyOneGame
                game += player; //this is the overloaded operator that adds a player to the game
                player.isActivelyPlaying = true; 
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
            
        }        
    }
}