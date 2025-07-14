class Program
{
    static void Main()
    {
        Student s = new Student("Allen", 20, "Male", "S12345", 85);
        s.DisplayStudentInfo();
        Console.WriteLine("\n");


        Employee e = new Employee("Sarah", 25, "Female", 101, 50000);
        e.DisplayEmployeeInfo();
        Console.WriteLine("\n");
    }
}