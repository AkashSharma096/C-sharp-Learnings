class Sample
{
    public void Add(int a, int b)
    {
        // This is a add method that adds two integers
        int result = a + b;
        Console.WriteLine($"The result of adding {a} and {b} is: {result}");
    }

    public void Add(string a, string b)
    {
        //This is overloading of add method that concatenates two strings.
        string result = a + b;
        System.Console.WriteLine($"The result of concatenating '{a}' and '{b}' is: '{result}'");
    }

    public void Add(int a, string b)
    {
        //This is overloading of add method that concatenates two strings.
        string result = a + b;
        System.Console.WriteLine($"The result of concatenating '{a}' and '{b}' is: '{result}'");
    }
}

class Program
{
    static void Main()
    {
        Sample sample = new Sample();
        
        // Calling the add method with integers
        sample.Add(5, 10);
        
        // Calling the add method with strings
        sample.Add("Hello, ", "World!");

        // Calling the add method with a mix of integers and strings
        sample.Add(42, " is the answer.");
    }
}