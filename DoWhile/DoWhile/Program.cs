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

            //initialize isGuessed to false
            bool isGuessed = false;

            Console.WriteLine("You have 3 chances to guess my favorite animal in the zoo \n\n READY. SET. GUESS: ");

            //Begins the guessing loop (Do all this while the condition of the WHILE statement is true)
            do
            {
                //converts user input to lower case and stores its value as userGuess (this string is no longer empty)
                userGuess = Console.ReadLine().ToLower();
                //checks if the users guess is correct
                isGuessed = userGuess == myAnimal;

                //IF isGuessed is tiger, display string in console.
                if (isGuessed)
                {
                    Console.WriteLine("Yep! You guessed it!");
                }
                //ELSE if isGuessed is not tiger
                else
                {
                    //decreases the number of guesses by one
                    numberOfGuesses--;
                    //IF they still have guesses left display this message and how many guesses are left
                    if (numberOfGuesses > 0)
                    {
                        Console.WriteLine("ERRR Wrong! You have " + numberOfGuesses + " guesses left.");
                    }
                    //Otherwise display there are no more guesses
                    else
                    {
                        Console.WriteLine("You're all out of guesses. The answer was " + myAnimal);
                    }
                }
                                
            } 
            //this loop will continue WHILE isGuessed is false (the user guesses wrong) AND there are more than 0 guesses
            while (!isGuessed && numberOfGuesses > 0);

            Console.Read();

        }
    }
}