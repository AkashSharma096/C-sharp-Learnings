/******************************************************************************************
This is an example of using the Array.IndexOf method in C# to find the index of a specific element in an array.

Syntax -  Array.IndexOf(Array, Value, StartIndex, Count)
Parameters -
         Array: The one-dimensional array to search.
         Value: The object to locate in the array.
         StartIndex: The starting index of the search.
         Count: The number of elements in the section to search. by default, the entire array is searched.
         
Returns - The index of the first occurrence of the specified value within the range of elements in the array; otherwise, -1 if the value is not found.
*******************************************************************************************/

using System;

namespace ArrayindexOf
{
    public class Program
    {
        static void Main()
        {
            // Create and initialize a new array of strings.
            string[] strarray = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "five" };

            // Search for the index of the string "five" in the array, starting from index 0 and searching all 10 elements.
            int index = Array.IndexOf(strarray, "five", 0);

            // Print the index of the found element.
            Console.WriteLine("The index of 'five' is: " + index);

            // Search for the index of the string "five" in the array, starting from index 5 and searching 5 elements.
            int index2 = Array.IndexOf(strarray, "five", 5);
            // Print the index of the found element.
            Console.WriteLine("The index of 'five' starting from index 5 is: " + index2);

            // Search for the index of the string "eleven" in the array, which does not exist.
            int index3 = Array.IndexOf(strarray, "eleven", 0);
            // Print the index of the found element.
            Console.WriteLine("The index of 'eleven' is: " + index3);
        }
    }
}