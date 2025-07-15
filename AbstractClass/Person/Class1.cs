public abstract class Person
{
    public string personName;
    public string personGender;


    public void Display()
    {
        Console.WriteLine("Person Name : " + this.personName);
        Console.WriteLine("Person Gender : " + this.personGender);
    }
}

public class Employee : Person
{
    public int empId;
    public double empSalary;
}

public class Student : Person
{
    public int studentId { get; set; }
    public int studentMarks { get; set; }
}