using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //gets the first card from the deck and adds it to the player's hand
            Hand.Add(Deck.Cards.First());
            //prints what card was dealt
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            //removes the first card from the deck
            Deck.Cards.RemoveAt(0);
        }
    }
}
