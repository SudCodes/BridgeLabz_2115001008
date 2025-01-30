/*Toggle Case of Characters
Problem:
Write a C# program to toggle the case of each character in a given string. Convert
uppercase letters to lowercase and vice versa.*/


using System;

class Program7
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the String: ");
        string str = Console.ReadLine() ?? "";     

        Console.WriteLine($"After toggling the string {str}, it becomes : {toggleString(str)}");   
    }

    public static string toggleString(string str){
        string toggeledString = "";

        foreach(char c in str){
            if(Char.IsUpper(c)){
                toggeledString+= char.ToLower(c);
            }
            else
                toggeledString+= char.ToUpper(c);

        }
        return toggeledString;
    }
}
