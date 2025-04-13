using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            ///    THIS SECTIONS FOCUSES ON OPERATOR OVERLOADING WITH COMPARISON OPERATORS ///
            //instantiate and initialize an employee object {assigns values to properties}
            Employee employee1 = new Employee { Id = 1, FirstName = "Quinn", LastName = "Badgley"};
            Employee employee2 = new Employee { Id = 2, FirstName = "Sammy", LastName = "Jones" };


            //compare the two employee objects using the overloaded == and != operators
            bool areEqual = employee1 == employee2; //this means false
            bool areNotEqual = employee1 != employee2; //this means true 


            Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);
            Console.WriteLine("employee1 and employee2 are NOT equal? " + areNotEqual);
            Console.ReadLine();



            /////   THIS SECTION IS COMMENTED OUT BECAUSE I WANT TO TRY USING OPERATOR OVERLOADING WITHOUT INHERITANCE   /////
            ////instantiate and initialize an employee object
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";

            ////call the SayName method on the employee object
            //employee.SayName();

            ////uses polymorphism to create an object of the IQuittable interface
            ////polymorphism is when a derived (inherited) class is used as a base class
            ////so the Employee class is being used as a base class for the IQuittable interface
            ////this makes the new employee object an IQuittable object (any employee object can quit)
            //IQuittable quittable = new Employee();

            ////call the Quit method on the IQuittable object
            //quittable.Quit();

            Console.ReadLine();
        }
    }
}