interface IInterface1
{
    void Method1();
    void Method2();
}

interface IInterface2 : IInterface1
{
    void Method3();
    void Method4();
}

class Class1 : IInterface1
{
    public void Method1()
    {
        // Implementation of Method1
        System.Console.WriteLine("Method1 implemented in Class1");
    }

    public void Method2()
    {
        // Implementation of Method2
        System.Console.WriteLine("Method2 implemented in Class1");
    }
}

class Class2 : IInterface2
{
    public void Method1()
    {
        System.Console.WriteLine("Method1 implemented in Class2");
    }

    public void Method2()
    {
        System.Console.WriteLine("Method2 implemented in Class2");
    }

    public void Method3()
    {
        System.Console.WriteLine("Method3 implemented in Class2");
    }

    public void Method4()
    {
        System.Console.WriteLine("Method4 implemented in Class2");
    }
}