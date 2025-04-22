using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //gets the first card from the deck and adds it to the player's hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card); //prints what card was dealt
            using (StreamWriter file = new StreamWriter(@"C:\Users\kaity\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now); //writes the current date and time to the log file for when the card is dealt
                file.WriteLine(card); //writes the card dealt to the log file
            }
            Deck.Cards.RemoveAt(0); //removes the first card from the deck
        }
    }
}
