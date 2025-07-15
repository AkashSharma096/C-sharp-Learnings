class Program
{
    static void Main()
    {
        Employee e = new Employee();
        e.personName = "Adam";
        e.personGender = "Male";
        e.empId = 12345;
        e.empSalary = 80000;

        e.Display();
        System.Console.WriteLine("Employee Id : " + e.empId);
        System.Console.WriteLine("Employee Salary : " + e.empSalary);
        System.Console.WriteLine("\n");


        Student s = new Student();
        s.personName = "Alice";
        s.personGender = "Female";
        s.studentId = 101;
        s.studentMarks = 85;

        s.Display();
        System.Console.WriteLine("Student Id : " + s.studentId);
        System.Console.WriteLine("Student Marks : " + s.studentMarks);
        System.Console.WriteLine("\n");
    }
}