/*Q1. Write a program to take user input for the age of all 10 students in a class and check whether the student can vote depending on his/her
      age is greater or equal to 18.
Hint => 
Define an array of 10 integer elements and take user input for the student's age. 
Loop through the array using the length property and for the element of the array check If the age is a negative number print an invalid age and if 18 or above, print The student with the age ___ can vote. Otherwise, print The student with the age ___ cannot vote.
*/

using System;

class Program1
{
    static void Main(string[] args)
    {
        // Define an array to store ages of 10 students
        int[] studentAges = new int[10];

        // Call method to collect ages
        CollectStudentAges(studentAges);

        // Call method to display voting eligibility
        DisplayVotingEligibility(studentAges);
    }

    // Method to collect student ages from user input
    static void CollectStudentAges(int[] studentAges)
    {
        Console.WriteLine("Enter the ages of 10 students:");

        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write($"Enter age for student {i + 1}: ");
            string input = Console.ReadLine();

            // Validate that input is a valid integer
            if (!int.TryParse(input, out studentAges[i]))
            {
                Console.Error.WriteLine("Invalid input. Please enter a valid integer value.");
                Environment.Exit(1); // Exit the program with an error
            }

            // Validate that age is not negative
            if (studentAges[i] < 0)
            {
                Console.Error.WriteLine("Invalid age. Age cannot be negative.");
                Environment.Exit(1); // Exit the program with an error
            }
        }
    }

    // Method to display voting eligibility of students
    static void DisplayVotingEligibility(int[] studentAges)
    {
        Console.WriteLine("\nVoting Eligibility Results:");

        for (int i = 0; i < studentAges.Length; i++)
        {
            if (studentAges[i] >= 18)
            {
                Console.WriteLine($"The student with age {studentAges[i]} can vote.");
            }
            else
            {
                Console.WriteLine($"The student with age {studentAges[i]} cannot vote.");
            }
        }
    }
}
