class Program
{
    static void Main()
    {
        //create variable of "int" data type.
        int a = 100;
        //convert the value of "int" data type to "short" data type (highler to lower - Explicit Casting).
        short b;
        b = (short)a;

        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        System.Console.ReadKey();

    }
}