class Program
{
    static void Main()
    {
        Employee emp = new Employee
        {
            PersonName = "John Doe",
            PersonGender = "Male",
            EmployeeId = 12345,
            EmployeeSalary = 85000.00
        };

        emp.Display();

        Student stu = new Student
        {
            PersonName = "Jane Smith",
            PersonGender = "Female",
            StudentId = 54321,
            StudentMarks = 88
        };

        stu.Display();

    }
}