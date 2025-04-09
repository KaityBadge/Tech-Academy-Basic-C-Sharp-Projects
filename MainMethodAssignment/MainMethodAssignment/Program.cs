using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates the MathOperation class
            MathOperation math = new MathOperation();

            //calls the Add method with two INTEGERS passed in as parameters
            int intSum = math.Add(17, 106);
            Console.WriteLine("The sum of 17 and 106 is: " + intSum);

            //calls the Add method with two DECIMALS passed in as parameters
            decimal decimalSum = math.Add(16.1m, 2.3m);
            Console.WriteLine("The sum of 16.1 and 2.3 is: " + decimalSum);


            //calls the Add method with two STRINGS passed in as parameters
            string stringSum = math.Add("2", "100");
            Console.WriteLine("The sum of 2 and 100 is: " + stringSum);


            Console.ReadLine();
        }

    }
}