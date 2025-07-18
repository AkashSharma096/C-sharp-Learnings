class Program
{
    static void Main()
    {
        IPerson employee = new Employee();
        employee.personName = "John Doe";
        employee.personGender = "Male";
        ((Employee)employee).employeeId = 12345;
        ((Employee)employee).employeeSalary = 75000.00;
        employee.Display();

        IPerson student = new Student();
        student.personName = "Jane Smith";
        student.personGender = "Female";
        ((Student)student).studentId = 54321;
        ((Student)student).studentMarks = 95;
        student.Display();
    }
}
