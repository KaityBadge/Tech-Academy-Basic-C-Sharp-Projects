using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructAssignment
{
       class Program
    {
        static void Main(string[] args)
        {
            //creates an object of the data type Number (struct)
            //and assigns it to the variable number
            Number number = new Number();

            //sets the Amount property to 100.00
            number.Amount = 100.00m;

            //displays the value of the Amount property in the console
            Console.WriteLine("The amount is: " + number.Amount);
            
            Console.ReadLine();
        }
    }
}