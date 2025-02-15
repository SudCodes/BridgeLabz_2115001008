using System;

class QuickSort
{
    static void Main()
    {
        int[] productPrices = { 999, 199, 499, 799, 299, 150 };
        Console.WriteLine("Original Product Prices: " + string.Join(", ", productPrices));

        QuickSortAlgorithm(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("Sorted Product Prices: " + string.Join(", ", productPrices));
    }

    static void QuickSortAlgorithm(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSortAlgorithm(arr, low, pi - 1);
            QuickSortAlgorithm(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }
}