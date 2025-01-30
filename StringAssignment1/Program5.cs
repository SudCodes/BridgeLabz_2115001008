/*5. Find the Longest Word in a Sentence
Problem:
Write a C# program that takes a sentence as input and returns the longest word in the
sentence.
*/
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine() ?? "";
        
        Console.WriteLine($"Longest word in the sentence is: {findLongestWord(sentence)}");
    }

    public static string findLongestWord(string sentence)
    {
        int wordCount = 0;
        int longestWordCount = 0;
        string word = "";
        string longestWord = "";
        Console.WriteLine(sentence.Length);


        for(int i = 0; i < sentence.Length; i++){
            if(sentence[i] != ' '){
                wordCount++;
                word += sentence[i];
            }
            else{
                if(wordCount > longestWordCount){
                    longestWordCount = wordCount;
                    longestWord = word;
                }
                Console.WriteLine(longestWord);
                wordCount = 0;
                word = "";
            }
        }
        if (wordCount > longestWordCount)
        {
            longestWord = word;
        }

        return longestWord;
    }
}