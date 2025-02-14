using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    public static bool HasPairWithSum(int[] arr, int target)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];
            if (seenNumbers.Contains(complement))
            {
                return true;
            }
            seenNumbers.Add(arr[i]);
        }

        return false;
    }

    public static void Main()
    {
        int[] arr = { 10, 15, 3, 7 };
        int target = 17;
        Console.WriteLine(HasPairWithSum(arr, target));
    }
}

