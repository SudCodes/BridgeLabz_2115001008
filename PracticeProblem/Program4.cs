using System;

class Program4
{
    static void Main()
    {
        Console.WriteLine("Enter first date (yyyy-MM-dd):");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter second date (yyyy-MM-dd):");
        string input2 = Console.ReadLine();

        DateTime date1, date2;
        
        if (DateTime.TryParse(input1, out date1) && DateTime.TryParse(input2, out date2))
        {
            int result = DateTime.Compare(date1, date2);
            
            if (result < 0)
            {
                Console.WriteLine("First date is before the second date.");
            }
            else if (result > 0)
            {
                Console.WriteLine("First date is after the second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the same.");
            }
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter dates in yyyy-MM-dd format.");
        }
    }
}