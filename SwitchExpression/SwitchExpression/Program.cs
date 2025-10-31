// This code demonstrates the use of switch expressions in C# to assign values based on different cases.
// Switch expressions uses => syntax for concise case handling..
// The example assigns a string value based on an integer input.
// The default case is handled using the _ pattern.

namespace SwitchExpression
{
    class Program
    {
        static void Main()
        {
            // Example integer value
            int number = 3;

            // Using switch expression to assign a value based on the number
            string result = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Other" // Default case
            };

            // Output the result
            System.Console.WriteLine($"The result is: {result}");
        }
    }
}