/**********************************************************************************************************
This file demonstrate the Dictionary, its properties and methods in C#.

Syntax to create a Dictionary:
Dictionary<TKey, TValue> dictionaryName = new Dictionary<TKey, TValue>();

Parameters:
TKey: The type of keys in the dictionary.
TValue: The type of values in the dictionary.

Example:
Dictionary<int, string> studentDictionary = new Dictionary<int, string>();
**********************************************************************************************************/

using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    public class Program
    {
        static void Main()
        {
            // create a dictionary to store student ID and student name
            Dictionary<int, string> studentDictionary = new Dictionary<int, string>();

            // Adding key-value pairs to the dictionary
            studentDictionary.Add(1, "Alice");
            studentDictionary.Add(2, "Bob");
            studentDictionary.Add(3, "Charlie");
            studentDictionary.Add(4, "Diana");
            studentDictionary.Add(5, "Ethan");

            // Accessing values using keys
            Console.WriteLine("Student with ID 3: " + studentDictionary[3]);


            //Checking count of items in the dictionary
            Console.WriteLine("\nTotal students: " + studentDictionary.Count);

            //Iterate through the dictionary
            Console.WriteLine("\nStudent List:");
            foreach (var kvp in studentDictionary)
            {
                Console.WriteLine("ID: " + kvp.Key + ", Name: " + kvp.Value);
            }

            //checking all keys in the dictionary
            Console.WriteLine("\nStudent IDs:");
            foreach (var key in studentDictionary.Keys)
            {
                Console.WriteLine(key);
            }

            //checking all values in the dictionary
            Console.WriteLine("\nStudent Names:");
            foreach (var value in studentDictionary.Values)
            {
                Console.WriteLine(value);
            }

            //Removing a key-value pair
            studentDictionary.Remove(2);
            Console.WriteLine("\nAfter removing student with ID 2, total students: " + studentDictionary.Count);

            //Determine whether a key exists
            if (studentDictionary.ContainsKey(4))
            {
                Console.WriteLine("\nStudent with ID 4 exists in the dictionary.");
            }

            //Determine whether a value exists
            if (studentDictionary.ContainsValue("Alice"))
            {
                Console.WriteLine("\nAlice exists in the dictionary.");
            }

            //Clearing the dictionary
            studentDictionary.Clear();
            Console.WriteLine($"\nAfter clearing, total students: {studentDictionary.Count}\n");
        }
    }
}