using Delegate.multiCast.Samples;

namespace Delegate.multiCast
{
    class Program
    {
        static void Main()
        {
            // Create an instance of Sample class
            Sample s = new Sample();

            // Create delegate instance
            myDelegateType del;

            // Assign methods to the delegate
            del = s.add;
            // Multicast: Add another method to the delegate invocation list
            del += s.multiply;

            // Invoke the delegate
            del(5.0, 10.0);
        }
    }
}