using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathOperation
    {
        // This method takes two INTEGERS as parameters and returns their sum.
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        //Another method for the MathOperation class that is also called Add.
        //This method takes two DECIMALS as parameters and returns their sum.
        public decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        //Another method for the MathOperation class that is also called Add.
        //This method takes the STRING parameters, converts them to INTEGERS, and returns the sum of those integers
        public string Add(string number1, string number2)
        {
            // Convert the strings (number1 and number2) to integers and stores them as integers called num1 and num2
            int num1 = Convert.ToInt32(number1);
            int num2 = Convert.ToInt32(number2);
            // Return the sum of the integers as a string
            return (num1 + num2).ToString();
        }
    }
}
