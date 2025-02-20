using System;
using System.Collections.Generic;
using System.IO;

class WordCounter
{
    static void Main()
    {
        string filePath = "input.txt"; // Path to the text file

        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File does not exist.");
                return;
            }

            Dictionary<string, int> wordFrequency = CountWords(filePath);

            // Manually sort words by frequency
            List<KeyValuePair<string, int>> sortedWords = SortByFrequency(wordFrequency);

            // Display top 5 most frequent words
            Console.WriteLine("\nTop 5 Most Frequent Words:");
            for (int i = 0; i < Math.Min(5, sortedWords.Count); i++)
            {
                Console.WriteLine($"{sortedWords[i].Key}: {sortedWords[i].Value}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File operation failed: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static Dictionary<string, int> CountWords(string filePath)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string word = "";
            while (!reader.EndOfStream)
            {
                char c = (char)reader.Read(); // Read character by character

                if (char.IsLetterOrDigit(c)) // Build words manually
                {
                    word += char.ToLower(c);
                }
                else if (word.Length > 0) // If a word is completed
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                    word = ""; // Reset word
                }
            }

            if (word.Length > 0) // Add last word if present
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }
        }

        return wordCount;
    }

    static List<KeyValuePair<string, int>> SortByFrequency(Dictionary<string, int> wordCount)
    {
        List<KeyValuePair<string, int>> wordList = new List<KeyValuePair<string, int>>();

        // Convert Dictionary to List manually
        foreach (var pair in wordCount)
        {
            wordList.Add(pair);
        }

        // Manual Sorting (Bubble Sort)
        for (int i = 0; i < wordList.Count - 1; i++)
        {
            for (int j = 0; j < wordList.Count - i - 1; j++)
            {
                if (wordList[j].Value < wordList[j + 1].Value) // Sort by frequency (descending)
                {
                    var temp = wordList[j];
                    wordList[j] = wordList[j + 1];
                    wordList[j + 1] = temp;
                }
            }
        }

        return wordList;
    }
}
