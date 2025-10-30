using EventWithLambdaExpression.Events;
using System;

namespace EventWithLambdaExpression
{

    public class Program
    {
        static void Main()
        {
            // Create an instance of the publisher
            Publisher publisher = new Publisher();

            //store the lambda expressions in variables
            NotifyType add = (a, b) => a + b;
            NotifyType multiply = (a, b) => a * b;

            // Subscribe to the event using a lambda expression.
            publisher.NotifyEvent += add; // Subscriber 1: Addition

            // Subscribe another handler using a lambda expression.
            publisher.NotifyEvent += multiply; // Subscriber 2: Multiplication

            // Raise the event and get the result from the last subscriber.
            int sumResult = publisher.RaiseEvent(5, 10);
            Console.WriteLine($"Sum Result: {sumResult}");

            // Raise the event again to see the effect of multiple subscribers.
            int productResult = publisher.RaiseEvent(5, 10);
            Console.WriteLine($"Product Result: {productResult}");

            // Unsubscribe from the event
            publisher.NotifyEvent -= add;
            publisher.NotifyEvent -= multiply;

            // Raise the event again to see that there are no subscribers
            publisher.RaiseEvent(5, 10);

        }
    }
}