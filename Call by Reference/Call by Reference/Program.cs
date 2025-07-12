class Sample
{
    public void Method1(ref int x)
    {
        System.Console.WriteLine(x); //100 - Argument value passed from Source class.
        x = 150;
        System.Console.WriteLine(x); //150 - Here Argument variable changed to 150 from 100.
    }
}


class Program
{
    static void Main()
    {
        Sample sample = new Sample();
        int a = 100;
        sample.Method1(ref a);
        System.Console.WriteLine(a); // 150 - Here Original Variable also changed to 150 due to call by reference.
    }
}