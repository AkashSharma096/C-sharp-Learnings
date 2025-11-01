/***********************************************************************************************************
This is an example of a C# program that demonstrates how to sort an array of integers in ascending order using the Array.Sort method.

Syntax - Array.Sort(array);

Parameters:
array: The one-dimensional array to be sorted.
***********************************************************************************************************/


using System;

namespace ArraySortExample
{
    public class Program
    {
        static void Main()
        {
            // Declare and initialize an array of integers
            int[] numbers = { 5, 2, 8, 1, 4, 7, 6, 3 };

            // Display the original array
            Console.WriteLine("Original array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // Sort the array in ascending order
            Array.Sort(numbers);

            // Display the sorted array
            Console.WriteLine("Sorted array in ascending order:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\n\n");

            // Declare and initialize another array of strings
            string[] fruits = { "Banana", "Apple", "Orange", "Mango", "Grapes" };

            // Display the original array of strings
            Console.WriteLine("Original array of fruits:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + " ");
            }

            // Sort the array of strings in ascending order
            Array.Sort(fruits);

            // Display the sorted array of strings
            Console.WriteLine("\nSorted array of fruits in ascending order:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + " ");
            }
        }
    }

}