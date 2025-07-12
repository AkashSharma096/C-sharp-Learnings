class Hyderabad
{
    public string charminar = "Hyderabad Charminar";
    public string golconda = "Hyderabad Golconda";
}

class India
{
    // Addinfg Reference variable/object of one class (Hyderabad) as field in another class (India).
    public Hyderabad hyd = new Hyderabad();
}

class Program
{
    static void Main()
    {
        India ind = new India();
        System.Console.WriteLine(ind.hyd.charminar);
        System.Console.WriteLine(ind.hyd.golconda);
        System.Console.ReadKey();
    }
}