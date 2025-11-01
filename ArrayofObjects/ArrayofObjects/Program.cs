/******************************************************************************************************
This is example of array of objects in C#.

Syntax:
ClassName[] arrayName = new ClassName[size] { new ClassName(), new ClassName(), .... };

Example:
Employee[] employees = new Employee[3]{ new Employee(), new Employee(), new Employee() }; 

******************************************************************************************************/
using ArrayofObjects.Employees;
using System;

namespace ArrayofObjects
{
    public class Program
    {
        static void Main()
        {
            // Creating an array of Employee objects directly. 
            Employee[] employees = new Employee[3]
            {
                new Employee() { Id = 1, Name = "Alice" },
                new Employee() { Id = 2, Name = "Bob" },
                new Employee() { Id = 3, Name = "Charlie" }
            };

            // new way of initializing array of objects in C#.
            Employee[] employees_2 =
            [
                new() { Id = 1, Name = "Alice" },
                new() { Id = 2, Name = "Bob" },
                new() { Id = 3, Name = "Charlie" }
            ];

            // Displaying the employee details using foreach loop.
            Console.WriteLine("Using foreach loop:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Employee ID: {emp.Id}, Name: {emp.Name}");
            }

            // Display the employee details using for loop.
            Console.WriteLine("\nUsing for loop:");
            for (int i = 0; i < employees_2.Length; i++)
            {
                Console.WriteLine($"Employee ID: {employees_2[i].Id}, Name: {employees_2[i].Name}");
            }
        }
    }
}