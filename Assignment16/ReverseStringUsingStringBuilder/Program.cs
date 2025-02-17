using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string reversed = ReverseString(input);
        Console.WriteLine("Reversed String: " + reversed);
    }

    static string ReverseString(string str)
    {
        StringBuilder sb = new StringBuilder(str);
        int length = sb.Length;

        for (int i = 0, j = length - 1; i < j; i++, j--)
        {
            char temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
        }

        return sb.ToString();
    }
}
