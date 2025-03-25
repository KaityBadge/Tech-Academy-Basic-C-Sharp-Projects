namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            ////Because this is of integer type, we will get whole numbers, so the answer will be rounded DOWN to nearest whole number.
            //int quotient = 100 / 17;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            ////If you want a more precise answer, you need to use the type double
            //// and you must give the numbers decimals or else the compiler will treat them as integers
            //double testMath = 100.0 / 17.0;
            //Console.WriteLine(testMath);
            //Console.ReadLine();


            ////Using the Modulus Operator (Remainder)
            ////the result will be the remainder of the equation
            //// when 0 is the remainder, it means the number is even
            //// when 1 is the remainder, it means the number is odd
            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();


            ////COMPARISON OPERATORS

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();


            //int roomTemp = 70;
            //int currentTemp = 72;
            //bool isWarm = currentTemp > roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            /////TAKES USER INPUT TO MULTIPLY BY 50///
            ////creates and integer called userNum
            //int userNum;
            //Console.WriteLine("Type a number to be multiplied by 50.");
            ////reads input from the console and converts it to integer 
            //userNum = Convert.ToInt32(Console.ReadLine());
            ////creates a new integer called timesFifty that takes the input of userNum and multiplies it by 50
            //int timesFifty = userNum * 50;
            ////prints the concatenated line on the console userNum + the sentence + timesFifty
            //Console.WriteLine(userNum + " multiplied by 50 is : "+ timesFifty );
            //Console.ReadLine();


            //////TAKES USER INPUT AND ADDS 25///
            ////creates a variable to be used later
            //int yourNumber;
            //Console.WriteLine("Type a number that you want to add 25 to.");
            //yourNumber = Convert.ToInt32(Console.ReadLine());
            //int addTwentyFive = yourNumber + 25;
            //Console.WriteLine(yourNumber + " plus 25 is: " + addTwentyFive);
            //Console.ReadLine();

            /////TAKES USER INPUT AND DIVIDES BY 12.5///
            //Console.WriteLine("Type a number and we'll divide it by 12.5.");
            //string newNum = Console.ReadLine();
            ////parses user input as a double and stores it in the "userNumber" variable
            //if (double.TryParse(newNum, out double userNumber))
            //    //divides users input by 12.5 and stores it in the "result" variable as type double
            //{ double result = userNumber / 12.5;
            //  Console.WriteLine(newNum + " divided by 12.5 is : " + result);
            //}
            //Console.ReadLine();

            //////CHECKS IF USER INPUT IS GREATER THAN 50 AND PRINTS TRUE/FALSE IN CONSOLE    
            //int usersNum;
            //Console.WriteLine("Type a number and the computer will check if it is greater than 50.");
            ////converts user input to integer and stores it in the variable called usersNum
            //usersNum = Convert.ToInt32(Console.ReadLine());
            ////creates a boolean variable that checks if users input is greater than 50
            //bool checkNum = usersNum > 50;
            //Console.WriteLine(usersNum + " is greater than 50: " + checkNum);
            //Console.ReadLine();

            //////TAKES USER INPUT, DIVIDES IT BY 7, THEN PRINTS THE REMAINDER IN CONSOLE
            //int divideNum;
            //Console.WriteLine("Type a number, the computer will divide it by seven then give you the remainder.");
            ////converts the users input to an integer and stores it in the "divideNum" variable"
            //divideNum = Convert.ToInt32(Console.ReadLine());
            ////uses the modulus operator to find the remainder when divideNum is divided by 7.
            //int remainder = divideNum % 7;
            //Console.WriteLine("The remainder when " + divideNum + " is divided by 7 is: " + remainder);
            //Console.ReadLine();

        }
    }
}