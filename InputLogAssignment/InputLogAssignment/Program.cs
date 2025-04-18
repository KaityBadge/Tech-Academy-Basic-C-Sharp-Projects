using System;
using System.Collections.Generic;
using System.IO;
using static System.Net.WebRequestMethods;


namespace InputLogAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a number
            Console.WriteLine("Please enter a number:");
            //read the number from the console
            string number = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(@"C:\Users\kaity\Logs\practice.txt", true))
            {
                //write the number to the file
                file.WriteLine(number);
            }


        }
    }
}