using System;
using System.Diagnostics;

class SortingComparison
{
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    public static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;
        while (i <= mid && j <= right)
            temp[k++] = arr[i] < arr[j] ? arr[i++] : arr[j++];
        while (i <= mid)
            temp[k++] = arr[i++];
        while (j <= right)
            temp[k++] = arr[j++];
        for (i = left, k = 0; i <= right; i++, k++)
            arr[i] = temp[k];
    }

    public static void Main()
    {
        int[] arr1 = new int[10000], arr2 = new int[10000];
        Random rand = new Random();
        for (int i = 0; i < arr1.Length; i++)
            arr1[i] = arr2[i] = rand.Next(1, 10000);

        Stopwatch sw = Stopwatch.StartNew();
        BubbleSort(arr1);
        sw.Stop();
        Console.WriteLine("Bubble Sort Time: " + sw.ElapsedMilliseconds + " ms");

        sw = Stopwatch.StartNew();
        MergeSort(arr2, 0, arr2.Length - 1);
        sw.Stop();
        Console.WriteLine("Merge Sort Time: " + sw.ElapsedMilliseconds + " ms");
    }
}