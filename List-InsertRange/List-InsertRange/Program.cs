/**************************************************************************************************
This is an example of usage of InsertRange 

Syntax - MyList.InsertRange(index, collection);

Parameters - 
1. index - The zero-based index at which the new elements should be inserted.
2. collection - The collection whose elements should be inserted into the List.

**************************************************************************************************/

using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // Create a List of integers
        List<int> numbers = new List<int>() { 1, 2, 3, 7, 8, 9 };

        // Create a collection of integers to insert
        List<int> newNumbers = new List<int>() { 400, 500, 600 };

        // Insert the newNumbers collection into numbers at index 3
        numbers.InsertRange(3, newNumbers);

        // Print the modified List
        Console.WriteLine("Modified List after InsertRange:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}