using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces; //importing the interfaces namespace

namespace Casino.TwentyOne
{
    /// This class inherits from the Game class AND implements the IWalkAway interface
    public class TwentyOneGame : Game , IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        //override means that this method is overriding the abstract method in the base class (Game class)
        public override void Play()
        {
            Dealer = new TwentyOneDealer(); //instantiate a new dealer when play starts
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>(); //each player gets a new hand
                player.Stay = false; //because the player is not staying, they are playing
                
            }
            Dealer.Hand = new List<Card>(); //the dealer gets a new hand
            Dealer.Stay = false; //the dealer is not staying, they are playing
            Dealer.Deck = new Deck(); //the dealer gets a new deck
            Dealer.Deck.Shuffle(1); //the deck is shuffled once
            
            foreach (Player player in Players)
            {
                bool validAnswer = false; //this variable is used to check if the answer is valid
                int bet = 0; //this variable is used to store the players bet
                while (!validAnswer) //while the answer is not valid
                {
                    Console.Write("{0}, how much would you like to bet? ", player.Name); //asks the player how much they want to bet
                    validAnswer = int.TryParse(Console.ReadLine(), out bet); //tryparse casts input from string to int in the case user enters a string
                    if (!validAnswer) //if the input is still not a valid integer
                    {
                        Console.WriteLine("Please enter digits only, no decimals or symbols.");
                    }    
                }
                if (bet < 0) //if the bet is less than 0 throw new exception
                {
                    throw new FraudException();
                }
               
                bool successfullyBet = player.Bet(bet); //passes in the amount the player is betting to the Bet method
                if (!successfullyBet) //if the bet was not successful (successfullyBet is false)
                {
                    return; //exits/ends the method. Goes back to the top of the Play method
                }
                Bets[player] = bet; //adds the player and their bet to the Bets dictionary
            }

            for (int i = 0; i <2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name); //console.write wont be on a new line
                    Dealer.Deal(player.Hand); //calls the Deal method from the Dealer class and passes in the player's hand
                    if (i == 1) //if this is the second time through the loop
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); //checks if the player has a blackjack
                        if (blackJack) //if the player has a blackjack
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //player wins 1.5 times their bet plus their bet back
                            return; //exits the method
                        }
                    }

                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand); //calls the Deal method from the Dealer class and passes in the dealer's hand
                if (i == 1) //if this is the second time through the loop
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand); //checks if the dealer has a blackjack
                    if (blackJack) //if the dealer has a blackjack
                    {
                        Console.WriteLine("Dealer has Blackjack! Dealer wins!");
                        foreach (KeyValuePair<Player, int> entry in Bets) //iterates through the Bets dictionary
                        {
                            Dealer.Balance += entry.Value; //dealer gets all the bets, the balance of every player
                        }
                        return; //exits the method
                    }
                }

            }
            foreach (Player player in Players)
            {
                while (!player.Stay) //while player is Not staying
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand) //for each card in the player's hand
                    {
                        Console.Write("{0} ", card.ToString()); //calls the ToString method from the Card class to print string format of the card
                    }
                    Console.WriteLine("\n\n Hit or stay?");
                    string answer = Console.ReadLine().ToLower(); //gets the player's input and converts it to lowercase
                    if (answer == "stay") //if players says stay
                    {
                        player.Stay = true;
                        break; //breaks out of the while loop to check the condition
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand); //Deal method from the Dealer class is called and the player's hand is passed in. Player gets another card
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand); //checks if the player has busted
                    if (busted) //if the player has busted
                    {
                        Dealer.Balance += Bets[player]; //dealer gets the player's bet
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is: {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again? (yes or no)");
                        answer = Console.ReadLine().ToLower(); //gets the player's input and converts it to lowercase
                        if (answer == "yes") //if the player wants to play again
                        {
                            player.isActivelyPlaying = true; //set the player to actively playing
                            return; //exits the method and takes the player back to the top of the Play method
                        }
                        else
                        {
                            player.isActivelyPlaying = false; //set the player to not actively playing
                        }
                    }

                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //checks if the dealer has busted
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //checks if the dealer should stay
            while (!Dealer.Stay && !Dealer.isBusted) //while the dealer is not staying and has not busted
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand); //dealer gets another card
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //checks if the dealer has busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //checks if the dealer should stay
            }
            if (Dealer.Stay) //if the dealer is staying
            {
                Console.WriteLine("Dealer stays.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted! All players win!");
                foreach (KeyValuePair<Player, int> entry in Bets) //for every key value pair in Bets dictionary 
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); //prints the players name and the amount they won
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //finds the player in the Players list that matches the KVP and adds their bet times 2 to their balance
                    Dealer.Balance -= entry.Value; //subtracts the bet from the dealer's balance
                }
                return; //exits the method
            }

            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //compares the players hand to the dealers hand
                if (playerWon != null)
                {
                    Console.WriteLine("Push! No one wins");
                    player.Balance += Bets[player]; //player gets their bet back
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} wins {1}!", player.Name, Bets[player]); //prints the players name and the amount they won
                    player.Balance += (Bets[player] * 2); //player gets their bet back times 2
                    Dealer.Balance -= Bets[player]; //subtracts the bet from the dealers balance
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]); //prints the amount the dealer won which is the players bet
                    Dealer.Balance += Bets[player]; //adds the players bet to the dealers balance
                }

                Console.WriteLine("Would you like to play again? (yes or no)");
                string answer = Console.ReadLine().ToLower(); //gets the players input and converts it to lowercase
                if (answer == "yes") //if the player wants to play again
                {
                    player.isActivelyPlaying = true; 
                }
                else
                {
                    player.isActivelyPlaying = false; //set the player to not actively playing
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        // This method is implemented from the IWalkAway interface
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
