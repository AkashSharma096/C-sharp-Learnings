public class Student : IPerson
{
    public string personName { get; set; }
    public string personGender { get; set; }

    public int studentId { get; set; }
    public int studentMarks { get; set; }

    public void Display()
    {
        Console.WriteLine("Student Name: " + personName);
        Console.WriteLine("Student Gender: " + personGender);
        Console.WriteLine("Student ID: " + studentId);
        Console.WriteLine("Student Marks: " + studentMarks);
    }
}