class Program
{
    static void Main()
    {
        Person person = new Person();
        person.personName = "John Doe";
        person.personAge = 30;

        Console.WriteLine($"Name: {person.personName}, Age: {person.personAge}");
    }
}