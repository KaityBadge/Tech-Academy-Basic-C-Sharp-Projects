using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class MathOperation
    {
        //creates a method called Multiply that takes two integers as parameters
        //the second parameter is optional with a default value of 1
        public int Multiply(int numberOne, int numberTwo = 1)
        {
            return numberOne * numberTwo;
        }
        
    }
}
