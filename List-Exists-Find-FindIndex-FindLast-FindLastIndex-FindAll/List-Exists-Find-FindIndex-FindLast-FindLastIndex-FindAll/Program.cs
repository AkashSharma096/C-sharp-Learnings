/************************************************************************************************************
This file demonstrate multiple Find methods on a List in C#.
It includes examples for Exists, Find, FindIndex, FindLast, FindLastIndex, and FindAll methods.

Syntax - 
1. Exists(Predicate<T> match): bool --> returns true if any element matches the predicate else false.
2. Find(Predicate<T> match): T --> returns the first element that matches the predicate.
3. FindIndex(Predicate<T> match): int --> returns the index of the first element that matches the predicate.
4. FindLast(Predicate<T> match): T --> returns the last element that matches the predicate.
5. FindLastIndex(Predicate<T> match): int --> returns the index of the last element that matches the predicate.
6. FindAll(Predicate<T> match): List<T> --> returns all elements that match the predicate as a List.

************************************************************************************************************/

using System;
using System.Collections.Generic;

namespace List_Exists_Find_FindIndex_FindLast_FindLastIndex_FindAll
{
    class Program
    {
        static void Main()
        {
            // create a list of sttudent's marks
            List<int> marks = new List<int>() { 85, 92, 78, 24, 67, 92, 45, 89, 16, 92 };

            // 1. Exists: Check if there is any mark greater than 90
            bool hasHighMarks = marks.Exists(mark => mark > 90);
            Console.WriteLine("Any mark greater than 90: " + hasHighMarks);

            // 2. Find: Get the first mark that is less than 50
            int firstLowMark = marks.Find(mark => mark < 50);
            Console.WriteLine("First mark less than 50: " + firstLowMark);

            // 3. FindIndex: Get the index of the first mark that is equal to 92
            int firstIndexOf92 = marks.FindIndex(mark => mark == 92);
            Console.WriteLine("Index of first mark equal to 92: " + firstIndexOf92);

            // 4. FindLast: Get the last mark that is greater than 80
            int lastHighMark = marks.FindLast(mark => mark > 80);
            Console.WriteLine("Last mark greater than 80: " + lastHighMark);

            // 5. FindLastIndex: Get the index of the last mark that is equal to 92
            int lastIndexOf92 = marks.FindLastIndex(mark => mark == 92);
            Console.WriteLine("Index of last mark equal to 92: " + lastIndexOf92);

            // 6. FindAll: Get all marks that are greater than or equal to 90
            var allHighMarks = marks.FindAll(mark => mark >= 90);
            Console.WriteLine("All marks greater than or equal to 90: " + string.Join(", ", allHighMarks));
        }
    }
}