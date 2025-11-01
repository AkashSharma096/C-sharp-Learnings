/***********************************************************************************************************
This is an example of how to resize an array in C#.

Syntax - Array.Resize(array, newSize);
Paramenters:
  array - The array to resize.
  newSize - The new size of the array.
***********************************************************************************************************/
using System;

namespace ArrayResize
{
    public class Program
    {
        static void Main()
        {
            // Initialize an array of integers with 5 elements
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Display the original array
            Console.WriteLine("Original array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Resize the array to hold 8 elements
            Array.Resize(ref numbers, 8);

            // Display the resized array
            Console.WriteLine("\n\nResized array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Resize the array to hold 3 elements
            Array.Resize(ref numbers, 4);
            // Display the resized array
            Console.WriteLine("\n\nResized array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}