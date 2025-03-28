using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomTempurature = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTempurature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (roomTempurature > currentTemperature)
            {
                Console.WriteLine("It is colder than room temperature.");
            }
            else if (currentTemperature > roomTempurature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else
            {
                Console.WriteLine("Something went wrong. ");
            }

            Console.ReadLine();


            //int currentTemp = 70;
            //int roomTemp = 70;

            ////This '?' is the ternary operator
            ////it checks the condition of the statement and prints the string on the left side of the colon if true
            ////if the condition is false, the string on the right of the colon will print to console.
            //string comparisonResult = currentTemp == roomTemp ? "it is room temp" : "it is not room temp";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();


            ////first do this, if it it is true, the code in the curly braces will print in console
            ////if this evaluates the rest of the code can be skipped
            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            ////If the first statement isn't true then check this
            ////If this is true then print what's in the curly braces
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("Room temp is warmer than current temp.");
            //}
            ////If neither of the above statements are true do this else statement
            //else
            //{
            //    Console.WriteLine("It is not exactly room temp");
            //}
            //Console.ReadLine();
        }
    }
}