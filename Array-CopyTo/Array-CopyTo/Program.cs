/******************************************************************************************************
This is an example of how to use the Array.CopyTo method in C#. The CopyTo method copies all the elements
of the current one-dimensional Array to the specified one-dimensional Array starting at the specified 
destination Array index.

Syntax = sourceArray.CopyTo(destinationArray, destinationIndex);

Parameters:
- sourceArray: The one-dimensional Array that contains the elements to copy to the 
    destination Array. 
- destinationArray: The one-dimensional Array that is the destination of the elements copied from
    the current Array.
- destinationIndex: A 32-bit integer that represents the index in the destination Array at which
    copying begins.  
******************************************************************************************************/
using Array_CopyTo.Employees;
using System;

namespace Array_CopyTo
{
    public class Program
    {
        static void Main()
        {
            // Create and initialize a source array storing Employee objects.
            Employee[] sourceArray = new Employee[3]
            {
                new Employee() { Id = 101, Name = "Mark" },
                new Employee() { Id = 102, Name = "John" },
                new Employee() { Id = 103, Name = "Mary" }
            };

            // Create a destination array to copy the elements to.
            Employee[] destinationArray = new Employee[5];

            // Copy the elements of the source array to the destination array starting at index 1.
            sourceArray.CopyTo(destinationArray, 0);

            // Display the elements of the destination array.
            Console.WriteLine("Elements of the destination array:");
            foreach (Employee emp in destinationArray)
            {
                if (emp != null)
                {
                    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}");
                }
            }
        }
    }
}