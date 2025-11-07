/**************************************************************************************************
This is an example of a C# program that demonstrates the use of the List<T>.AddRange method to add multiple elements to a list.

Syntax - MyList.AddRange(IEnumerable<T> OtherCollection)

Parameters:
    OtherCollection: An IEnumerable<T> collection containing the elements to add to the end of the List<T>.
    MyList: The List<T> to which the elements will be added.

Return Value - This method does not return a value.

Example:
    List<int> numbers = new List<int>() { 1, 2, 3 };
    List<int> moreNumbers = new List<int>() { 4, 5, 6 };
    numbers.AddRange(moreNumbers);
**************************************************************************************************/
using System;
using System.Collections.Generic;

namespace List_AddRange
{
    public class Pro
    {
        static void Main()
        {
            // create a list of integers
            List<int> numbers = new List<int>(3) { 1, 2, 3 };

            // create another list of integers to add
            List<int> moreNumbers = new List<int>(3) { 4, 5, 6 };


            // add the elements of moreNumbers to numbers
            numbers.AddRange(moreNumbers);

            // display the elements of numbers
            Console.WriteLine("Elements of numbers list after AddRange:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}