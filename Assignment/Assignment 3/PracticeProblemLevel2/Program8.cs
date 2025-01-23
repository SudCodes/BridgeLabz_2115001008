using System;

class Program
{
    static void Main(string[] args)
    {
        // Input ages
        Console.Write("Enter age of Amar: ");
        int ageAmar = int.Parse(Console.ReadLine());

        Console.Write("Enter age of Akbar: ");
        int ageAkbar = int.Parse(Console.ReadLine());

        Console.Write("Enter age of Anthony: ");
        int ageAnthony = int.Parse(Console.ReadLine());

        // Input heights
        Console.Write("Enter height of Amar in cm: ");
        double heightAmar = double.Parse(Console.ReadLine());

        Console.Write("Enter height of Akbar in cm: ");
        double heightAkbar = double.Parse(Console.ReadLine());

        Console.Write("Enter height of Anthony in cm: ");
        double heightAnthony = double.Parse(Console.ReadLine());

        // Find the youngest friend
        string youngestFriend = FindYoungestFriend(ageAmar, ageAkbar, ageAnthony);
        int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));

        // Find the tallest friend
        string tallestFriend = FindTallestFriend(heightAmar, heightAkbar, heightAnthony);
        double tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));

        // Display results
        Console.WriteLine($"\nThe youngest friend is {youngestFriend} with an age of {youngestAge} years.");
        Console.WriteLine($"The tallest friend is {tallestFriend} with a height of {tallestHeight} cm.");
    }

    static string FindYoungestFriend(int ageAmar, int ageAkbar, int ageAnthony)
    {
        if (ageAmar < ageAkbar && ageAmar < ageAnthony)
        {
            return "Amar";
        }
        else if (ageAkbar < ageAmar && ageAkbar < ageAnthony)
        {
            return "Akbar";
        }
        else
        {
            return "Anthony";
        }
    }

    static string FindTallestFriend(double heightAmar, double heightAkbar, double heightAnthony)
    {
        if (heightAmar > heightAkbar && heightAmar > heightAnthony)
        {
            return "Amar";
        }
        else if (heightAkbar > heightAmar && heightAkbar > heightAnthony)
        {
            return "Akbar";
        }
        else
        {
            return "Anthony";
        }
    }
}