class Program
{
    static void Main()
    {
        string s1 = "12345";
        string s2 = "Hyderabad-12345";

        int a1, a2;

        bool result1 = int.TryParse(s1, out a1);
        bool result2 = int.TryParse(s2, out a2);

        System.Console.WriteLine($"String {s1} comversion to int result - {result1} and output value is {a1}");
        System.Console.WriteLine($"String {s2} conversion to int result - {result2} and output value is {a2}");
    }
}