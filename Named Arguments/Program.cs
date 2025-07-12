using System.Security.Principal;

class Sample
{
    public void CalculateInterest(int principal, double rate, int time)
    {
        // Calculate simple interest
        double interest = (principal * rate * time) / 100;
        Console.WriteLine($"The calculated interest is: {interest}");
    }
}


class Program
{
    static void Main()
    {
        Sample sample = new Sample();
        sample.CalculateInterest(principal:1000, time:3, rate:10); // named arguments used here
    }
}