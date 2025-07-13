public class Person
{
    public string personName { get; set; }
    public string personGender { get; set; }
}


public class Student : Person
{
    public string studentId { get; set; }
    public string studentGrade { get; set; }
}

public class Employee : Person
{
    public string employeeId { get; set; }
    public double employeeSalary { get; set; }
}