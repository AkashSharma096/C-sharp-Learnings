using Persons;
using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Person p1 = new Person() { noOfChildren = 2 };
            Person p2 = new Person() { noOfChildren = null };
            Person p3 = new Person() { noOfChildren = 5 };

            Console.WriteLine("\nONE WAY : using ? -\n");

            Console.WriteLine($"P1 object childrens - {(p1.noOfChildren.HasValue ? p1.noOfChildren.Value : 0)}");
            Console.WriteLine($"P2 object childrens - {(p2.noOfChildren.HasValue ? p2.noOfChildren.Value : 0)}");
            Console.WriteLine($"P3 object childrens - {(p3.noOfChildren.HasValue ? p3.noOfChildren.Value : 0)}");

            Console.WriteLine("\n\nAnother WAY : using ?? -\n");

            Console.WriteLine($"P1 object childrens - {(p1.noOfChildren ?? 0)}");
            Console.WriteLine($"P2 object childrens - {(p2.noOfChildren ?? 0)}");
            Console.WriteLine($"P3 object childrens - {(p3.noOfChildren ?? 0)}");

        }
    }
}