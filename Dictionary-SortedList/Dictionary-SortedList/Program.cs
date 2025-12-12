/**********************************************************************************************************
This file demonstrates the usage of a SortedList in C# to store and retrieve key-value pairs in sorted order.
Difference in dictionary and sorted list is that - 
1. Dictionary stores key-value pairs in an unordered manner, while SortedList maintains the order of keys based on their natural sorting or a specified comparer.
2. Dictionary provides faster lookups for large datasets, while SortedList is more efficient for smaller datasets where sorted order is required.
3. SortedList uses less memory overhead compared to Dictionary when dealing with a small number of elements.

Sybtax - SortedList<TKey, TValue> sortedList = new SortedList<TKey, TValue>();

Parameters:
TKey: The type of keys in the sorted list.
TValue: The type of values in the sorted list.

Example:
SortedList<int, string> sortedList = new SortedList<int, string>();

**********************************************************************************************************/


using System;
using System.Collections.Generic;

namespace Dictionary_SortedList
{
    public class Program
    {
        static void Main()
        {

            // Create a SortedList to store student IDs and names
            SortedList<int, string> studentList = new SortedList<int, string>();

            // Adding key-value pairs to the SortedList
            studentList.Add(3, "Alice");
            studentList.Add(1, "Bob");
            studentList.Add(2, "Charlie");
            studentList.Add(5, "Diana");
            studentList.Add(4, "Ethan");
            studentList.Add(6, "Fiona");

            //PROPERTIES

            // Count property
            Console.WriteLine("\nTotal Students: " + studentList.Count);

            // Keys property
            Console.WriteLine("\nStudent IDs:");
            foreach (var id in studentList.Keys)
            {
                Console.WriteLine(id);
            }

            // Values property
            Console.WriteLine("\nStudent Names:");
            foreach (var name in studentList.Values)
            {
                Console.WriteLine(name);
            }

            //Return value by key
            Console.WriteLine("\nStudent with ID 3: " + studentList[3]);

            // Iterate through the SortedList and display key-value pairs
            Console.WriteLine("\nStudent List (Sorted by ID):");
            foreach (var student in studentList)
            {
                Console.WriteLine($"ID : {student.Key}, Name: {student.Value}");
            }

            // Search for a specific key using ContainsKey
            bool keyExists = studentList.ContainsKey(4);
            Console.WriteLine($"\nContains Key 4: {keyExists}");

            // Search for a specific value using ContainsValue
            bool valueExists = studentList.ContainsValue("Diana");
            Console.WriteLine($"Contains Value 'Diana': {valueExists}");

            //Get index of a specific key
            int indexOfKey = studentList.IndexOfKey(2);
            Console.WriteLine($"\nIndex of Key 2: {indexOfKey}");

            //Get index of a specific value
            int indexOfValue = studentList.IndexOfValue("Fiona");
            Console.WriteLine($"Index of Value 'Fiona': {indexOfValue}");


            //Remove a key-value pair by key
            studentList.Remove(5);
            Console.WriteLine("\nAfter removing student with ID 5:");
            foreach (var student in studentList)
            {
                Console.WriteLine($"ID : {student.Key}, Name: {student.Value}");
            }

            //Clear the SortedList
            studentList.Clear();
            Console.WriteLine("\nAfter clearing, total students: " + studentList.Count);
            Console.WriteLine();
        }
    }
}