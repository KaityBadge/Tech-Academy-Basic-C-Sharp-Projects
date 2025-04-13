using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //abstract means that this class cannot be instantiated, it can only be inherited from, it is not an object
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //abstract method can only be used in an abstract class, it is a placeholder for a method that MUST be implemented in a derived class
        public abstract void Play();

        //virtual methods have implementation in the base class (this class)
        //virtual methods gets inherited by the derived class, but it can also be overridden in the derived class
        public virtual void ListPlayers()
        {
            Console.WriteLine("Players in the game:");
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
