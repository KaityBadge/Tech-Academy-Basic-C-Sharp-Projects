class Program
{
    static void Main(string[] args)
    {

        //Declares and initializes the string array
        string[] nameArray = { "Penelope", "John", "Craig", "Paula", "Frank", "Lisa" };

        //creates integer that holds the length of the array
        int NumberOfNames = nameArray.Length;

        //Prompts user to input an acceptable index number
        ////(length of the array minus one to get the total indices)
        Console.WriteLine("Type an index number from 0 to " + (nameArray.Length - 1));
        
        //user input stored as usersChoice
        string userChoice = Console.ReadLine();

        //userChoice is cpnverted from string to integer and stored as nameIndex
        if (int.TryParse(userChoice, out int nameIndex))
        {
            //if user input is 0 or greater but not longer than the length of the array
            if ( nameIndex >=0 && nameIndex < nameArray.Length)
            {
                Console.WriteLine("The name at index " + userChoice + " is: " + nameArray[nameIndex]);
            }
        }

        Console.ReadLine();

        

        //Declares and initializes array of integers
        int[] numArray = { 1, 14, 34, 54, 20 };

        //Tells user to input an index and saves their input as a string called userInput
        Console.WriteLine("Choose an index number 0 to " + (nameArray.Length - 1));
        string userInput = Console.ReadLine();

        //int.TryParse converts userinput(string) to integer and stores it (out) as index
        if (int.TryParse(userInput, out int index))
        {
            //if index is 0 or greater AND index isn't greater than length of the array
            if (index >= 0 && index < numArray.Length)
            {
                Console.WriteLine($"You chose the element at index {index} which is {numArray[index]}");
            }
            else
            {
                Console.WriteLine("Please enter a valid index, must be 0-4");
            }
        }
        else
        {
            Console.WriteLine("Please enter a number");
        }

        Console.ReadLine();



        //Declares a list of strings called shopList
        List<string> shopList = new List<string>();

        //Add items (initialize)
        shopList.Add("Kale");
        shopList.Add("Sweet Potato");
        shopList.Add("Onion");
        shopList.Add("Chicken");
        shopList.Add("Avocado");

        //Displays text in the console.
        Console.WriteLine("There's 5 items on the grocery list ");
        //loops through list starting at index 0
        //continues looping while index is less than the 'count'(length) of the list
        //then adds one to the index
        for (int i = 0; i < shopList.Count; i++)
        {
            //prints the item at the chosen index
            Console.WriteLine($"{ shopList[i]}");
        }

        //Prompts user to enter an index number
        Console.WriteLine("Pick an index number of a grocery list item");
        //converts user input to integer called foodIndex
        int foodIndex = int.Parse(Console.ReadLine());

        //Displays the item at the index number that the user chose
        Console.WriteLine($"The item at index {foodIndex} is... {shopList[foodIndex]}");

        Console.ReadLine();
    }
}