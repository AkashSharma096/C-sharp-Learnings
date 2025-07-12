using System.Diagnostics;

class Sample
{
    public void Method1(out int x)
    {
        x = 150;
        System.Console.WriteLine(x); //150 - Argument Variable.
    }
}


class Program
{
    static void Main()
    {
        Sample sample = new Sample();
        int a;
        sample.Method1(out a);
        System.Console.WriteLine(a); // 150 - Original variable changed with argument variable due to call by output.
    }
}