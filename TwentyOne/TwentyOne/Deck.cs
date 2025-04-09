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
    }
}
