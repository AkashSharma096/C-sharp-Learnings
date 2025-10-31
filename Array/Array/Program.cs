/*********************************************************************************************************** 

Array/Program.cs. This program demonstrates array declaration, initialization, and element access.
 
Arrays can be created using following syntax:

        type[] arrayName = new type[size]; 

where  -->type is the data type of the array elements and size is the number of elements in the array.
Example:
        int[] numbers = new int[5]; // Declares an array of integers with 5 elements.
        
************************************************************************************************************/

using System;
namespace Array
{
    public class Program
    {
        static void Main()
        {
            // Declare and initialize arrays.
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            string[] b = new string[5] { "one", "two", "three", "four", "five" };

            // Access int array elements.
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);

            Console.WriteLine();

            // Access string array elements.
            Console.WriteLine(b[0]);
            Console.WriteLine(b[1]);
            Console.WriteLine(b[2]);
            Console.WriteLine(b[3]);
            Console.WriteLine(b[4]);

        }
    }
}