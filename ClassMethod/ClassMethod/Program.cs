using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates the DivideOperation class
            DivideOperation divide = new DivideOperation();

            //prompts the user to enter a number
            Console.WriteLine("Please enter a number to divide by 2:");

            //creates an integer variable to store the user input
            int userNumber;

            //calls the DivideByTwo method
            //if the input is an integer then perform the divide method
            //tryparse will check if the input is an integer
            //the out parameter will store the user input as an integer
            if (int.TryParse(Console.ReadLine(), out userNumber))
            {
                divide.DivideByTwo(userNumber);
            }
            //if the input is not an integer then display an error message
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.ReadLine();

        }
    }
}