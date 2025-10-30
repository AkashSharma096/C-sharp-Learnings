using events.publisher;

namespace events.subscriber
{
    public class Subscriber
    {
        //target method to be called when event is raised.
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

    }
}