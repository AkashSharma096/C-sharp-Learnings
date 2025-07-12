class Sample
{
    public void Display(int number = 10)
    {
        Console.WriteLine($"The number is: {number}");
    }
}


class Program
{
    static void Main()
    {
        Sample sample = new Sample();
        sample.Display(50); // Calling with an argument
        sample.Display(100); // Calling with another argument
        sample.Display(); // Calling without an argument, should use default value

        System.Console.ReadKey(); // Wait for user input before closing
    }
}