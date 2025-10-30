namespace AutoImplementedEvents.eventHolder
{
    public class Subscribers
    {
        // create the target methods to subscribe to the event
        public void AddNumbers(int a, int b)
        {
            System.Console.WriteLine($"Addition: {a + b}");
        }
    }

}