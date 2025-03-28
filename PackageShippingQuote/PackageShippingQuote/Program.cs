using System;

namespace Branching
{
    class PackageShippingQuote
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("\nPlease enter the weight of your package: ");
            //converts user input to decimal and stores it in packageWeight variable
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());
            //if the package weight is more than 50 then print the string in the console.
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            //else if the package weight is less than 50 then print the following string
            else if (packageWeight < 50)
            {
                Console.WriteLine("\nPlease enter the width of your package: ");
            }

            //converts user input to decimal and stores it in package width variable
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nPlease enter the height of your package: ");
            //converts user input to decimal and stores it in package height variable 
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nPlease enter the length of your package: ");
            //converts user input to decimal and stores it in package length variable
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());
            //if the width + length + height is more than 50, the string in the curly braces will print in the console
            if (packageWidth + packageLength + packageHeight > 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via package express.");
            }
            //creates a decimal variable called shipping cost
            //multiplies the height, length and width then multiplies that total by the weight and divide the outcome by 100
            decimal shippingCost = ((packageHeight * packageLength * packageWidth) * packageWeight) / 100;
            //concatenates the string + the value of the shippingCost variable
            Console.WriteLine("\nYour estimated total for shipping this package is: $" + shippingCost);
            Console.ReadLine();

        }
    }
}