class Program
{
    static void Main(string[] args)
    {
        Class1 c1 = new Class1();

        IInterface1 i1 = c1;
        i1.Method1();
        i1.Method2();

        System.Console.WriteLine("\n");
        Class2 c2 = new Class2();
        IInterface2 i2 = c2;
        i2.Method1();
        i2.Method2();
        i2.Method3();
        i2.Method4();
        System.Console.WriteLine("\nAll methods executed successfully.");
    }
}