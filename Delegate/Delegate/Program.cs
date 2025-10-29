using Deligate.Classes;

namespace Deligate
{
    class Program
    {
        static void Main()
        {
            //create object of sample class
            Sample s = new Sample();

            //create delegate object
            MyDeligatetype deligate;

            //assign the method to delegate            
            deligate = new MyDeligatetype(s.add);

            //invoke the delegate
            int result = deligate.Invoke(10, 20);

            //print the results
            System.Console.WriteLine("The result is: " + result);
        }
    }
}