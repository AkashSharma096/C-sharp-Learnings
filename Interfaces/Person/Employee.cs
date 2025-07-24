using System.Runtime.InteropServices;

public class Employee : IPerson
{
    public string PersonName { get; set; }
    public string PersonGender { get; set; }

    public int EmployeeId { get; set; }
    public double EmploeeSalary { get; set; }

    public void Display()
    {
        Console.WriteLine("Employee Name: " + PersonName);
        Console.WriteLine("Employee Gender: " + PersonGender);
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Employee Salary: " + EmploeeSalary);
    }
}