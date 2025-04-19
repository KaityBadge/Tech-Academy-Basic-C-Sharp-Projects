using System;


namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //gets the current date and time
            DateTime currentDateTime = DateTime.Now;

            //prints the current date and time in the console
            Console.WriteLine("The current Date and Time is: " + currentDateTime);

            //prompts user for a number
            Console.WriteLine("Enter a number: ");
            //stores input in variable "number"
            string number = Console.ReadLine();

            //gets the time it will be in "number" hours from the current date and time
            DateTime futureDateTime = currentDateTime.AddHours(Convert.ToDouble(number));

            //prints the future date and time in the console
            Console.WriteLine("In " + number + " hours it will be: " + futureDateTime);

            Console.ReadLine();
        }
    }
}