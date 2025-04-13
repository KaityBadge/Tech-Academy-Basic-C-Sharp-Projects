using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    /// This class inherits from the Game class AND implements the IWalkAway interface
    public class TwentyOneGame : Game , IWalkAway
    {
        //override means that this method is overriding the abstract method in the base class (Game class)
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        // This method is implemented from the IWalkAway interface
        public void walkaway(Player player)
        {
           throw new NotImplementedException();
        }
    }
}
