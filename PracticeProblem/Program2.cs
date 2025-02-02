using System;

class Program2
{
    static void Main()
    {
        Console.Write("Enter a date in yyyy-MM-dd format: ");
        DateTime inputDate;

        string userInput = Console.ReadLine();
        bool isValidDate = DateTime.TryParse(userInput, out inputDate);

        if (isValidDate)
        {
            // Adding 7 days, 1 month, and 2 years
            inputDate = inputDate.AddDays(7);
            inputDate = inputDate.AddMonths(1);
            inputDate = inputDate.AddYears(2);
            Console.WriteLine("Updated date after additions: " + inputDate.ToString("yyyy-MM-dd"));

            // Subtracting 3 weeks (21 days)
            inputDate = inputDate.AddDays(-21);
            Console.WriteLine("Final date after subtracting 3 weeks: " + inputDate.ToString("yyyy-MM-dd"));
        }
        else
        {
            Console.WriteLine("Oops! The date format is incorrect. Please enter a valid date in yyyy-MM-dd format.");
        }
    }
}
