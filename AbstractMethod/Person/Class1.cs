public abstract class Person
{
    public required string PersonName { get; set; }
    public required string PersonGender { get; set; }

    public abstract void Display();
}


public class Employee : Person
{
    public int EmployeeId { get; set; }
    public double EmployeeSalary { get; set; }

    public override void Display()
    {
        Console.WriteLine("Employee Name : " + base.PersonName);
        Console.WriteLine("Employee Gender : " + base.PersonGender);
        Console.WriteLine("Employee ID : " + this.EmployeeId);
        Console.WriteLine("Employee Salary : " + this.EmployeeSalary);
        Console.WriteLine("\n");
    }
}

public class Student : Person
{
    public int StudentId { get; set; }
    public int StudentMarks { get; set; }

    public override void Display()
    {
        Console.WriteLine("Student Name : " + base.PersonName);
        Console.WriteLine("Student Gender : " + base.PersonGender);
        Console.WriteLine("Student ID : " + this.StudentId);
        Console.WriteLine("Student Marks : " + this.StudentMarks);
        Console.WriteLine("\n");
    }
}