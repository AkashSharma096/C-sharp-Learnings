using Static_Classes;


class Program
{
    static void Main()
    {
        System.Console.WriteLine("\n" + Class1.Message);
        Class1.ShowMessage();

        System.Console.WriteLine("\n\nAfter updating the Message property:\n");

        Class1.Message = "Updated Message";
        System.Console.WriteLine(Class1.Message);
        Class1.ShowMessage();
    }
}