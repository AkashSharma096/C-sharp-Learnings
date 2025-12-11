/*************************************************************************************************
This file demonstrates the usage of ForEach method on a List in C#.

Description -
    The ForEach method executes the specified action on each element of the List. It is a convenient way to iterate through all elements without using a traditional loop.

Syntax -  ListName.ForEach(Action<T> action);
Parameters - action: A delegate that represents the action to be performed on each element of the List.
Return Value - This method does not return a value.

Example -
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    numbers.ForEach(n => Console.WriteLine(n));
************************************************************************************************/

using System;
using System.Collections.Generic;

namespace ListForEachMethod
{
    public class Program
    {
        static void Main()
        {
            // Create a List of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Use ForEach to print each number in the List
            numbers.ForEach(num => { Console.WriteLine(num); });

            // create a List of strings
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };

            // Use ForEach to print each fruit in the List
            fruits.ForEach(fruit => { Console.WriteLine(fruit); });
        }
    }
}