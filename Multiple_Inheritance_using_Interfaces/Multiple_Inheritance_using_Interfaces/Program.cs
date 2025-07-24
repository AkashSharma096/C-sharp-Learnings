using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //create a reference variable & object for child class
        var c1 = new Class1();

        //create reference variables for interface1.
        Iinterface1 i1;

        //Store the address of child class's object in the reference variable of interface1.
        i1 = c1;

        //call the interface1's method only
        i1.Method1();
        i1.Method2();


        //create reference variables for interface2.
        Iinterface2 i2;
        //Store the address of child class's object in the reference variable of interface2.
        i2 = c1;
        //call the interface2's method only
        i2.Method3();
        i2.Method4();

    }
}