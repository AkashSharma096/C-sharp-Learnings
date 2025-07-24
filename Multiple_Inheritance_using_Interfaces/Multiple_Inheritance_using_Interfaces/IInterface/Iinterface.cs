interface Iinterface1
{
    void Method1();
    void Method2();
}

interface Iinterface2
{
    void Method3();
    void Method4();
}

class Class1 : Iinterface1, Iinterface2
{
    public void Method1()
    {
        // Implementation of Method1
        System.Console.WriteLine("Method1 from Iinterface1");
    }

    public void Method2()
    {
        // Implementation of Method2
        System.Console.WriteLine("Method2 from Iinterface1");
    }

    public void Method3()
    {
        // Implementation of Method3
        System.Console.WriteLine("Method3 from Iinterface2");
    }

    public void Method4()
    {
        // Implementation of Method4
        System.Console.WriteLine("Method4 from Iinterface2");
    }
}