using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    interface IWalkAway
    {
        //all interfaces are public, no need to specify it
        //this is implemented in the TwentyOneGame class
        //void is a return type, it means that this method does not return anything
        void WalkAway(Player player);
    }
}
