/*2. Reverse a String
Problem:
Write a C# program to reverse a given string without using any built-in reverse functions.
*/

using System;

class Program2{
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine() ?? " ";

        Console.WriteLine($"Reverse string of {str} is: {ReverseString(str)}");        
    }

    public static string ReverseString(string str){
        char[] charArray = str.ToCharArray();
        int left = 0;
        int right = charArray.Length-1;

        while(left < right){
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;
            right--;
        }
        string reversedString = "";
        foreach(char c in charArray){
            reversedString+=c;
        }
        return reversedString;
    }
}