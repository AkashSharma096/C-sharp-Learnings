using AutoImplementedEvents.eventHolder;

namespace AutoImplementedEvents
{
    public class Program
    {
        static void Main()
        {
            // Create publisher and subscriber objects
            Publisher publisher = new Publisher();
            Subscribers subscriber = new Subscribers();

            // Subscribe the target method to the event
            publisher.NotifyEvent += subscriber.AddNumbers;

            // Raise the event
            publisher.RaiseEvent(5, 10);

            // Unsubscribe the target method from the event
            publisher.NotifyEvent -= subscriber.AddNumbers;

            // Raise the event again to show that there are no subscribers
            publisher.RaiseEvent(20, 30);
        }
    }

}
