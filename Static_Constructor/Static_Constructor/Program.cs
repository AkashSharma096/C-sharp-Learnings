namespace StaticConstructor
{
    class Class1
    {
        public static int a, b;

        static Class1()
        {
            a = 10;
            b = 20;
        }
    }

    class Program
    {
        static void Main()
        {

            //Note: Static constructor is called only once here as Class1 is accessed first time inside Main method.

            //Get Data from Static fields initialized by Static Constructor.
            System.Console.WriteLine("Value of a: " + Class1.a);
            System.Console.WriteLine("Value of b: " + Class1.b);
        }
    }
}