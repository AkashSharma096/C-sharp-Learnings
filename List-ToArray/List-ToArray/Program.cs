/*************************************************************************************************
This code demonstrates how to convert a List of integers to an array in C#.

Syntax:
    datatype[] arrayName =  ListName.ToArray()

Example:
    List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
    int[] array = numbers.ToArray();

************************************************************************************************/

using System;
using System.Collections.Generic;

namespace List_ToArray
{
    public class Program
    {
        static void Main()
        {
            // Create a List of integers
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            // Convert the List to an array
            int[] array = numbers.ToArray();

            // Print the elements of the array
            Console.WriteLine("Number Array elements :");
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }

            // create a List of strings
            List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };
            // Convert the List to an array
            string[] fruitArray = fruits.ToArray();
            // Print the elements of the array
            Console.WriteLine("\nFruit Array elements :");
            foreach (string fruit in fruitArray)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}