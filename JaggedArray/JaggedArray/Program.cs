/***********************************************************************************************************
This is an example of a jagged array in C#. Jagged arrays are arrays of arrays, meaning that each element
of the main array can hold an array of different lengths.

Syntax -  type[][] arrayName = new type[rows][];

Parameters:
- type: The data type of the elements in the array (e.g., int, string
, double).
- arrayName: The name of the jagged array.
- rows: The number of rows (or sub-arrays) in the jagged array.

***********************************************************************************************************/
using System;

namespace JaggedArray
{
    public class Program
    {
        static void Main()
        {
            // Declare a jagged array with 3 rows
            int[][] jaggedArray = new int[5][];

            // Initialize each row with different lengths
            jaggedArray[0] = new int[2] { 1, 2 };          // First row with 2 elements
            jaggedArray[1] = new int[3] { 3, 4, 5 };       // Second row with 3 elements
            jaggedArray[2] = new int[1] { 6 };              // Third row with 1 element
            jaggedArray[3] = new int[4] { 7, 8, 9, 10 };   // Fourth row with 4 elements
            jaggedArray[4] = new int[2] { 11, 12 };          // Fifth row with 2 elements

            // Access and print elements of the jagged array. (JaggedArray.Length) gives number of rows.
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                // jaggedArray[i].Length gives number of elements in the ith row.
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}