/******************************************************************************************************
This is an example of how to create a list in C#.

Syntax - List<data_type> list_name = new List<data_type>();

Parameters:
data_type: The type of elements in the list.
list_name: The name of the list.
******************************************************************************************************/

using System;
using System.Collections.Generic;

namespace List
{
    public class Program
    {
        static void Main()
        {
            // create a list of integers
            List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            // print the list using foreach loop
            Console.WriteLine("List of numbers using foreach loop:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // create a list of strings.
            List<string> fruits = new List<string>(6) { "Apple", "Banana", "Cherry", "Date", "Elderberry", "Fig" };

            // print the list using for loop
            Console.WriteLine("List of numbers using for loop:");
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}