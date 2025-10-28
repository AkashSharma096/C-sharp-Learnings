using generics;

namespace generic_method
{
    class Program
    {
        static void Main()
        {
            Sample sample = new Sample();
            Employee emp = new Employee() { salary = 1000 };
            Student stu = new Student() { marks = 80 };

            System.Console.WriteLine("Employee Salary : ");
            sample.printData<Employee>(emp);
            System.Console.WriteLine("Student Marks : ");
            sample.printData<Student>(stu);
        }
    }



}