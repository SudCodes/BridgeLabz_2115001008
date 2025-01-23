using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks for Physics: ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Maths: ");
        int maths = int.Parse(Console.ReadLine());

        // Calculate total, average, and percentage
        int total = CalculateTotal(physics, chemistry, maths);
        double average = CalculateAverage(total);
        double percentage = CalculatePercentage(total);

        // Get grade and remarks
        (string grade, string remarks) = GetGradeAndRemarks(percentage);

        // Display results
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Total Marks: {total}/300");
        Console.WriteLine($"Average Marks: {average:F2}");
        Console.WriteLine($"Percentage: {percentage:F2}%");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Remarks: {remarks}");
    }

    static int CalculateTotal(int physics, int chemistry, int maths)
    {
        return physics + chemistry + maths;
    }

    static double CalculateAverage(int total)
    {
        return total / 3.0;
    }

    static double CalculatePercentage(int total)
    {
        return (total / 300.0) * 100;
    }

    static (string grade, string remarks) GetGradeAndRemarks(double percentage)
    {
        if (percentage >= 80)
        {
            return ("A", "Level 4, above agency-normalized standards");
        }
        else if (percentage >= 70)
        {
            return ("B", "Level 3, at agency-normalized standards");
        }
        else if (percentage >= 60)
        {
            return ("C", "Level 2, below but approaching agency-normalized standards");
        }
        else if (percentage >= 50)
        {
            return ("D", "Level 1, well below agency-normalized standards");
        }
        else if (percentage >= 40)
        {
            return ("E", "Level 1-, too below agency-normalized standards");
        }
        else
        {
            return ("R", "Remedial standards");
        }
    }