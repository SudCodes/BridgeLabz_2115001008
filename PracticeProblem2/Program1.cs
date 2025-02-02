using System;

class Program1
{
    public static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100.");
        GuessNumber();
    }

    public static void GuessNumber()
    {
        Random rand = new Random();
        int low = 1, high = 100;
        bool found = false;

        while (!found)
        {
            int guess = rand.Next(low, high + 1);
            Console.WriteLine("Is your number " + guess + "? (h for too high, l for too low, c for correct)");
            char response = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (response == 'c')
            {
                Console.WriteLine("Yay! I guessed it!");
                found = true;
            }
            else if (response == 'h')
            {
                high = guess - 1;
            }
            else if (response == 'l')
            {
                low = guess + 1;
            }
            else
            {
                Console.WriteLine("Please enter h, l, or c.");
            }
        }
    }
}
