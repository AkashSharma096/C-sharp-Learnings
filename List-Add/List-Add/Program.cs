/**************************************************************************************************
This is am example of a C# program that demonstrates how to add elements to a list.

Syntax - ListName.Add(item);

Parameters:
  item: The object to be added to the end of the List<T>.
  ListName: The name of the list to which the item will be added.
  
Example:
    MyList.Add(42); // Adds the integer 42 to the end of MyList.  
**************************************************************************************************/

using System;
using System.Collections.Generic;

namespace List_Add
{
    public class Program
    {
        static void Main()
        {
            // Create a list of numbers

            List<int> numbets = new List<int>(5) { 1, 2, 3, 4, 5 };

            // Print the original list
            Console.WriteLine("Original List:");
            foreach (var number in numbets)
            {
                Console.WriteLine(number);
            }

            // Add a new number to the list
            numbets.Add(6);
            numbets.Add(7);

            // Print the updated list
            Console.WriteLine("\nUpdated List after adding elements:");
            foreach (var number in numbets)
            {
                Console.WriteLine(number);
            }
        }
    }
}