namespace Boxing_Unboxing
{
    class Program
    {
        static void Main()
        {
            int number = 123;          // Value type

            System.Object obj;         // Reference type
            obj = number;              // Boxing

            System.Console.WriteLine("Value Type :  " + number);
            System.Console.WriteLine("Converted to Reference Type using Boxing");
            System.Console.WriteLine("Reference Type : " + obj);

            int number2;       // Value type
            number2 = (int)obj;     // Unboxing


            System.Console.WriteLine("\nReference Type : " + obj);
            System.Console.WriteLine("Converted back to Value Type using Unboxing");
            System.Console.WriteLine("Value Type : " + number2);
            bool b = number == number2;
            System.Console.WriteLine("Both Numbers are Equal ? : " + b);

        }
    }
}