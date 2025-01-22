/*Write a program to find the side of the square whose perimeter you read from user
Hint: Perimeter of Square is 4 times side
I/P => perimeter
O/P => The length of the side is ___ whose perimeter is ____
*/

using System;

class SquareSide
{
    // Function to calculate the side of the square from the perimeter
    public static void CalculateSide(double perimeter)
    {
        // The formula for the perimeter of a square is: Perimeter = 4 * side
        // To find the side, we divide the perimeter by 4
        double side = perimeter / 4;

        // Output the result
        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }

    public static void Main()
    {
        // Prompt user to enter the perimeter of the square
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the side
        CalculateSide(perimeter);
    }
}
