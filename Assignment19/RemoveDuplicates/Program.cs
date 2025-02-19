using System;
using System.Collections.Generic;

class Program
{
    static List<int> RemoveDuplicates(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> uniqueList = new List<int>();

        foreach (int num in list)
        {
            if (!seen.Contains(num))
            {
                seen.Add(num);
                uniqueList.Add(num);
            }
        }
        return uniqueList;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 3, 1, 2, 2, 3, 4 };

        Console.WriteLine("Original List: " + string.Join(", ", numbers));
        List<int> uniqueNumbers = RemoveDuplicates(numbers);
        Console.WriteLine("List after removing duplicates: " + string.Join(", ", uniqueNumbers));
    }
}
