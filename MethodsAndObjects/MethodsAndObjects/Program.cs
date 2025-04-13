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
            //instantiate and initialize an employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //call the SayName method on the employee object
            employee.SayName();

            //uses polymorphism to create an object of the IQuittable interface
            //polymorphism is when a derived (inherited) class is used as a base class
            //so the Employee class is being used as a base class for the IQuittable interface
            //this makes the new employee object an IQuittable object (any employee object can quit)
            IQuittable quittable = new Employee();

            //call the Quit method on the IQuittable object
            quittable.Quit();

            Console.ReadLine();
        }
    }
}