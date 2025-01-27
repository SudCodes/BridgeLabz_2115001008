//Q8. Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the percentage and then calculate the grade  as per the following guidelines 

// Hint => 
// Take input for the number of students
// Create arrays to store marks, percentages, and grades of the students
// Take input for marks of students in physics, chemistry, and maths. If the marks are negative, ask the user to enter positive values and decrement the index
// Calculate the percentage and grade of the students based on the percentage
// Display the marks, percentages, and grades of each student

using System;

class Program8
{
    // Function to calculate percentage and grade
    static void CalculateGrades(int[] physics, int[] chemistry, int[] maths, int[] percentages, string[] grades)
    {
        for (int i = 0; i < physics.Length; i++)
        {
            percentages[i] = (physics[i] + chemistry[i] + maths[i]) / 3;

            if (percentages[i] >= 80)
                grades[i] = "A";
            else if (percentages[i] >= 70)
                grades[i] = "B";
            else if (percentages[i] >= 60)
                grades[i] = "C";
            else if (percentages[i] >= 50)
                grades[i] = "D";
            else if (percentages[i] >= 40)
                grades[i] = "E";
            else
                grades[i] = "R";
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        int[] physics = new int[numStudents];
        int[] chemistry = new int[numStudents];
        int[] maths = new int[numStudents];
        int[] percentages = new int[numStudents];
        string[] grades = new string[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Enter marks for student {i + 1}: ");

            Console.Write("Physics: ");
            physics[i] = GetValidMarks();

            Console.Write("Chemistry: ");
            chemistry[i] = GetValidMarks();

            Console.Write("Maths: ");
            maths[i] = GetValidMarks();
        }

        CalculateGrades(physics, chemistry, maths, percentages, grades);

        Console.WriteLine("\nResults:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Student {i + 1}: Physics: {physics[i]}, Chemistry: {chemistry[i]}, Maths: {maths[i]}, Percentage: {percentages[i]}%, Grade: {grades[i]}");
        }
    }

    // Function to get valid marks
    static int GetValidMarks()
    {
        int marks;
        while (true)
        {
            marks = int.Parse(Console.ReadLine());
            if (marks >= 0)
                break;
            Console.WriteLine("Marks cannot be negative. Please enter again: ");
        }
        return marks;
    }
}

