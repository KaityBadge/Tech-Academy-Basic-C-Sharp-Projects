using System;


namespace ParsingEnums
{
    public class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week (e.g. Monday):");

            //try/catch block will catch any exceptions that may occur
            try
            {
                //takes in user input
                 string userInput = Console.ReadLine();

                //userInput is parsed from string to the enum type DaysOfWeek and stored as a variable called 'day'
                //true is used to ignore case sensitivity so user can enter 'monday' or 'Monday'
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);
                Console.WriteLine("You entered: " + day);
            }
            //catch block will 'throw and exception' which informs the user if the input is invalid
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter and actual day of the week.");
            }
                   
            Console.ReadLine();
        }
    }
}