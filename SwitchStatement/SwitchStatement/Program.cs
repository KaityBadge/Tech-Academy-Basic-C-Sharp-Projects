using System;

namespace SwitchStatementPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //boolean variable called isGuessed is true if the variable called number equals 12, if number doesn't equal 12 then isGuessed is false
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try Again.");
                        Console.WriteLine("Guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12, You are correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            //Creates a while loop
            //what is inside {} will loop WHILE 'isGuessed' is FALSE (the '!' equates to false)
            while (!isGuessed);
      
            Console.Read();
        }
    }
}