/***********************************************************************************************************

This is an example of a C# program that implements a binary search algorithm to find the index of a target value in a sorted array.

Syntax - Array.BinarySearch(array, target);
Parameters:
- array: A sorted array in which to search for the target value.
- target: The value to search for in the array.
Return Value:
- The index of the target value if found; otherwise, a negative number indicating the bitwise
    complement of the index where the target can be inserted to maintain the sorted order.

***********************************************************************************************************/

using System;

namespace ArrayBinarySearch
{
    public class Program
    {
        static void Main()
        {
            //Declare and initialize a sorted array
            int[] sortedArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            //Target value to search for
            int targetValue = 14;

            //Perform binary search
            int index = Array.BinarySearch(sortedArray, targetValue);

            //Check if the target value was found and display the result
            if (index >= 0)
            {
                Console.WriteLine($"Target value {targetValue} found at index: {index}");
            }
            else
            {   // If not found, display the bitwise complement of the index. 
                Console.WriteLine($"Target value {targetValue} not found. It can be inserted at index: {index}");
            }
        }
    }
}
