namespace Classes
{
    public class Sample : System.IDisposable
    {

        public Sample()
        {
            // Constructor logic here
            System.Console.WriteLine("Sample class instantiated.");
        }

        public void PerformAction()
        {
            // Action logic here
            System.Console.WriteLine("Action performed.");
        }

        public void Dispose()
        {
            // Cleanup resources here
            System.Console.WriteLine("Resources cleaned up.");
        }
    }
}