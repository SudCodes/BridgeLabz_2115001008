//Q9. Rewrite the above program to store the marks of the students in physics, chemistry, and maths in a 2D array and then compute the percentage and grade
// Hint => 
// All the steps are the same as the problem 8 except the marks are stored in a 2D array
// Use the 2D array to calculate the percentages, and grades of the students

using System;

class Program9
{
    // Function to calculate percentage and grade
    static void CalculateGrades(int[,] marks, int[] percentages, string[] grades)
    {
        for (int i = 0; i < marks.GetLength(0); i++)
        {
            int totalMarks = 0;
            for (int j = 0; j < marks.GetLength(1); j++)
            {
                totalMarks += marks[i, j];
            }

            percentages[i] = totalMarks / marks.GetLength(1);

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

        int[,] marks = new int[numStudents, 3]; // 2D array to store marks in Physics, Chemistry, and Maths
        int[] percentages = new int[numStudents];
        string[] grades = new string[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Enter marks for student {i + 1}: ");

            Console.Write("Physics: ");
            marks[i, 0] = GetValidMarks();

            Console.Write("Chemistry: ");
            marks[i, 1] = GetValidMarks();

            Console.Write("Maths: ");
            marks[i, 2] = GetValidMarks();
        }

        CalculateGrades(marks, percentages, grades);

        Console.WriteLine("\nResults:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Student {i + 1}: Physics: {marks[i, 0]}, Chemistry: {marks[i, 1]}, Maths: {marks[i, 2]}, Percentage: {percentages[i]}%, Grade: {grades[i]}");
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
