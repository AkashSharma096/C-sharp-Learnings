namespace Static_Classes
{
    static class Class1
    {
        // static field
        public static string? Message { get; set; }

        // static constructor
        static Class1()
        {
            Message = "Hello from static class!";
        }

        // static method
        public static void ShowMessage()
        {
            System.Console.WriteLine("Class1.ShowMessage");
        }
    }
}