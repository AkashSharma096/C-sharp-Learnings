namespace Program
{
    public class Program
    {
        static void Main()
        {
            //Using full name to create object
            Namespace1.Namespace2.Namespace3.Person p1;
            p1 = new Namespace1.Namespace2.Namespace3.Person() { PersonName = "Rajesh" };

            //using var keyword to implicitly type object.
            var p2 = new Namespace1.Namespace2.Namespace3.Person() { PersonName = "Mahesh" };

            System.Console.WriteLine($"P1 Person Name : {p2.PersonName}");
            System.Console.WriteLine($"P2 Person Name : {p1.PersonName}");

            //using var keyword instead of string.. 
            var upperCaseName = p2.PersonName.ToUpper();

            System.Console.WriteLine($"P2 Upper Case Name : {upperCaseName}");
        }
    }
}