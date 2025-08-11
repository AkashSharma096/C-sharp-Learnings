public interface Iinterface1
{
    void Method1();
}

public interface Iinterface2
{
    void Method1();
}

public class Class1 : Iinterface1, Iinterface2
{
    void Iinterface1.Method1()
    {
        // Implementation for Iinterface1
        Console.WriteLine("Method1 from Iinterface1");
    }

    void Iinterface2.Method1()
    {
        // Implementation for Iinterface2
        Console.WriteLine("Method1 from Iinterface2");
    }
}