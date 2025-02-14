
using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    public static List<Tuple<int, int>> FindZeroSumSubarrays(int[] arr)
    {
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        int sum = 0;
        sumMap[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sumMap.ContainsKey(sum))
            {
                foreach (int start in sumMap[sum])
                {
                    result.Add(Tuple.Create(start + 1, i));
                }
            }

            if (!sumMap.ContainsKey(sum))
            {
                sumMap[sum] = new List<int>();
            }
            sumMap[sum].Add(i);
        }

        return result;
    }

    public static void Main()
    {
        int[] arr = { 3, 4, -7, 1, 3, 3, 1, -4, -2, -2 };
        List<Tuple<int, int>> subarrays = FindZeroSumSubarrays(arr);

        foreach (var subarray in subarrays)
        {
            Console.WriteLine($"Subarray found from index {subarray.Item1} to {subarray.Item2}");
        }
    }
}

