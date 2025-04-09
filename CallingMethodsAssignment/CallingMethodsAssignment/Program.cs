using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to do math operations on?");
            //convert the user input to an integer
            int userInput = Convert.ToInt32(Console.ReadLine());

            //creates/initiates an object called math of the class Math
            Math math = new Math();


            Console.WriteLine("The number you entered is: " + userInput);
            Console.WriteLine(userInput + " plus 10 equals: ");

            //calls the Add method from the Math class and passes in the userInput and 10
            Console.WriteLine(math.Add(userInput,10));


            Console.WriteLine(userInput + " minus 5 equals: ");
            //calls the Subtract method from the Math class and passes in the userInput and 5
            Console.WriteLine(math.Subtract(userInput, 5));


            Console.WriteLine(userInput + " multiplied by 2 equals: ");
            //calls the Multiply method from the Math class and passes in the userInput and 2
            Console.WriteLine(math.Multiply(userInput, 2));

            Console.ReadLine();
        }
    }
}