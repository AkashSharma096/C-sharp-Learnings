class Program
{
    static void Main()
    {
        IPerson person1 = new Employee();
        person1.PersonName = "John Doe";
        person1.PersonGender = "Male";
        ((Employee)person1).EmployeeId = 12345;
        ((Employee)person1).EmploeeSalary = 75000.00;
        person1.Display();

        IPerson person2 = new Student();
        person2.PersonName = "Jane Smith";
        person2.PersonGender = "Female";
        ((Student)person2).StudentId = 54321;
        ((Student)person2).StudentMarks = 95;
        person2.Display();
    }

}
