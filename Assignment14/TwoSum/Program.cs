using System;
using System.Collections.Generic;

class TwoSumProblem
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i };
            }
            if (!numMap.ContainsKey(nums[i]))
            {
                numMap[nums[i]] = i;
            }
        }

        return new int[] { -1, -1 };
    }

    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(nums, target);
        Console.WriteLine($"Indices: {result[0]}, {result[1]}");
    }
}



