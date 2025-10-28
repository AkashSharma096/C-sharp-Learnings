namespace generics
{
    public class Student
    {
        public int marks { get; set; }
    }

    public class Employee
    {
        public int salary { get; set; }
    }

    public class Sample
    {
        public void printData<T>(T obj) where T : class
        {
            if (obj.GetType() == typeof(Student))
            {
                Student temp = obj as Student;
                System.Console.WriteLine(temp.marks);
            }
            else if (obj.GetType() == typeof(Employee))
            {
                Employee temp = obj as Employee;
                System.Console.WriteLine(temp.salary);
            }

        }
    }
}