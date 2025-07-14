public class Person
{
    public string name { get; set; }
    public int age { get; set; }
    public string gender { get; set; }

    public Person(string name, int age, string gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }
}

public class Student : Person
{
    public string studentID { get; set; }
    public int marks { get; set; }

    public Student(string name, int age, string gender, string studentID, int marks) : base(name, age, gender)
    {
        this.studentID = studentID;
        this.marks = marks;

    }
    public void DisplayStudentInfo()
    {
        Console.WriteLine("Student Name : " + base.name);
        Console.WriteLine("Student Age : " + base.age);
        Console.WriteLine("Student Gender : " + base.gender);
        Console.WriteLine("Student ID : " + this.studentID);
        Console.WriteLine("Student Marks : " + this.marks);
    }
}



public class Employee : Person
{
    public int employeeID { get; set; }
    public int employeeSalary { get; set; }



    public Employee(string name, int age, string gender, int employeeID, int employeeSalary) : base(name, age, gender)
    {
        this.employeeID = employeeID;
        this.employeeSalary = employeeSalary;
    }
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine("Employee Name : " + base.name);
        Console.WriteLine("Employee Age : " + base.age);
        Console.WriteLine("Employee Gender : " + base.gender);
        Console.WriteLine("Employee ID : " + this.employeeID);
        Console.WriteLine("Employee Salary : " + this.employeeSalary);
    }

}






