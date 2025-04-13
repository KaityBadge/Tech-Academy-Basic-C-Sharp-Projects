using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Employee
    {
        //Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //overloading the == comparison operator to COMPARE two Employee objects by their Id properties
        //this says that if the Id properties are equal, the two Employee objects are equal
        public static bool operator == (Employee employee1, Employee employee2)
        {
            //if the Id properties are equal, return true
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
            //otherwise return false
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            //if the Id properties are NOT equal, return true
            {
                return !(employee1 == employee2);
            }

        }
    }
    








    ///////   THIS SECTION IS COMMENTED OUT BECAUSE I WANT TO TRY USING OPERATOR OVERLOADING WITHOUT INHERITANCE   /////
    ///// The semicolon means the Employee class inherits from Person abstract class and the IQuittable interface
    //public class Employee : Person , IQuittable
    //{
    //    //Properties of the Employee class
    //    public int Id { get; set; }

    //    //This method is implementing the abstract method from the Person class and overriding it
    //    public override void SayName()
    //    {
    //        //Displays full name in console
    //        Console.WriteLine("Name: " + FirstName + " " + LastName);
    //    }

    //    //this method is implementing the Quit method from the IQuittable interface
    //    public void Quit()
    //    {
    //        Console.WriteLine(FirstName + " " + LastName + " just quit!");
    //    }
    //}
}
