using AnonymousMethod.Events;

namespace AnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // create publisher object
            Publisher publisher = new Publisher();

            // subscribe to the event using an anonymous method via delegate keyword. 
            // there is no need of subscribing class here.
            // store the delegate reference to unsubscribe later.
            NotifyType notifyDelegate = delegate (int a, int b)
            {
                System.Console.WriteLine($"Anonymous Method: Sum = {a + b}");
            };

            publisher.NotifyEvent += notifyDelegate;
            // raise the event
            publisher.RaiseEvent(5, 10);
            // unsubscribe from the event
            publisher.NotifyEvent -= notifyDelegate;
            // raise the event again to see if there are any subscribers
            publisher.RaiseEvent(20, 30);
        }
    }
}