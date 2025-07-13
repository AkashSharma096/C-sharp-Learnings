class Program
{
    static void Main()
    {
        Person person = new Person();
        person.SetpersonAge(30);
        Console.WriteLine($"Person's age is: {person.GetpersonAge()}");
    }
}