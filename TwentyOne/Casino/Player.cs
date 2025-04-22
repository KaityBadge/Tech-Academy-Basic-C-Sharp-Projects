using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        //Constructor chain is used to provide a default value of 100 for the beginning balance if the user does not provide one
        public Player(string name) : this(name, 100)
        {

        }
        //this constructor called Player takes two parameters (name and beginning balance)
        public Player (string name, int beginningBalance)
        {
            Hand = new List<Card>(); //creates and initializes a new/empty list of cards
            Balance = beginningBalance; //assigns a value to the balance property
            Name = name; //assigns a value to the name property
        }
        private List<Card> _hand = new List<Card>(); //creates an empty list of cards so hand is never null(its at least an empty list)
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public bool Bet (int amount) //this boolean method takes an integer parameter (amount player is betting)
        {
            if (Balance - amount < 0) //if the balance minus the betting amount is less than 0
            {
                Console.WriteLine("You do not have enough to make a bet that size");
                return false;
            }
            else
            {
                Balance -= amount; //subtract the betting amount from the balance   
                return true; //return true if the bet is successful
            }
        }

        //this plus overload operator takes two operands (game and player)
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        //This overloads the minus operator
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
