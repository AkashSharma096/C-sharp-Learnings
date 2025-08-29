namespace StructureExample
{
    struct Student
    {
        public int Id;
        public string Name;
        public string marks;
    }

    class Program
    {
        public static void Main()
        {
            Student student1;

            student1.Id = 1;
            student1.Name = "John Doe";
            student1.marks = "A";

            System.Console.WriteLine($"ID: {student1.Id}, Name: {student1.Name}, Marks: {student1.marks}");
        }
    }
}