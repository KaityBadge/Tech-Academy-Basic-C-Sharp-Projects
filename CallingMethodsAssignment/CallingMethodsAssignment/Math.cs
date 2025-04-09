using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{

    /// This class contains methods for addition, subtraction, and multiplication.
    /// This class is public so it can be accessed outside of this class.
    public class Math
    {
        // public method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }
        //public method to subtract two integers
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        //public method to multiply two integers
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
