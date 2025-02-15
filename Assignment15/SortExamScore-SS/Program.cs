using System;

class SelectionSort
{
    static void Main()
    {
        int[] examScores = { 85, 72, 96, 63, 88, 91, 77 };
        Console.WriteLine("Original Exam Scores: " + string.Join(", ", examScores));

        SelectionSortAlgorithm(examScores);

        Console.WriteLine("Sorted Exam Scores: " + string.Join(", ", examScores));
    }

    static void SelectionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }

            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
        }
    }
}
