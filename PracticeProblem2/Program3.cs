using System;

class Program3
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }

    public static bool IsPrime(int num)
    {
        if (num < 2)
            return false;
        
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        
        return true;
    }
}
