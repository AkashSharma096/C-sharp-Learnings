public class Class1
{
    public virtual void Display()
    {
        System.Console.WriteLine("Class 1 - Display");
    }
}


public class Class2 : Class1
{
    public override void Display()
    {
        base.Display();
        System.Console.WriteLine("Class 2 - Display");
    }
}