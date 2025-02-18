using System;
using System.Diagnostics;

class SearchComparison
{
    public static bool LinearSearch(int[] arr, int target)
    {
        foreach (int num in arr)
        {
            if (num == target)
                return true;
        }
        return false;
    }

    public static bool BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return true;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }

    public static void Main()
    {
        int[] arr = new int[1000000];
        for (int i = 0; i < arr.Length; i++) arr[i] = i;
        int target = 999999;

        Stopwatch sw = Stopwatch.StartNew();
        LinearSearch(arr, target);
        sw.Stop();
        Console.WriteLine("Linear Search Time: " + sw.ElapsedMilliseconds + " ms");

        Array.Sort(arr);
        sw = Stopwatch.StartNew();
        BinarySearch(arr, target);
        sw.Stop();
        Console.WriteLine("Binary Search Time: " + sw.ElapsedMilliseconds + " ms");
    }
}

