using System.Reflection.Metadata;

namespace System.Object_class_methods
{
    class Class1
    {
        public override string ToString()
        {
            System.Console.WriteLine(base.GetHashCode());
            return "Class1.ToString";
        }
    }

    class Program
    {
        static void Main()
        {

            Class1 c1, c2;

            c1 = new Class1();
            c2 = new Class1();

            bool b = c1.Equals(c2);
            System.Console.WriteLine(b);

            int c = c1.GetHashCode();
            System.Console.WriteLine(c);

            string t = c1.GetType().ToString();
            System.Console.WriteLine(t);

            string s = c1.ToString();
            System.Console.WriteLine(s);

        }
    }
}