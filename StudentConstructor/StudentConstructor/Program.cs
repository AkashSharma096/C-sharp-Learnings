class Program
{
    static void Main()
    {
        Student s1 = new Student(1, "Student1", 28);
        Student s2 = new Student(2, "Student2", 28);
        Student s3 = new Student(3, "Student3", 27);

        s1.PrintStudent();
        s2.PrintStudent();
        s3.PrintStudent();
    }
}