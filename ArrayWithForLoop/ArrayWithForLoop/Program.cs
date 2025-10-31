/***************************************************************************************
 This is an example of arrays using a for loop in C#.
 Syntax to use for loop in array - 
    for (int i = 0; i < array.Length; i++)
    {
        // Access each element using array[i]
    }
***************************************************************************************/

using System;
namespace ArrayWithForLoop
{
    public class Program
    {
        static void Main()
        {
            // Declare and initialize an array of integers
            int[] a = new int[5] { 10, 20, 30, 40, 50 };

            // Use a for loop to iterate through the array
            for (int i = 0; i < a.Length; i++)
            {
                // Print each element to the console
                Console.WriteLine($"Number at index {i} is {a[i]}");
            }

            Console.WriteLine(); // Print a blank line for better readability

            // Declare and initialize an array of strings
            string[] b = new string[5] { "One", "Two", "Three", "Four", "Five" };

            // Use a for loop to iterate through the string array
            for (int i = 0; i < b.Length; i++)
            {
                // Print each string element to the console
                Console.WriteLine($"String at index {i} is {b[i]}");
            }
        }
    }
}