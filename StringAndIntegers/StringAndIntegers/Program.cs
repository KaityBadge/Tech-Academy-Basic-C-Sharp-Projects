using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
class Program
{
    public static void Main(string[] args)
    {
        //create a list of integers
        List<int> highScores = new List<int> { 3155, 3196, 3654, 3556,3354 };

        //Asks user for a number
        Console.WriteLine("Pick a number to divide each number in the list by.");
        //stores user input
        string userInput = Console.ReadLine();

        //try/catch block
        try
        {
            //converts userInput from string to integer and strores it as divisor
            int divisor = int.Parse(userInput);
            //loops through each score in highScores
            foreach (int score in highScores)
            {
                //converts score to double to get decimal value when dividing
                double total = (double)score / divisor;
                //prints each score divided by the divisor and the total/result
                Console.WriteLine($"{score} / {divisor} = {total}");
            }

            Console.ReadLine();
        }

        //catch when user enters 0 as the divisor
        catch (DivideByZeroException)
        {
            Console.WriteLine("You may not divide by zero.");
        }
        //catch when user enters anything other than a number
        catch (FormatException)
        {
            Console.WriteLine("Must input a number.");
        }
        //This will always execute whether or not an exception is thrown
        finally
        {
            Console.WriteLine("The 'try/catch' blocks are finished");
        }

        Console.ReadLine();

    }

}