using System;

class InsertionSort
{
    static void Main()
    {
        int[] employeeIDs = { 105, 102, 110, 101, 108, 103, 107 };
        Console.WriteLine("Original Employee IDs: " + string.Join(", ", employeeIDs));

        InsertionSortAlgorithm(employeeIDs);

        Console.WriteLine("Sorted Employee IDs: " + string.Join(", ", employeeIDs));
    }

    static void InsertionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n-1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if(arr[j] < arr[j-1])
                {
                    (arr[j],arr[j-1]) = (arr[j-1],arr[j]);
                }
            }
        }
    }
}
