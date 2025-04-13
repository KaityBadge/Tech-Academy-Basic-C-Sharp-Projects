using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new game and add a new player to it
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game += player;
            game -= player;



            //instantiates an object called deck of class Deck
            Deck deck = new Deck();

            //calls the methdod Shuffle on the deck object itself
            deck.Shuffle(3);

            //different shuffle methods are commented out below to test one at a time

            ////this method uses an out parameter
            ////shuffles the deck 3 times and assigns the integer value to timesShuffled
            //deck = Shuffle(deck, out timesShuffled, 3);

            ////this method uses a named parameter; the name of the parameter is specified in the method call
            //deck = Shuffle(deck: deck, times: 3); 

            ////calls the overload method of Shuffle and shuffles the deck 3 times
            //deck = Shuffle(deck, 3);

            foreach (Card card in deck.Cards) //for each card in the deck
            {
                Console.WriteLine(card.Face + " of " + card.Suit); //displays the face and suit of the card
            }

            Console.WriteLine(deck.Cards.Count); //displays the number of cards in the deck
            //Console.WriteLine("Times shuffled: {0}"); //the brackets are a placeholder for the value of timesShuffled
            Console.ReadLine();
        }


        
        

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    //overload method that takes a Deck object and an int as parameters
        //    //this method will shuffle the deck a specified number of times
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck); //calls the Shuffle method and assigns the shuffled deck to the deck object
        //    }
        //    return deck; //returns the shuffled deck
        //}
        
    }
}