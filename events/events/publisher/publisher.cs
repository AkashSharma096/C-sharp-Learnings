namespace events.publisher
{

    //create delegate type
    public delegate void NotifyType(int a, int b);

    //create publisher class
    public class Publisher
    {
        //declare private delegate to hold event subscribers.
        private NotifyType? notify;

        //event accessor methods for adding and removing event handlers.
        public event NotifyType NotifyEvent
        {
            add
            {
                notify += value;
            }
            remove
            {
                notify -= value;
            }
        }

        //method to raise event
        public void RaiseEvent(int a, int b)
        {
            if (this.notify != null)
            {
                this.notify(a, b);
            }
            else
            {
                Console.WriteLine("No subscribers for the event.");
            }
        }
    }
}