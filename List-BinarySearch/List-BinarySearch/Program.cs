/**************************************************************************************************
This Program demonstrates a binary search algorithm on a sorted list of integers.

Syntax - 
   * int index = sortedList.BinarySearch(target);

Parameters:
- index: An integer representing the position of the target element in the list if found.
- sortedList: A List<int> containing sorted integers in ascending order.
- target: An integer value to search for in the sortedList.

Returns:
   * Index of Searched Element --> If the target is found in the list.
   * -1 --> If the target is not found in the list. 

**************************************************************************************************/

using System;
using System.Collections.Generic;

namespace List_BinarySearch
{
    class Program
    {
        static void Main()
        {
            // Sample sorted list of integers
            List<int> sortedList = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            // Target value to search for
            int target = 7;

            // Perform binary search
            int resultIndex = sortedList.BinarySearch(target);

            // Output the result
            if (resultIndex != -1)
            {
                Console.WriteLine($"Element {target} found at index: {resultIndex}");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the list.");
            }

            // Sample sorted list with duplicates
            List<int> sortedListWithDuplicates = new List<int> { 2, 4, 4, 4, 6, 8, 10 };
            int targetDuplicate = 4;

            // Perform binary search for duplicates
            int resultIndexDuplicates = sortedListWithDuplicates.BinarySearch(targetDuplicate);

            // scan for all occurrences of the target
            if (resultIndexDuplicates != -1)
            {
                Console.WriteLine($"Element {targetDuplicate} found at index: {resultIndexDuplicates}");

                // Check for other occurrences
                int leftIndex = resultIndexDuplicates - 1;
                while (leftIndex >= 0 && sortedListWithDuplicates[leftIndex] == targetDuplicate)
                {
                    Console.WriteLine($"Element {targetDuplicate} also found at index: {leftIndex}");
                    leftIndex--;
                }

                // Check right side
                int rightIndex = resultIndexDuplicates + 1;
                while (rightIndex < sortedListWithDuplicates.Count && sortedListWithDuplicates[rightIndex] == targetDuplicate)
                {
                    Console.WriteLine($"Element {targetDuplicate} also found at index: {rightIndex}");
                    rightIndex++;
                }
            }


            // Add usage of Contains method for comparison
            int searchValue = 10;
            if (sortedList.Contains(searchValue))
            {
                Console.WriteLine($"Element {searchValue} exists in the list.");
            }
            else
            {
                Console.WriteLine($"Element {searchValue} does not exist in the list.");
            }
        }
    }
}