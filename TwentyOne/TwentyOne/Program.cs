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
            deck = Shuffle(deck); //calls the Shuffle method and assigns the shuffled deck to the deck object

            foreach (Card card in deck.Cards) //for each card in the deck
            {
                Console.WriteLine(card.Face + " of " + card.Suit); //displays the face and suit of the card
            }

            Console.WriteLine(deck.Cards.Count); //displays the number of cards in the deck
            Console.ReadLine();
        }


        //creates a method that will shuffle the list of cards and return a shuffled deck
        //Public is an access modifier that allows the method to be called from outside the class
        //this method is static so it can be called without creating an instance of the class
        //Deck is the return data type of the method
        //the method is called Shuffle and takes a Deck object as a parameter
        public static Deck Shuffle(Deck deck)
        {
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
            return deck; //returns the shuffled deck
        }
        
    }
}