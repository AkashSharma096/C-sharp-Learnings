public class Employee : IPerson
{
    public string personName { get; set; }
    public string personGender { get; set; }

    public int employeeId { get; set; }
    public double employeeSalary { get; set; }

    public void Display()
    {
        Console.WriteLine("Employee Name: " + personName);
        Console.WriteLine("Employee Gender: " + personGender);
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Employee Salary: " + employeeSalary);
    }
}