using PersonNamespace;

class Program
{
    static void Main()
    {
        Person person = new Person();

        person.PersonName = "Alice";
        person.Age = 30;
        person.AgeGroup = AgeGroupEnum.Adult;

        System.Console.WriteLine($"Name: {person.PersonName}");
        System.Console.WriteLine($"Age: {person.Age}");
        System.Console.WriteLine($"Age Group: {person.AgeGroup}");

    }
}