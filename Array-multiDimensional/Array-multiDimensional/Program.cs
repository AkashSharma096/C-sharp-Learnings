/***********************************************************************************************************
This is an example of a multi-dimensional array in C#.
Two dimensional arrays are like a grid or a table with rows and columns. All rows should have the same number of columns.
In this example, we create a 2D array to represent a simple 3x3 matrix and print its elements to the console.

Syntax - type[,] arrayName = new type[rows, columns];

Paramenets -   type: data type of the array elements (e.g., int, string, etc.)
             [,]: indicates that it is a multi-dimensional array. No of commas indicates the number of dimensions.
              arrayName: name of the array
              rows: number of rows in the array. default value is 0.
              columns: number of columns in the array. default value is 0.

***********************************************************************************************************/

using System;

namespace ArrayMultiDimensional
{
    public class Program
    {
        static void Main()
        {
            // Declare and initialize a 2D array (3 rows and 4 columns). 
            int[,] Matrix = new int[,]
            {
                {1,2,3,9},
                {4,5,6,9},
                {7,8,9,9}
            };

            // Print the elements of the 2D array
            Console.WriteLine("\nElements of the 2D array (Matrix):\n");
            //GetLegth(0) returns number of rows.
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                //GetLength(1) returns number of columns.
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}