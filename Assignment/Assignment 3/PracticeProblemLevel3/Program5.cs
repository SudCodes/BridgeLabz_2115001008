using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the month (1-12): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Enter the day (1-31): ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Enter the year: ");
        int y = int.Parse(Console.ReadLine());

        int dayOfWeek = GetDayOfWeek(m, d, y);
        Console.WriteLine($"The day of the week is: {dayOfWeek}");
    }

    static int GetDayOfWeek(int m, int d, int y)
    {
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;
        return d0;
    }
}