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
            //instatniate and initialize an employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //call the SayName (superclass) method on the employee object
            employee.SayName();

            Console.ReadLine();
        }
    }
}