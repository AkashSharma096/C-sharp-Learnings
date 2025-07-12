class Program
{
    static void Main()
    {
        Student s1 = new Student() { studentId = 1, studentName = "Student1", studentAge = 28 };
        Student s2 = new Student() { studentId = 2, studentName = "Student2", studentAge = 29 };
        Student s3 = new Student() { studentId = 3, studentName = "Student3", studentAge = 30 };



        System.Console.WriteLine("\n========================\n");
        s1.PrintStudent();
        System.Console.WriteLine("\n========================\n");
        s2.PrintStudent();
        System.Console.WriteLine("\n========================\n");
        s3.PrintStudent();
        System.Console.WriteLine("\n========================\n"); 
    }
}