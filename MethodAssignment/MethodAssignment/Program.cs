using MethodAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MethodAssgnment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates an object called math of the class MathOperation
            MathOperation math = new MathOperation();

            //Prompts user to enter a number
            Console.Write("Enter a number: ");
            //Converts user input to integer and stores it in a variable called num1
            int num1 = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("You may enter another number or press enter to use the default number: ");
            string input = Console.ReadLine();

            int num2 = 1; //default value

            //Checks if the user entered a number
            //if the string is NOT null or empty then it converts the user input to an integer
            if (!string.IsNullOrEmpty(input))
            {
                //Converts user input to integer and stores it in a variable called num2
                num2 = Convert.ToInt32(input);
            }

            //calls the Multiply method
            int Result = math.Multiply(num1, num2);

            Console.WriteLine("the result of multiplying " + num1 + " and " + num2 + " is: " + Result);



            Console.ReadLine();
        }
    }
} 