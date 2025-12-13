/*********************************************************************************************************************
This file demonstrates a simple queue implementation in C# using generics.
A queue is a data structure that follows the First In First Out (FIFO) principle.
Queues are commonly used in scenarios such as task scheduling, breadth-first search algorithms,
and buffering data streams.

Syntax:
  - Create: Queue<T> queue = new Queue<T>();
  - Enqueue: queue.Enqueue(item);
  - Dequeue: T item = queue.Dequeue();
  - Peek: T item = queue.Peek();
  - Count: int count = queue.Count;
  - Contains: bool exists = queue.Contains(item);
  - Clear: queue.Clear();

Namespace: System.Collections.Generic

Example:
  Queue<int> queue = new Queue<int>();
    queue.Enqueue(1);
    queue.Enqueue(2);
*********************************************************************************************************************/

using System;
using System.Collections.Generic;

namespace QueueExample
{
    public class Program
    {
        static void Main()
        {
            // create a queue of string values
            Queue<string> queue = new Queue<string>();

            // add elements to the queue
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");
            queue.Enqueue("Fifth");
            queue.Enqueue("Sixth");

            // display the number of elements in the queue
            Console.WriteLine("\nNumber of elements in the queue: " + queue.Count);

            //Iterate through the queue and display each element
            Console.WriteLine("\nElements in the queue:");
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }

            //Return the first element without removing it
            Console.WriteLine("\nFirst element (Peek): " + queue.Peek());
            Console.WriteLine("Number of elements in the queue after Peek: " + queue.Count);

            //Remove and return the first element
            Console.WriteLine("\nRemoving element (Dequeue): " + queue.Dequeue());
            Console.WriteLine("Number of elements in the queue after Dequeue: " + queue.Count);
            Console.WriteLine("New first element after Dequeue: " + queue.Peek());

            //Check if an element exists in the queue
            bool containsThird = queue.Contains("Third");
            Console.WriteLine("\nQueue contains 'Third': " + containsThird);

            //Clear all elements from the queue
            queue.Clear();
            Console.WriteLine("\nNumber of elements in the queue after Clear: " + queue.Count);
        }
    }
}