class Program
{
    static void Main()
    {

        /************* Creating object for Parent class ***************/
        Person p = new Person();
        p.personName = "Jane Doe";
        p.personGender = "Male";

        System.Console.WriteLine($"Person Name: {p.personName}");
        System.Console.WriteLine($"Person Gender: {p.personGender}");

        /************* Creating object for Child classes *****************/

        // Creating object for Student class
        Student s = new Student();
        s.personName = "John Smith";
        s.personGender = "Male";
        s.studentId = "S12345";
        s.studentGrade = "A";

        System.Console.WriteLine($"Student Name: {s.personName}");
        System.Console.WriteLine($"Student Gender : {s.personGender}");
        System.Console.WriteLine($"Student ID: {s.studentId}");
        System.Console.WriteLine($"Student Grade: {s.studentGrade}");


        // Creating object for Employee class
        Employee e = new Employee();
        e.personName = "Alice Johnson";
        e.personGender = "Female";
        e.employeeId = "E67890";
        e.employeeSalary = 75000.00;

        System.Console.WriteLine($"Employee Name: {e.personName}");
        System.Console.WriteLine($"Employee Gender: {e.personGender}");
        System.Console.WriteLine($"Employee ID: {e.employeeId}");
        System.Console.WriteLine($"Employee Salary: {e.employeeSalary}");

        System.Console.ReadLine();

    }
}