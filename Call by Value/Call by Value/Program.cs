class Sample
{
    public void Method1(int x)
    {
        System.Console.WriteLine(x); //100
        x = 150;
        System.Console.WriteLine(x); // 150 - Argumentt variable changed here to 150 from 100.
    }
}

class Program
{
    static void Main()
    {
        Sample sample = new Sample();
        int a = 100;
        sample.Method1(a);
        System.Console.WriteLine(a); //100 - Original Value didn't changed with change in Argument variable.
    }

}