using Persons;
using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();

            p1.noOfChildren = 2;
            p2.noOfChildren = null;
            p3.noOfChildren = 5;

            if (p1.noOfChildren.HasValue)
            {
                Console.WriteLine($"Object P1 children - {p1.noOfChildren}");
            }

            if (p2.noOfChildren.HasValue)
            {
                Console.WriteLine($"Object P2 children - {p2.noOfChildren}");
            }

            if (p3.noOfChildren.HasValue)
            {
                int x = p3.noOfChildren.Value;
                Console.WriteLine($"Object P3 children - {x}");
            }


        }
    }
}