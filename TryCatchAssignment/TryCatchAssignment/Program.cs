using System;


namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int age;
            int birthYear;
            int currentYear = DateTime.Now.Year; //puts current year in a variable to help with calculations later

            try
            {
                Console.WriteLine("Enter your age: "); //prompts user for their age
                string userAge = Console.ReadLine(); //stores their string input as a variable
                age = int.Parse(userAge); //parses the string to an int

                if (age <= 0) //check if age is less than or equal to 0
                {
                    Console.WriteLine("Age Invalid: cannot be less than or equal to 0.");
                    Console.ReadLine(); //pauses the program so user can read the message
                    return; //exits the program 
                }

                birthYear = currentYear - age; //calculates birth year
                Console.WriteLine("{0} is the year you were born.", birthYear); // displays the users birth year

            }
            //the mroe specific exception is caught first 
            catch (FormatException) //catches if the user enters something that can't be parsed to int
            {
                Console.WriteLine("Input Invalid: please enter a whole number.");
                Console.ReadLine();
                return;
            } 
            catch (Exception) //general exception is caught second
            {
                Console.WriteLine("An error occurred: please try again.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();

        }
    }
}