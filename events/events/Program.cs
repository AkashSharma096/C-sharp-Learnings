using events.publisher;
using events.subscriber;

namespace events
{
    class Program
    {
        static void Main()
        {
            //create publisher and subscriber objects
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            //subscribe to event 
            publisher.NotifyEvent += subscriber.AddNumbers;

            //invoke the event.
            publisher.RaiseEvent(10, 20);

            //unsubscribe from event
            publisher.NotifyEvent -= subscriber.AddNumbers;

            //invoke the event again. No subscribers now. log will be shown.
            publisher.RaiseEvent(30, 40);
        }
    }
}