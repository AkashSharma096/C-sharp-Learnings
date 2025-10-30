namespace AutoImplementedEvents.eventHolder
{
    // Define a delegate type for the event
    public delegate void NotifyEventType(int a, int b);

    // Define a publisher class that contains an event
    public class Publisher
    {
        // Declare an event of the delegate type. This is an auto-implemented event. It automatically 
        // creates the accessor methods for adding and removing event handlers and also private delegate
        // instance to hold the list of event handlers.
        public event NotifyEventType? NotifyEvent;

        //Method to raise the event
        public void RaiseEvent(int a, int b)
        {
            //Check if there are any subscribers
            if (NotifyEvent != null)
            {
                NotifyEvent(a, b); //Raise the event
            }
            else
            {
                System.Console.WriteLine("No subscribers for the event.");
            }
        }
    }
}