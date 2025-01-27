//Q7. Rewrite the above program using multi-dimensional array to store height, weight, and BMI in 2D array for all the persons
// Hint => 
// Take input for a number of persons
// Create a multi-dimensional array to store weight, height and BMI. Also create an to store the weight status of the persons
//        double[][] personData = new double[number][3];
//        String[] weightStatus = new String[number];
// Take input for weight and height of the persons and for negative values, ask the user to enter positive values
// Calculate BMI of all the persons and store them in the personData array and also find the weight status and put them in the weightStatus array
// Display the height, weight, BMI and status of each person

using System;

class Program7
{
    // Function to calculate BMI and determine weight status
    static void CalculateBMI(int numberOfPeople, double[][] personData, string[] weightStatus)
    {
        for (int i = 0; i < numberOfPeople; i++)
        {
            // BMI calculation: BMI = weight (kg) / height (m)^2
            double height = personData[i][0];
            double weight = personData[i][1];
            double bmi = weight / (height * height);

            // Store BMI in the 2D array
            personData[i][2] = bmi;

            // Determine weight status based on BMI
            if (bmi < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi >= 18.5 && bmi < 24.9)
                weightStatus[i] = "Normal weight";
            else if (bmi >= 25 && bmi < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }
    }

    static void Main()
    {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numberOfPeople = Convert.ToInt32(Console.ReadLine());

        // Create a multi-dimensional array to store height, weight, and BMI
        double[][] personData = new double[numberOfPeople][];
        for (int i = 0; i < numberOfPeople; i++)
        {
            personData[i] = new double[3];  // 3 columns: height, weight, BMI
        }

        // Create an array to store weight status
        string[] weightStatus = new string[numberOfPeople];

        // Take input for height and weight of each person
        for (int i = 0; i < numberOfPeople; i++)
        {
            Console.WriteLine($"\nEnter details for person {i + 1}:");

            // Input for height
            double height;
            do
            {
                Console.Write("Enter height (in meters): ");
                height = Convert.ToDouble(Console.ReadLine());
                if (height <= 0)
                {
                    Console.WriteLine("Height must be a positive value. Please enter again.");
                }
            } while (height <= 0);
            personData[i][0] = height;

            // Input for weight
            double weight;
            do
            {
                Console.Write("Enter weight (in kg): ");
                weight = Convert.ToDouble(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.WriteLine("Weight must be a positive value. Please enter again.");
                }
            } while (weight <= 0);
            personData[i][1] = weight;
        }

        // Call the function to calculate BMI and determine weight status
        CalculateBMI(numberOfPeople, personData, weightStatus);

        // Display the results for each person
        Console.WriteLine("\nDetails of persons:");
        Console.WriteLine("Person | Height (m) | Weight (kg) | BMI    | Weight Status");

        for (int i = 0; i < numberOfPeople; i++)
        {
            Console.WriteLine($"{i + 1,6} | {personData[i][0],10:F2} | {personData[i][1],12:F2} | {personData[i][2],6:F2} | {weightStatus[i]}");
        }
    }
}

