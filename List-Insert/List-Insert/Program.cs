/**************************************************************************************************
This is an example of a C# program that demonstrates how to insert elements into a list at specific positions.

Syntax - MyList.Insert(index, item);

Parameters:
  index: The zero-based index at which item should be inserted.
  item: The object to insert into the List.

Example:
    List<int>MyList = new List<int>() { 1, 2, 3, 4, 5 };
    MyList.Insert(2, 99); // Inserts 99 at index 2
    Resulting List: { 1, 2, 99, 3, 4, 5 }
**************************************************************************************************/

using System;
using System.Collections.Generic;

namespace List_Insert
{
    public class Program
    {
        static void Main()
        {
            // Create a list of integers
            List<int> myList = new List<int>(5) { 10, 20, 30, 40, 50 };

            // Display the original list
            Console.WriteLine("Original List:");
            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Insert an element at index 2
            myList.Insert(2, 99);

            // myList.Insert(3, "25") - string can't be added in int list. This will cause a compile-time error.

            // Display the modified list
            Console.WriteLine("List after inserting 99 at index 2:");
            foreach (int item in myList)
            {
                Console.Write(item + " ");
            }
        }
    }
}