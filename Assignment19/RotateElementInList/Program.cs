using System;
using System.Collections.Generic;

class Program
{
    static List<int> RotateList(List<int> list, int positions)
    {
        int n = list.Count;
        positions %= n;

        List<int> rotatedList = new List<int>();

        rotatedList.AddRange(list.GetRange(positions, n - positions));

        rotatedList.AddRange(list.GetRange(0, positions));

        return rotatedList;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int rotateBy = 2;

        Console.WriteLine("Original List: " + string.Join(", ", numbers));
        List<int> rotatedList = RotateList(numbers, rotateBy);
        Console.WriteLine("Rotated List: " + string.Join(", ", rotatedList));
    }
}
