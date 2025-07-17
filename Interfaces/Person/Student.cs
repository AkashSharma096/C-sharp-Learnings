public class Student : IPerson
{
    public string PersonName { get; set; }
    public string PersonGender { get; set; }

    public int StudentId { get; set; }
    public int StudentMarks { get; set; }

    public void Display()
    {
        Console.WriteLine("Student Name: " + PersonName);
        Console.WriteLine("Student Gender: " + PersonGender);
        Console.WriteLine("Student ID: " + StudentId);
        Console.WriteLine("Student Marks: " + StudentMarks);
    }
}