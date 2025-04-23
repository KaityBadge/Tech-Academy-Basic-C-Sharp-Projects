using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorChaining
{
    // This Employee class demonstrates constructor chaining
    public class Employee
    {
        public string Name;
        public string Department;

        // First constructor
        // takes no parameters ( )
        // uses :this() to call the constructor that takes one parameter
        public Employee() : this ("Employee 1")
        {
        }


        // Second constructor
        // takes one parameter
        // uses :this() to call the constructor that takes two parameters
        public Employee(string name) : this(name, "unknown")
        {
            
        }

        // Third constructor
        // takes two parameters 
        // this constructor passes the parameters to the class properties
        public Employee(string name, string department)
        {
            this.Name = name;
            this.Department = department; 
        }
    }
}
