using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    public class DivideOperation()
    {
        //creates a void method that takes integer called userNumber and divides it by 2
        public void DivideByTwo(int userNumber)
        {
            //divides the userNumber by 2
            int result = userNumber / 2;

            //displays the result to the user
            Console.WriteLine($"The result of dividing {userNumber} by 2 is: {result}");
        }

        //creates an overload method of class DivideByTwo with output parameters
        //out int is used to return the result of the division
        public static void DivideByTwo(int userNumber, out int result)
        {
            //divides the userNumber by 2
            result = userNumber / 2;
            //displays the result to the user
            Console.WriteLine($"The result of dividing {userNumber} by 2 is: {result}");
        }

    }

}
