using System;

public class CalendarGenerator
{
    // Array to store the names of the months
    private static string[] months = 
    { 
        "January", "February", "March", "April", "May", "June", 
        "July", "August", "September", "October", "November", "December"
    };

    // Array to store the number of days in each month
    private static int[] daysInMonth = 
    { 
        31, 28, 31, 30, 31, 30, 
        31, 31, 30, 31, 30, 31
    };

    // Method to get the name of the month from the month number
    public static string GetMonthName(int month)
    {
        return months[month - 1];
    }

    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

   
    public static int GetDaysInMonth(int month, int year)
    {
        // If February and a leap year, return 29 days
        if (month == 2 && IsLeapYear(year))
        {
            return 29;
        }
        return daysInMonth[month - 1];
    }

   
    public static int GetStartingDay(int month, int year)
    {
        DateTime date = new DateTime(year, month, 1);
        return (int)date.DayOfWeek;
    }

 
    public static void DisplayCalendar(int month, int year)
    {
  
        string monthName = GetMonthName(month);
        
        int daysInMonth = GetDaysInMonth(month, year);
      
        int startingDay = GetStartingDay(month, year);

        // Display the calendar header
        Console.WriteLine($"Calendar for {monthName} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Print spaces for the starting day
        for (int i = 0; i < startingDay; i++)
        {
            Console.Write("    ");
        }

        // Print the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            
            Console.Write($"{day,3} ");

            
            if ((startingDay + day) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

    // Main method to get user input and display the calendar
    public static void Main()
    {
    
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());


        DisplayCalendar(month, year);
    }
}
