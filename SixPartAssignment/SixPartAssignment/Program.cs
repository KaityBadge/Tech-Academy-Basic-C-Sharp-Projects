using System;
using System.Collections.Generic;
using System.ComponentModel.Design;



class Program
{
    static void Main(string[] args)
    {
        //// ASSIGNMENT PART 1 //
        ////one dimensional array of strings
        //string[] bigAnimals = { "Tigers", "Lions", "Bears", "OH MY!" };

        //Console.WriteLine("Please input some text"); //Prompts user to input 

        //string userInput = Console.ReadLine(); //gets user input

        ////for loop starts at i= 0, for as long as i is less than length of animals array, adds 1 to i when loop ends
        //for(int i = 0; i < bigAnimals.Length; i++)
        //{
        //    //adds(appends) users input to the end of each string item in the array
        //    bigAnimals[i] = bigAnimals[i] + userInput; 
        //}

        ////create a second loop that prints off each string in the array one at a time (with updates from user input being added on in the for loop)
        //foreach (string animal in bigAnimals) //loops through each string in the array
        //{
        //    Console.WriteLine(animal); //prints each string in console
        //}

        //Console.ReadLine();


        //// ASSIGNMENT PART 2 //
        ////creates an infinite loop

        //int j = 0;
        ////while the condition is true, continue to loop
        //while (true)
        //{
        //    Console.WriteLine("Here is an infinite loop.");
        //    //This is the condition that will break out of the loop
        //    //if j is greater than 5 break out of the loop
        //    if (j > 5)
        //    {
        //        break;
        //    }
        //    //after each iteration add one to j 
        //    j++;
        //}

        //Console.ReadLine();


        //// ASSIGNMENT PART 3 //
        ////Using comparison operators < and <= to iterate through loops
        ////initializes two integer variables
        //int tooYoung = 0;
        //int legalAdult = 18;
        ////Do this loop as long as tooYoung is less than legalAdult, increment tooYoung each iteration
        //for (tooYoung = 0; tooYoung < legalAdult; tooYoung++)
        //{
        //    Console.WriteLine("If you are " + tooYoung + ", you aren't a legal adult.");
        //}

        ////Do this loop as long as 
        //for (legalAdult=18; legalAdult <= 18; legalAdult++)
        //{
        //    Console.WriteLine("Once you hit the age of " + legalAdult + ", you become an adult.");
        //}

        //Console.ReadLine();


        //// ASSIGNMENT PART 4 //
        ////creates a list called Fruit and instantiates it with unique strings
        //List<string> Fruits = new List<string>() { "banana", "apple", "peach", "mango"};

        ////loops through each item on the list and displays in console
        //foreach (string Fruit in Fruits)
        //{
        //    Console.WriteLine(Fruit);
        //}

        ////promts user input
        //Console.WriteLine("\n Pick a fruit from the list");

        ////stores user input
        //string userChoice = Console.ReadLine();

        ////creates a boolean and sets it to false
        ////this will determine if userChoice is on the list (true) or not on list (false)
        //bool YesOnList = false;

        ////iterates through list to check if userChoice is on the list
        ////start at 0, loop as long as i is less than the number of items on Fruits list, add one to i then loop again 
        //for (int i = 0; i < Fruits.Count; i++)
        //{
        //    //if an index item of Fruits list contains what the user entered(userChoice)
        //    if (Fruits[i].Contains(userChoice))
        //    {
        //        //write the item at that index that matches
        //        Console.WriteLine("You chose, " + Fruits[i] + "... that is on the list!");
        //        //set the boolean to true because a match has been found
        //        YesOnList = true;
        //        break; //stops(breaks) the loop once a match is found
        //    }
        //}
        ////if a match has NOT(!) been found
        //if (!YesOnList)
        //{
        //    Console.WriteLine("Try all lower case, otherwise that item is not on the list");
        //}


        //Console.ReadLine();




        //// ASSIGNMENT PART 5 //

        ////creates a list of strings with 2 identical strings
        //List<string> Veggies = new List<string> { "carrot", "zuchinni", "broccoli", "spinach", "broccoli" };

        //Console.WriteLine("Search for an item on my list of vegetables");

        ////stores users input as a variable
        //string userInput = Console.ReadLine();

        ////initializes a boolean that will store true or false depending on if userInput is on list or not
        //bool isOnList = false;

        ////loops through list as long as i is less than the item count of Veggies list
        //for (int i = 0; i < Veggies.Count; i++)
        //{
        //    //checks if any item in the list contains userInput
        //    if (Veggies[i].Contains(userInput))
        //    {
        //        //writes the index and its matching item
        //        Console.WriteLine($"You chose: {Veggies[i]} that is at index: {i}");
        //        isOnList = true;
        //    }

        //}
        ////displays message if the item is NOT on the list
        //if (!isOnList)
        //{
        //    Console.WriteLine("That item is not on the list.");
        //}



        //Console.ReadLine();



        // ASSIGNMENT PART 6 //

        //creates a list of strings and intializes it
        List<string> Names = new List<string> { "Kaity", "Grace", "Amelia", "Jenna", "Emily", "Emily" };

        //creates HASHSET string
        //HashSet does not allow duplicate elements
        HashSet<string> uniqueNames = new HashSet<string>();

        //loops through list of names in Names
        foreach (string name in Names)
        {
            //if the uniqueNames list contains a name from the Names list
            if (uniqueNames.Contains(name))
            {
                Console.WriteLine($"{name} is a duplicate name on the list");
            }
            else
            {
                //otherwise add the name to the uniqueNames list
                Console.WriteLine($"{name} is a unique name on the list");
                uniqueNames.Add(name);
            }
        }

        Console.ReadLine();

    }

}

