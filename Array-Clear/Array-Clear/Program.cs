/***********************************************************************************************************
This is an example of how to clear an array in C#. This mehod doesnot delete the array but sets the elements to their default values.
for int - 0, for string - null, for bool - false etc.

Syntax - Array.Clear(Array, index, length);

Parameters:
- Array: The array to be cleared.
- index: The starting index of the range to be cleared. Default is beginning of the array.
- length: The number of elements to clear. Default is the length of the array.

***********************************************************************************************************/

using System;

namespace Array_Clear
{
    public class Program
    {
        static void Main()
        {
            // Initialize an array of integers
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Display the original array
            Console.WriteLine("Original Array: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            // Clear the 4 array elements starting from index 3
            Array.Clear(numbers, 3, 4);

            // Display the modified array
            Console.WriteLine("\n\nArray after clearing 4 elements from index 3: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            //Now clear the entire array. 
            Array.Clear(numbers);
            // Display the modified array. All elements should be set to default value (0 for int).
            Console.WriteLine("\n\nArray after clearing all elements: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}