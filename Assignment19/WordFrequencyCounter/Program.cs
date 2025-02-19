using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Dictionary<string, int> CountWordFrequency(string filePath)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string line in File.ReadLines(filePath))
        {
            string word = "";
            foreach (char c in line.ToLower()) 
            {
                if (char.IsLetterOrDigit(c))
                {
                    word += c;
                }
                else if (word.Length > 0) 
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;

                    word = ""; 
                }
            }
            if (word.Length > 0) 
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }
        }

        return wordCount;
    }

    static void Main()
    {
        string filePath = "D:\\Capgemini-Tranning\\Assignments\\Assignment19\\WordFrequencyCounter\\input.txt";

        if (File.Exists(filePath))
        {
            Dictionary<string, int> frequency = CountWordFrequency(filePath);

            Console.WriteLine("Word Frequency:");
            foreach (var pair in frequency)
            {
                Console.WriteLine($"\"{pair.Key}\": {pair.Value}");
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
