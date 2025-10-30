namespace AnonymousMethod.Events
{
    // create a deletegate type to create event.
    public delegate void NotifyType(int a, int b);

    // publisher class
    public class Publisher
    {
        // create an event with nullable using the delegate type
        public event NotifyType? NotifyEvent;

        // method to raise the event
        public void RaiseEvent(int a, int b)
        {
            // check if there are any subscribers
            if (NotifyEvent != null)
            {
                NotifyEvent(a, b); // raise the event
            }
            else
            {
                System.Console.WriteLine("No subscribers for the event.");
            }
        }
    }
}