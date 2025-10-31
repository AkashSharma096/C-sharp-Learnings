/************************************************************************************
 This is an example of using a for-each loop to iterate through an array in C#.

 Syntax: 
    foreach (type variable in array)
    {
        Console.WriteLine(variable); --> Code to be executed for each element. 
    }
************************************************************************************/

using System;
namespace ArrayWithForEachLoop
{
    public class Program
    {
        static void Main()
        {
            // Declare and initialize the array of numbers.
            int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

            // Use a for-each loop to iterate through the array and print each element.
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(); // Print a blank line for better readability.

            //Declare and initialize the array of strings
            string[] fruits = new string[5] { "Apple", "Banana", "Mango", "Orange", "Grapes" };

            // Use a for-each loop to iterate through the array and print each element.
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}