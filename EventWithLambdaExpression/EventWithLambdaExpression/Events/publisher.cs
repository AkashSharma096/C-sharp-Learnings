using System;

namespace EventWithLambdaExpression.Events
{
    // Step 1 : Create a delegate type for the event.
    public delegate int NotifyType(int a, int b);  // delegate

    // Step 2 : Create a publisher class that contains the event.
    public class Publisher
    {
        //Step 3 : Declare the event using the delegate type.
        public event NotifyType? NotifyEvent;

        //Step 4 : Create a method to raise the event.
        public int RaiseEvent(int a, int b)
        {
            if (NotifyEvent != null)
            {
                int result = NotifyEvent(a, b); // Invoking the event
                return result;
            }
            else
            {
                Console.WriteLine("No subscribers for the event.");
                return 0;
            }
        }
    }
}