using System;
class AnonymousIncomeComparison
{  static void Main()
    {
        ////This is a basic program that works, but has room for improvement.
        /// The Parse methods pose a problem if the user enters anything other than number values such as "fifteen" vs 15
        /// I intend to edit this in the futuree with the tryparse method upon further study
        /// The tryparse method will catch this error and I will be able to write code to inform the user to input a number
        /// instead of the program shutting down when it doesn't recieve the input it wants. 



        Console.WriteLine("Anonymous Income Comparison Program");

        Console.WriteLine("\nPerson 1:");
        Console.WriteLine("What is their hourly rate?");
        //creates a variable called "hourlyRate1" of the double type for more accurate calculations
        //double.parse will take the user input (string representation of a number such as 15)
        //and convert it to double (actual number equivilant) 
        double hourlyRate1 = double.Parse(Console.ReadLine());
        Console.WriteLine("How many hours per week?");
        double hoursWorked1 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nPerson 2:");
        Console.WriteLine("What is their hourly rate?");
        double hourlyRate2 = double.Parse(Console.ReadLine());
        Console.WriteLine("How many hours per week?");
        double hoursWorked2 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nAnnual salary of Person 1: ");
        //creates a variable of type double and names it "annualSalary1"
        //multiplies person 1 hourly rate by person 1 hours worked then multiplies that by 52 (weeks in a year)
        double annualSalary1 = (hourlyRate1 * hoursWorked1) * 52;
        Console.WriteLine(annualSalary1);

        Console.WriteLine("\nAnnual salary of Person 2: ");
        //creates a variable of type double and names it "annualSalary2"
        //multiplies person 2 hourly rate by person 2 hours worked then multiplies that by 52 (weeks in a year)
        double annualSalary2 = (hourlyRate2 * hoursWorked2) *52;
        Console.WriteLine(annualSalary2);

        Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
        //creates a boolean variable called "person1MakesMore" to check if annualSalary1 is greater than annualSalary2
        bool person1MakesMore = annualSalary1 > annualSalary2;
        //prints the true/false result or the variable "person1MakesMore" in the console
        Console.WriteLine(person1MakesMore);



        Console.ReadLine();


    }
}
