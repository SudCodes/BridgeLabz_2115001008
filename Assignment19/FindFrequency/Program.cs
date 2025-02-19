﻿using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> GetFrequency(List<string> items)
    {
        Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

        foreach (string item in items)
        {
            if (frequencyMap.ContainsKey(item))
                frequencyMap[item]++;
            else
                frequencyMap[item] = 1;
        }

        return frequencyMap;
    }

    static void Main()
    {
        List<string> items = new List<string> { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> frequency = GetFrequency(items);

        foreach (var pair in frequency)
        {
            Console.WriteLine($"\"{pair.Key}\": {pair.Value}");
        }
    }
}
