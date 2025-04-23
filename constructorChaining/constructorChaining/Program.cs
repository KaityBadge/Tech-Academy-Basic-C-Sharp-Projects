using constructorChaining;
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

            // creating instances of the Employee class
            Employee employee1 = new Employee { Name = "Joe", Department = "Programmer" };
            Employee employee2 = new Employee { Name = "Billy", Department = "Design" };
            Employee employee3 = new Employee { Name = "Erin", Department = "Engineer" };
            Employee employee4 = new Employee { Name = "Grace", Department = "System Administrator" };
            Employee employee5 = new Employee { Name = "Joe", Department = "Programmer" };

            //creates a list of the employees
            List<Employee> employees = new List<Employee>() { employee1, employee2, employee3, employee4, employee5 };

            //writes list of employees to console.
            Console.WriteLine("\nHere is a list of the employees for {0}", buisinessName);
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }

            Console.ReadLine();
        }
    }
}