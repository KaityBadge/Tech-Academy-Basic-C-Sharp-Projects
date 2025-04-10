using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //constructor; default values for object if none are assigned
        //this is a method that is called as soon as the object is created
        public Deck()
        {
            //instantiates it's property Cards as a new 'empty' list
            Cards = new List<Card>(); 
            //creates a list and instantiates is with values (suits)
            List<string> Suits = new List<string>() { "Hearts", "Diamonds", "Clubs", "Spades" };

            //create another list for the faces of the cards
            List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            //loop through the suits and faces lists to create a deck of 52 cards
            //create a nested for loop
            foreach (string face in Faces) //for each face in Faces list
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //create a new card
                    card.Suit = suit; //assign the suit to the card
                    card.Face = face; //assign the face to the card 
                    Cards.Add(card); //add the card to the empty list created above called Cards
                }
            }
        }

        // Gives the Deck class a public property of type List<Card> (list of cards)    
        public List<Card> Cards { get; set; }

        //creates a method that will shuffle the list of cards and return a shuffled deck
        //Public is an access modifier that allows the method to be called from outside the class
        //this method is static so it can be called without creating an instance of the class
        //Deck is the return data type of the method
        //the method is called Shuffle and takes a Deck object as a parameter
        //int times is an optional parameter that defaults to 1 if not specified
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                //creates a new 'empty' list of cards called TempList to store the shuffled cards
                List<Card> TempList = new List<Card>();
                Random random = new Random(); //creates an object called random of type Random

                //while loop will run until the deck is empty
                while (Cards.Count > 0)
                {
                    //generates a random number between 0 and the number of cards in the deck
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]); //adds the card at the random index to the TempList
                    Cards.RemoveAt(randomIndex); //removes the card at the random index from the deck(list of cards)
                }
                Cards = TempList; //assigns the shuffled cards in TempList to the deck
            }
        }
    }
}
