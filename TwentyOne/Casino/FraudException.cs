using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
       public FraudException() 
            : base() { } //inherits from the base class Exception
       public FraudException(string message) //overloading the constructor method to take one parameter (string message)
            : base(message) { } //inherits from the base class Exception that takes one parameter
    }
}
