using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    class TwentyOneRules
    {
        //creates a dictionary of all the cards and their values
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        public static int[] GetAllPossibleValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); //uses lambda expression to check if card face is an Ace
            int[] result = new int[aceCount + 1]; //creates an array of integers with a size of aceCount + 1
            int value = Hand.Sum(x => _cardValues[x.Face]); //sums the values of the cards in the hand using the _cardValues dictionary
            result[0] = value; //sets the first index of the array to the value of the hand
            if (result.Length == 1) //if there are no aces in the hand
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++) //starting at 1 because the first result [0] is already set
            {
                value += (i * 10); //value is the lowest possible value, for each ace, add 10 to the value
                result[i] = value; //sets the index of the array to the value of the hand
            }
            return result; //returns the array of all possible end values
        }



        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleValues(Hand);
            int value = possibleValues.Max(); //gets the maximum possible value from the array of possible values
            if (value == 21) //if that maximum value is 21
            {
                return true; //return true, the player has a blackjack
            }
            else
            {
                return false; //return false, player does not have a blackjack
            }

        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleValues(Hand).Min(); //gets the minimum possible value from the array of possible values
            if (value > 21) //if the minimum value is greater than 21
            {
                return true; //return true, the player has busted
            }
            else
            {
                return false; //return false, player has not busted
            }
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleValues(Hand); //gets all possible values of the dealers hand
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22) //if the value of dealers hand is between 16 and 22
                {
                    return true; //return true, the dealer should stay
                }
            }
            return false; //return false, the dealer should not stay
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleValues(PlayerHand); //gets all possible values of the players hand
            int[] dealerResults = GetAllPossibleValues(DealerHand); //gets all possible values of the dealers hand

            int playerScore = playerResults.Where(x => x < 22).Max(); //gets a list of playerResults where the value is less than 22 then get the maximum value from that list  
            int dealerScore = dealerResults.Where(x => x < 22).Max(); //gets same thing but for the dealer.. the highest possible value without busting

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null; //if the player and dealer have the same score, return null

        }
    }
}
