/**********************************************************************************************
This program demonstrates how to sort and reverse a list in C#. both methods are in-place operations,
meaning they modify the original list rather than creating a new one.

Sort Method Syntax: list.Sort();

Reverse Method Syntax: list.Reverse();
***********************************************************************************************/

using System;
using System.Collections.Generic;

namespace List_SortAndReverse
{
    class Program
    {
        static void Main()
        {
            // Create and initialize a list of integers
            List<int> numbers = new List<int> { 5, 2, 8, 1, 4, 7, 6, 3 };

            // Display the original list
            Console.Write("Original list is :" + " ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Sort the list in ascending order
            numbers.Sort();

            // Display the sorted list
            Console.Write("\nSorted list is :" + " ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Reverse the sorted list
            numbers.Reverse();
            // Display the reversed list
            Console.Write("\nReversed list is :" + " ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}