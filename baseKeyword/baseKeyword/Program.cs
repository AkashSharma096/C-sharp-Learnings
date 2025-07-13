class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        person.personName = "John Doe";
        person.personGender = "Male";
        person.DisplayPerson();


        Student student = new Student();
        student.personName = "Jane Warner";
        student.personGender = "Female";
        student.studentId = "S12345";
        student.studentClass = "12th Grade";
        student.DisplayStudent();


        Employee employee = new Employee();
        employee.personName = "Alice Johnson";
        employee.personGender = "Female";
        employee.employeeId = "E67890";
        employee.employeeSalary = 75000.00;
        employee.DisplayEmployee();

    }
}