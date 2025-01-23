using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter weight in kg: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height in cm: ");
        double heightInCm = double.Parse(Console.ReadLine());

        // Convert height from cm to meters
        double heightInMeters = heightInCm / 100;

        // Calculate BMI
        double bmi = weight / (heightInMeters * heightInMeters);

        // Determine weight status
        string status;
        if (bmi < 18.5)
        {
            status = "Underweight";
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            status = "Normal weight";
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            status = "Overweight";
        }
        else
        {
            status = "Obesity";
        }

        // Display result
        Console.WriteLine("\n--- BMI Result ---");
        Console.WriteLine($"BMI: {bmi:F2}");
        Console.WriteLine($"Weight Status: {status}");
    }
}