class Program
{
    static void Main()
    {
        //A variable of "lower numerical data type" i.e short (2 bytes).
        short a = 100;
        //A variable of "higher numerical data type" i.e int (4 bytes).
        int b;

        //short to int = lower to higher = implicit casting
        b = a;

        System.Console.WriteLine(a); //output = 100;
        System.Console.WriteLine(b); // output = 100;
        System.Console.ReadKey();
    }
}