namespace SystemObject_Class
{
    class Class1
    {
    }

    class Program
    {
        static void Main()
        {
            // Create a reference variable of "System.Object" type.
            System.Object obj;

            // Create an instance of "Class1" and assign it to the "System.Object" reference variable.
            obj = new Class1();

            System.Console.WriteLine("Done");
        }
    }
}