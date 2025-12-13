/*********************************************************************************************************************
This file  demonstrates a simple stack implementation in C#.
Stack is a data structure that follows the Last In First Out (LIFO) principle.
Stack operations include Push (to add an item), Pop (to remove the top item), and Peek (to view the top item without removing it).

Syntax:
    - Stack<T> stack = new Stack<T>(); --> creates a new stack of type T.
    - Push: stack.Push(item); --> adds an item to the top of the stack.
    - Pop: item = stack.Pop(); --> removes and returns the top item from the stack.
    - Peek: item = stack.Peek(); --> returns the top item without removing it.

Namespace: System.Collections.Generic
*********************************************************************************************************************/
using System;
using System.Collections.Generic;

namespace StackExample
{
    public class Program
    {
        static void Main()
        {
            // create a stack of integers
            Stack<int> numberStack = new Stack<int>();

            // push items onto the stack
            numberStack.Push(10);
            numberStack.Push(20);
            numberStack.Push(30);
            numberStack.Push(40);

            // display the count of items in the stack
            Console.WriteLine("\nNumber of items in stack: " + numberStack.Count); // Output: Number of items in stack: 3

            // peek at the top item
            Console.WriteLine("\nTop item is: " + numberStack.Peek()); // Output: Top item is: 40

            //Iterate through the stack and display items
            Console.WriteLine("\nStack items:");
            foreach (int number in numberStack)
            {
                Console.WriteLine(number);
            }

            // pop items from the stack
            Console.WriteLine("\nPopping items from stack:");
            numberStack.Pop(); // removes 40
            Console.WriteLine("Popped top item. New top is: " + numberStack.Peek()); // Output: New top is: 30

            //Check if stack contains a specific item
            bool numExists = numberStack.Contains(20);
            Console.WriteLine("\nStack contains 20: " + numExists); // Output: Stack contains 20: True

            // clear the stack
            numberStack.Clear();
            Console.WriteLine("\nStack cleared. Number of items in stack: " + numberStack.Count); // Output: Number of items in stack: 0



        }
    }
}