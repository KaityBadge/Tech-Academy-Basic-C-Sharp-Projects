using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneDealer : Dealer //inherits from the Dealer class
    {
        private List<Card> _hand = new List<Card>(); //creates an empty list of cards so hand is never null(its at least an empty list)
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } 
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

    }
}
