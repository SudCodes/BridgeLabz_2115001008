using System;

class BubbleSort
{
    static void Main()
    {
        int[] marks = { 85, 72, 96, 63, 88, 91, 77 };
        Console.WriteLine("Original Marks: " + string.Join(", ", marks));

        BubbleSortAlgorithm(marks);

        Console.WriteLine("Sorted Marks: " + string.Join(", ", marks));
    }

    static void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap elements
                    (arr[j+1], arr[j]) = (arr[j], arr[j+1]);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
}
