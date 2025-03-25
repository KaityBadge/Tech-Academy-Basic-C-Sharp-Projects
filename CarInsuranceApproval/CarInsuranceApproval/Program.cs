using System;

namespace BooleanLogic
{

    class carInsuranceApproval
    {
        static void Main()
        {
            //This program uses boolean logic to determine whether someone qualifies for car insurance

            //creates an variable called personsAge with users input being the value
            Console.WriteLine("What is your age?");
            string personsAge = Console.ReadLine();
            //creates an integer varaible called ageInt that converts the string value to integer type
            int ageInt = Convert.ToInt32(personsAge);



            Console.WriteLine("\nHave you ever had a DUI? [type true or false].");
            //takes user input "true" or "false" response and puts it in a string called DUI
            string DUI = Console.ReadLine();
            //creates a new variable called hasDUI that converts the string input to boolean (T/F)
            bool hasDUI = Convert.ToBoolean(DUI);


            Console.WriteLine("\nHow many speeding tickets do you have?");
            //takes user input and assigns it to the string called tickets
            string tickets = Console.ReadLine();
            //converts the string "tickets" to an interger called "numberOfTickets"
            int numberOfTickets = Convert.ToInt32(tickets);

            //creates a boolean called doesQualify
            //this asks true or false;
            //if ageInt is greater than 15 AND numberOftickets is less than or equal to 3 AND the person does not have a DUI
            //then they are qualified and "True" is printed in the Console.
            //all statements must be true to recieve a True response, if one is false than the response is false
            bool doesQualify = (ageInt > 15 && numberOfTickets <= 3 && !hasDUI) ;
            Console.WriteLine("\n\nQualified?  " + doesQualify);


            Console.ReadLine();
        }
    }
}