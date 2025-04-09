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
            //instantiates an object called deck of class Deck
            Deck deck = new Deck();
            int timesShuffled = 0;

            //different shuffle methods are commented out below to test one at a time

            //this method uses an out parameter
            //shuffles the deck 3 times and assigns the integer value to timesShuffled
            deck = Shuffle(deck, out timesShuffled, 3);

            ////this method uses a named parameter; the name of the parameter is specified in the method call
            //deck = Shuffle(deck: deck, times: 3); 

            ////calls the overload method of Shuffle and shuffles the deck 3 times
            //deck = Shuffle(deck, 3);

            foreach (Card card in deck.Cards) //for each card in the deck
            {
                Console.WriteLine(card.Face + " of " + card.Suit); //displays the face and suit of the card
            }

            Console.WriteLine(deck.Cards.Count); //displays the number of cards in the deck
            Console.WriteLine("Times shuffled: {0}", timesShuffled); //the brackets are a placeholder for the value of timesShuffled
            Console.ReadLine();
        }


        //creates a method that will shuffle the list of cards and return a shuffled deck
        //Public is an access modifier that allows the method to be called from outside the class
        //this method is static so it can be called without creating an instance of the class
        //Deck is the return data type of the method
        //the method is called Shuffle and takes a Deck object as a parameter
        //int times is an optional parameter that defaults to 1 if not specified
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            //defines a variable called timesShuffled of type int and assigns it a value of 0
            timesShuffled = 0; 

            
            for (int i = 0; i < times; i++)
            {
                timesShuffled++; //increments the number of times shuffled by one
                //creates a new 'empty' list of cards called TempList to store the shuffled cards
                List<Card> TempList = new List<Card>();
                Random random = new Random(); //creates an object called random of type Random

                //while loop will run until the deck is empty
                while (deck.Cards.Count > 0)
                {
                    //generates a random number between 0 and the number of cards in the deck
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]); //adds the card at the random index to the TempList
                    deck.Cards.RemoveAt(randomIndex); //removes the card at the random index from the deck(list of cards)
                }
                deck.Cards = TempList; //assigns the shuffled cards in TempList to the deck
            }
            return deck; //returns the shuffled deck
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