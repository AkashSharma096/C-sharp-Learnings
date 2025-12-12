/**********************************************************************************************************
This file demonstrates usage of hashtables in C#.
It includes creating a hashtable, adding key-value pairs, retrieving values,
and iterating through the hashtable.

Hashtable takes the key-value pairs and the converts key into a hash code and then retrieve the index using below formula:
Index = HashCode % TableSize (where tablesize is the size of the hashtable and is always a prime number)

In case of multiple keys generating same hash code, it stores the key-value pairs in a linked list at that index.

Syntax - Hashtable hashtable = new Hashtable();
Namespace - System.Collections

**********************************************************************************************************/
using System;
using System.Collections;

namespace Dictionary_Hashtable
{
    public class Program
    {
        static void Main()
        {
            // create a student hashtable
            Hashtable studentTable = new Hashtable();

            // adding key-value pairs to the hashtable
            studentTable.Add(1, "John Doe");
            studentTable.Add(2, "Jane Smith");
            studentTable.Add(3, "Sam Brown");
            studentTable.Add(4, "Lisa White");
            studentTable.Add(5, "Tom Hanks");
            studentTable.Add(6, "Emma Watson");


            //PROPERTIES

            // get the number of key-value pairs in the hashtable
            Console.WriteLine("\nNumber of students: " + studentTable.Count);

            //Get value by key
            Console.WriteLine("\nStudent with ID 3: " + studentTable[3]);

            //Get all keys
            Console.WriteLine("\nAll Student IDs:");
            foreach (var key in studentTable.Keys)
            {
                Console.WriteLine(key);
            }

            //Get all values
            Console.WriteLine("\nAll Student Names:");
            foreach (var value in studentTable.Values)
            {
                Console.WriteLine(value);
            }

            //METHODS

            //Check if a key exists using ContainsKey
            bool keyExists = studentTable.ContainsKey(4);
            Console.WriteLine("\nDoes student with ID 4 exist? " + keyExists);

            //Check if a value exists using ContainsValue
            bool valueExists = studentTable.ContainsValue("Emma Watson");
            Console.WriteLine("\nDoes student 'Emma Watson' exist? " + valueExists);

            //Iterate through the hashtable using DictionaryEntry or var type
            Console.WriteLine("\nAll Students in the Hashtable:");
            foreach (DictionaryEntry entry in studentTable)
            {
                Console.WriteLine("ID: " + entry.Key + ", Name: " + entry.Value);
            }

            //Remove a student by key
            studentTable.Remove(2);
            Console.WriteLine("\nAfter removing student with ID 2, number of students: " + studentTable.Count);

            //Clear the hashtable
            studentTable.Clear();
            Console.WriteLine("\nAfter clearing, number of students: " + studentTable.Count);
        }
    }
}