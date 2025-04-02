using System;

namespace BooleanLoops
{
    class WhileLoop
    {
        static void Main(string[] args)
        {


            //creates a string variable that stores 'tiger' as myAnimal
            string myAnimal = "tiger";

            //creates a string variable that stores an empty value as userGuess
            //empty string will be filled later when user input is taken in
            string userGuess = "";

            //creates an integer that stores '3' as numberOfGuesses
            int numberOfGuesses = 3;

            //creates a boolean variable that is true when userGuess is tiger
            //if userGuess is not tiger then this isGuessed is false
            bool isGuessed = userGuess == "tiger";

            Console.WriteLine("You have 3 chances to guess my favorite animal in the zoo \n\n READY. SET. GUESS: ");
            //converts user input to lower case and stores its value as userGuess (this string is no longer empty)
            userGuess = Console.ReadLine().ToLower();

            //if the users guess is tiger then the console will display following statement and program ends
            if (userGuess == myAnimal)
            {
                Console.WriteLine("Yep! You guessed it!");
            }
            //otherwise; if the users guess IS NOT tiger do the following
            else if (userGuess != myAnimal)
            {
                //WHILE users guess IS NOT tiger AND the number of guesses is greater than 1 then loop through the following code
                while (userGuess != myAnimal && numberOfGuesses > 1)
                {
                    // -- means to deacrease by one. So numberOfGuesses is decreased by one
                    numberOfGuesses--;
                    //lets the user know that they guessed wrong and displays how many guesses they have left
                    Console.WriteLine("ERRR Wrong! You have " + numberOfGuesses + " guesses left.");
                    //prompts user to guess again and converts it to lower case
                    userGuess = Console.ReadLine().ToLower();
                    //if the user guess is tiger print the following line in the console
                    if (userGuess == myAnimal)
                    {
                        Console.WriteLine("Yep! You guessed it!");
                    }
                    //stop doing the loop if number of guesses is equal to 1 and display the following in the console.
                    else if (numberOfGuesses == 1)
                    {
                        Console.WriteLine("You're all out of guesses. The answer was " + myAnimal);
                        break;
                    }
                }
            }



            Console.Read();
            
        }
    }
}