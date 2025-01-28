using System;

public class Program12
{
    // Method to generate random 2-digit scores for Physics, Chemistry, and Math
    public static double[,] GenerateRandomScores(int numStudents)
    {
        Random rand = new Random();
        double[,] scores = new double[numStudents, 3];  // 3 subjects: Physics, Chemistry, Math

        for (int i = 0; i < numStudents; i++)
        {
            scores[i, 0] = rand.Next(50, 101); // Physics score between 50 and 100
            scores[i, 1] = rand.Next(50, 101); // Chemistry score between 50 and 100
            scores[i, 2] = rand.Next(50, 101); // Math score between 50 and 100
        }

        return scores;
    }

    // Method to calculate total, average, and percentage for each student
    public static double[,] CalculateResults(double[,] scores)
    {
        int numStudents = scores.GetLength(0);
        double[,] results = new double[numStudents, 4];  // 4 columns: total, average, percentage

        for (int i = 0; i < numStudents; i++)
        {
            double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3;
            double percentage = (total / 300) * 100;

            // Round off values to 2 decimal places
            results[i, 0] = Math.Round(total, 2);
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }

        return results;
    }

    // Method to display the scorecard in a tabular format
    public static void DisplayScorecard(double[,] scores, double[,] results)
    {
        int numStudents = scores.GetLength(0);
        
        Console.WriteLine("Student No.\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage");

        for (int i = 0; i < numStudents; i++)
        {
            double physics = scores[i, 0];
            double chemistry = scores[i, 1];
            double math = scores[i, 2];
            double total = results[i, 0];
            double average = results[i, 1];
            double percentage = results[i, 2];

            Console.WriteLine($"{i + 1}\t\t{physics}\t{chemistry}\t\t{math}\t{total}\t{average}\t{percentage}%");
        }
    }

    // Main method to execute the program
    public static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Step 1: Generate random scores for all students
        double[,] scores = GenerateRandomScores(numStudents);

        // Step 2: Calculate total, average, and percentage for each student
        double[,] results = CalculateResults(scores);

        // Step 3: Display the scorecard in a tabular format
        DisplayScorecard(scores, results);
    }
}
