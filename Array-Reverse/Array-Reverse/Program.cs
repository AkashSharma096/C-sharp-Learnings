/***********************************************************************************************************
This is an example of reversing an array in C#.

Syntax - Array.Reverse(Array array);
Parameters - array: The one-dimensional Array to reverse.
Return Value - This method does not return a value but sort the inplace of the given array.

***********************************************************************************************************/
using System;

namespace Array_Reverse
{
    public class Program
    {
        static void Main()
        {
            // Declare and initialize an array
            int[] numbers = { 1, 2, 3, 4, 5 };
            // Display the original array
            Console.WriteLine("Original Array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Reverse the array
            Array.Reverse(numbers);

            // Display the reversed array
            Console.WriteLine("\nReversed Array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Declare and initialize a string array
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
            // Display the original string array    
            Console.WriteLine("\n\nOriginal String Array: ");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + " ");
            }
            // Reverse the string array
            Array.Reverse(fruits);
            // Display the reversed string array
            Console.WriteLine("\nReversed String Array: ");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + " ");
            }
        }
    }
}