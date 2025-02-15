using System;

class CountingSort
{
    static void Main()
    {
        int[] studentAges = { 12, 15, 10, 18, 14, 13, 16, 17, 11, 12, 15, 10 };
        Console.WriteLine("Original Student Ages: " + string.Join(", ", studentAges));

        int[] sortedAges = CountingSortAlgorithm(studentAges, 10, 18);

        Console.WriteLine("Sorted Student Ages: " + string.Join(", ", sortedAges));
    }

    static int[] CountingSortAlgorithm(int[] arr, int min, int max)
    {
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[arr.Length];

        foreach (int age in arr)
            count[age - min]++;

        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }

        return output;
    }
}
