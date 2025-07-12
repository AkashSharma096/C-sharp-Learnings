class Person
{
    public int age;
}

class Sample
{
    public void Birthday(Person person)
    {
        person.age++;
    }
}


class Program
{
    static void Main()
    {
        Person person = new Person();
        Sample sample = new Sample();

        person.age = 20;
        sample.Birthday(person); //Reference variable passed tp method here as an argument.


        System.Console.WriteLine($"Person's age: {person.age}"); // Output: Person's age: 21
        System.Console.ReadKey();
    }
}
