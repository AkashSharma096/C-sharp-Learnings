class Program
{
    static void Main()
    {
        Person person = new Person();
        person.PersonAge = 25; // Valid age
        Console.WriteLine($"Person's age: {person.PersonAge}");
    }
}