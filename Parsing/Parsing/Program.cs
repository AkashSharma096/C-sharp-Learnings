
class Program
{
    static void Main()
    {
        string s = "100";

        int a;

        a = int.Parse(s);

        System.Console.WriteLine($"Data type of {s} is {s.GetType()}");
        System.Console.WriteLine($"Data type of {a} is {a.GetType()}");
    }
}