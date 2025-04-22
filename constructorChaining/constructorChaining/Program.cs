using System;
using System.Collections.Generic;



namespace ConstructorChaining
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program that demonstrates constructor chaining in the Employee class.
            // It creates an instance of the Employee class using different constructors.

            //creates a constant for the business name
            const string buisinessName = "Tech Solutions";
            // prompts the user for their name and welcomes them to the employee site.
            Console.WriteLine("Welcome to the employee site for {0}! What is your name?" , buisinessName);
            // reads the user's input and stores it in the empName variable
            var empName = Console.ReadLine();
            Console.WriteLine("\nHello, {0}! Feel free to look around the {1} site." , empName, buisinessName);

            Console.ReadLine();
        }
    }
}