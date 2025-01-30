using System;

class Program12
{
    public static void Main()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine() ?? "";

        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine() ?? "";

        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine() ?? "";

        string modifiedSentence = ReplaceWordInSentence(sentence, oldWord, newWord);
        Console.WriteLine($"Modified Sentence: {modifiedSentence}");
    }

    // Method to replace a word in a sentence without using Replace()
    public static string ReplaceWordInSentence(string sentence, string oldWord, string newWord)
    {
        string result = "";
        string currentWord = "";
        int sentenceLength = 0, oldWordLength = 0;

        // Manually find lengths
        while (sentenceLength < sentence.Length) sentenceLength++;
        while (oldWordLength < oldWord.Length) oldWordLength++;

        for (int i = 0; i <= sentenceLength; i++)
        {
            // Check for space or end of sentence
            if (i == sentenceLength || sentence[i] == ' ')
            {
                // Compare the word manually
                bool isMatch = true;
                if (currentWord.Length == oldWordLength)
                {
                    for (int j = 0; j < oldWordLength; j++)
                    {
                        if (currentWord[j] != oldWord[j])
                        {
                            isMatch = false;
                            break;
                        }
                    }
                }
                else
                {
                    isMatch = false;
                }

                // Append new word if matched, else append original word
                result += isMatch ? newWord : currentWord;
                if (i != sentenceLength) result += " ";

                // Reset currentWord
                currentWord = "";
            }
            else
            {
                currentWord += sentence[i];
            }
        }

        return result;
    }
}
