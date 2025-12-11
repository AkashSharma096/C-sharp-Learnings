/**************************************************************************************************
This program demonstrates how to find the index of a specific element in a list using C#.

Syntax:
    int index = list.IndexOf(element, startIndex);
Parameters:
    element: The element to locate in the list.
    startIndex: The zero-based starting index of the search.
Returns:
    Index of searched Element --> If searched element is Found.
    -1 --> If searched element is Not Found.
Example:
    List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
    int index = fruits.IndexOf("Banana",0); // index will be 1.
**************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace List_IndexOf
{
    public class Program
    {
        static void Main()
        {
            // Create a list of strings
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Element to find
            string searchElement = "Cherry";
            // Use IndexOf to find the index of the element
            int index = fruits.IndexOf(searchElement, 0);

            // Display the result
            if (index != -1)
            {
                Console.WriteLine($"Element '{searchElement}' found at index: {index}\n");
            }
            else
            {
                Console.WriteLine($"Element '{searchElement}' not found in the list.");
            }


            // create a list of integers
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 40 };

            int ind = numbers.IndexOf(40, 0);
            Console.WriteLine($"Element '40' found at index: {ind}");

            ind = numbers.IndexOf(40, ind + 1);
            Console.WriteLine($"Element '40' found again at index: {ind}\n");

            // Use While loop to find all occurrences of an element.
            ind = 0;
            List<int> num2 = new List<int> { 1, 2, 3, 2, 4, 2, 5, 2, 6, 2, 7, 2, 8, 2, 9, 2, 10 };
            while (ind > num2.Count || ind != -1)
            {
                ind = num2.IndexOf(2, ind);
                if (ind != -1)
                {
                    Console.WriteLine($"Element '2' found at index: {ind}");
                    ind++; // Move to the next index for the next search
                }
                else
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}