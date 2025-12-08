/**************************************************************************************************************
This code will demonstrate various methods to remove elements from a list in C#.

Functions demonstrated:
1. Remove by Value
2. Remove by Index
3. Remove All Matching a Condition
4. Remove Range of Elements
5. Clear the List

Function Syntax - 
1. Remove by Value:   list.Remove(value);
2. Remove by Index:   list.RemoveAt(index);
3. Remove All Matching a Condition:   list.RemoveAll(value => condition);
4. Remove Range of Elements:    list.RemoveRange(startIndex, count);
5. Clear the List:   list.Clear();

**************************************************************************************************************/

using System;
using System.Collections.Generic;


namespace List_Remove_Methods
{
    public class Program
    {
        public static void Main()
        {

            // Initialize a list of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 1. Remove by value
            numbers.Remove(5); // Removes the first occurrence of 5
            Console.WriteLine("After Remove(5): " + string.Join(", ", numbers));

            // 2. Remove by index
            numbers.RemoveAt(0); // Removes the element at index 0
            Console.WriteLine("After RemoveAt(0): " + string.Join(", ", numbers));

            // 3. Remove all matching a condition (remove all even numbers)
            numbers.RemoveAll(n => n % 2 == 0); // Removes all even numbers
            Console.WriteLine("After RemoveAll(n => n % 2 == 0): " + string.Join(", ", numbers));

            // 4. Remove range of elements (remove 2 elements starting from index 1)
            numbers.RemoveRange(1, 2); // Removes 2 elements starting from index 1
            // Display the list after removing range
            Console.WriteLine("After RemoveRange(1, 2): " + string.Join(", ", numbers));

            // 5. Clear the list
            numbers.Clear(); // Removes all elements from the list
            Console.WriteLine("After Clear(): " + string.Join(", ", numbers));
        }
    }
}