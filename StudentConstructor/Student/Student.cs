public class Student
{
    public int studentId;
    public string studentName;
    public int studentAge;


    //Parameterized Constructor for Student Class.
    public Student(int studentId, string studentName, int studentAge)
    {
        this.studentId = studentId;
        this.studentName = studentName;
        this.studentAge = studentAge;
    }

    public void PrintStudent()
    {
        System.Console.WriteLine("Student Id : " + this.studentId);
        System.Console.WriteLine("Student Name : " + this.studentName);
        System.Console.WriteLine("Student Age : " + this.studentAge);
    }

}