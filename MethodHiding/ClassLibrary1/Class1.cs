public class Class1
{
    public void Display()
    {
        System.Console.WriteLine("Hello from Class1!");
    }
}



public class Class2 : Class1
{
    public new void Display()
    {
        System.Console.WriteLine("Hello from Class2!");
    }
}