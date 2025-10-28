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

            sample.printData<Employee>(emp);
            sample.printData<Student>(stu);
        }
    }



}