/*6. Find Substring Occurrences
Problem:
Write a C# program to count how many times a given substring occurs in a string.*/

using System;

class Program6
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string: ");
        string str = Console.ReadLine() ?? "";

        Console.Write("Enter the substring: ");
        string subStr = Console.ReadLine() ?? "";


        Console.WriteLine($"No. of substring {subStr} occurs in a string {str} is : {findOccurrenceOfSubString(str, subStr)}");
    }

    public static int findOccurrenceOfSubString(string str, string subStr)
    {
        //Using sliding window technique.
        int subStrLength = subStr.Length;
        int subStringOccurrence = 0;
        //we are adding all the character in the given range to the tempString
        for(int i = 0; i < str.Length - subStrLength + 1; i++){
            string tempString = "";
            for(int j = 0; j < subStrLength; j++){
                tempString += str[i+j];
            }
            //After comparing if it returns true the increment the subStringOccurrence.
            if(string.Equals(subStr, tempString))
            subStringOccurrence++;
        }
        
        //After getting result return the occurrence 
        
        return subStringOccurrence;
    }
}
