using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    //made this class abstract so it cannot be instantiated, only inherited from
    public abstract class Person
    {
        //Properties of the Person class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //this method is abstract so it must be implemented in the derived class
        public abstract void SayName();
       
    }   
}
