/* Create a program to find the maximum number of handshakes among N number of students.
Hint:
Get integer input for numberOfStudents variable.
Use the combination = (n * (n - 1)) / 2 formula to calculate the maximum number of possible handshakes.
Display the number of possible handshakes.
*/

using System;

class HandshakeCalculator
{
    // Function to calculate the maximum number of handshakes
    public static void CalculateHandshakes(int numberOfStudents)
    {
        // Calculate the maximum number of handshakes using the combination formula
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Output the result
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + handshakes);
    }

    public static void Main()
    {
        // Prompt user to enter the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Call the function to calculate the number of handshakes
        CalculateHandshakes(numberOfStudents);
    }
}
