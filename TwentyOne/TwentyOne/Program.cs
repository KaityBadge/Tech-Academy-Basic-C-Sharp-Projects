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

            //fixes the unhandled exception if the user enters a string instead of an integer for the bank amount
            bool validAnswer = false; // this variable is used to check if the answer is valid
            int bank = 0; 
            while (!validAnswer) //while the answer is not valid
            {
                Console.WriteLine("Hello {0}, how much money did you bring today?", playerName);
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //tryparse casts input from string to int and assigns it to the bank variable
                if (!validAnswer) //if the input is still not a valid integer
                {
                    Console.WriteLine("Please enter digits only, no decimals or symbols.");
                }
            }


            Console.WriteLine("Hello, {0}. Would you like to play a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower(); 
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "yep" || answer == "yea")
            {
                Player player = new Player (playerName, bank);
                Game game = new TwentyOneGame(); //polymorphism, the game variable is of type Game but it is assigned an object of type TwentyOneGame
                game += player; //this is the overloaded operator that adds a player to the game
                player.isActivelyPlaying = true; 
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security is here! You are kicked out for fraudulent behavior.");
                        Console.ReadLine();
                        return; //exits the program if this error occurs
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        Console.ReadLine();
                        return; //exits the program if this error occurs
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
            
        }        
    }
}