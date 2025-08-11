class Program
{
    static void Main()
    {
        Class1 obj = new Class1();

        // Calling the method from Iinterface1
        ((Iinterface1)obj).Method1();

        // Calling the method from Iinterface2
        ((Iinterface2)obj).Method1();
    }
}