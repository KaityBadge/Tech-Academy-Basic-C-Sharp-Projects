using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        List<string> newList = new List<string>();
        newList.Add("Hello"); //first string item in the list at index 0
        newList.Add("World"); //add another string item to the list at index 1

        Console.WriteLine(newList[0]);
        Console.WriteLine(newList[1]);
        Console.ReadLine();

        ////declares an integer array and calls it numArray
        //int[] numArray = new int[5];
        ////add items to the array
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        ////easier way to add items to an array
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        ////even faster way to create an array
        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        ////prints the item at index 3 in the numArray 
        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();

    }
}