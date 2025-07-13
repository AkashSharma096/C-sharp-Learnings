public class Person
{
    public string personName { get; set; }
    public string personGender { get; set; }



    public void DisplayPerson()
    {
        Console.WriteLine($"Person Name: {this.personName}");

        Console.WriteLine($"Person Gender : {this.personGender}");
    }
}


public class Student : Person
{
    public string studentId { get; set; }
    public string studentClass { get; set; }

    public void DisplayStudent()
    {
        Console.WriteLine($"Student ID: {this.studentId}");
        Console.WriteLine($"Student Class: {this.studentClass}");
        Console.WriteLine($"Person Name: {base.personName}");
        Console.WriteLine($"Student Gender: {base.personGender}");
    }
}


public class Employee : Person
{
    public string employeeId { get; set; }
    public double employeeSalary { get; set; }

    public void DisplayEmployee()
    {
        Console.WriteLine($"Employee ID: {this.employeeId}");
        Console.WriteLine($"Employee Salary: {this.employeeSalary}");
        Console.WriteLine($"Person Name: {base.personName}");
        Console.WriteLine($"Employee Gender: {base.personGender}");
    }

}