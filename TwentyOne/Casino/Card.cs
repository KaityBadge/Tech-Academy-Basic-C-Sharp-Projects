using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card //make this a struct because it is a value type and it cannot inherit or be null
    {
        public Suit Suit { get; set; } //changed from string to Suit because emun is the data type of suit
        public Face Face { get; set; } //Face Face because enum is the data type of face
        public override string ToString() //overrides the ToString method to return a string representation of the card
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
