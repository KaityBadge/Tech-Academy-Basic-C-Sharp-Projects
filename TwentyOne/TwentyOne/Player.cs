using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }

        public bool isActivelyPlaying { get; set; }

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
