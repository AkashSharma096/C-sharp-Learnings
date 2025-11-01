/******************************************************************************************************
This is an example of how to clone an array in C#.
It demonstrates the use of the Clone() method to create a shallow copy of an array. 
The example includes an Employee class to illustrate cloning an array of objects.

Syntax: DestinationArray = (DataType[])SourceArray.Clone();
 Parameters:
    - SourceArray: The array to be cloned.
    - DataType: The type of elements in the array.
    - DestinationArray: The new array that is a clone of the SourceArray.

Clone returns an object, so it needs to be cast back to the appropriate array type. 
it creates a shallow copy of the array, meaning that it copies the references of the objects in the array, not the objects themselves.
******************************************************************************************************/

using System;
using Array_Clone.Employees;

namespace Array_Clone
{
    public class Program
    {
        static void Main()
        {
            // Creatingg and initializing an array of Employee objects
            Employee[] employees = new Employee[3]
            {
                new Employee() { Id = 1, Name = "Alice" },
                new Employee() { Id = 2, Name = "Bob" },
                new Employee() { Id = 3, Name = "Charlie" }
            };


            // Cloning the array of Employee objects and casting it back to Employee[] type.
            Employee[] clonedEmployees = (Employee[])employees.Clone();

            // Displaying the original and cloned arrays
            Console.WriteLine("Original Employees Array:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}");
            }

            Console.WriteLine("\nCloned Employees Array:");
            foreach (var emp in clonedEmployees)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}");
            }
        }
    }
}