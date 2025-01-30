/*Palindrome String Check
Problem:
Write a C# program to check if a given string is a palindrome (a string that reads the
same forward and backward).
*/

using System;

class Program3{
    public static void Main(string[] args){
        Console.Write("Enter a string : ");
        string str = Console.ReadLine() ?? "";
        if(checkPalindrome(str)){
            Console.WriteLine("String is palindrome");
        }
        else{
            Console.WriteLine("String is not palindrome");
        }
    }
    public static Boolean checkPalindrome(string str){
        int left = 0;
        int right = str.Length-1;
        while (left < right){
            if(!str[left++].Equals(str[right--]))
            return false;
        }
        return true;

    }
}


