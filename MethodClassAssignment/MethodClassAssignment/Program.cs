using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates the Math class
            Math math = new Math();

            //calls the Add method with two numbers passed in
            math.Add(15, 20);

            //calls the Add methods and specifies the parameters by name
            math.Add(b: 30, a: 25);

            Console.ReadLine();
        }
    }
}