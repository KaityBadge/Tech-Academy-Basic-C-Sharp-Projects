using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    /// The semicolon means the Employee class inherits from Person class
    public class Employee : Person 
    {
        //Properties of the Employee class
        public int Id { get; set; }

        //This method is implementing the abstract method from the Person class and overriding it
        public override void SayName()
        {
            //Displays full name in console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

    }
}
