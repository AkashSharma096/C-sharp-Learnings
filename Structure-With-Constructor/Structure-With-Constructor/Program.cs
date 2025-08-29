namespace Structure_With_Constructor
{
    struct Student
    {
        public int Id;
        public string Name;
        public int Marks;
        public string Grade;

        public Student(int id, string name, int marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
            Grade = "None";
        }

        public void CalculateGrade()
        {
            if (Marks >= 90)
                Grade = "A";
            else if (Marks >= 80)
                Grade = "B";
            else if (Marks >= 70)
                Grade = "C";
            else if (Marks >= 60)
                Grade = "D";
            else
                Grade = "F";
        }

    }

    class Program
    {
        public static void Main()
        {
            Student student = new Student(1, "John Doe", 85);
            student.CalculateGrade();
            System.Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Marks: {student.Marks}, Grade: {student.Grade}");
        }
    }

}