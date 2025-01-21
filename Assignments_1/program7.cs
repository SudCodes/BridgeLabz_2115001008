//Q7. Write a program to calculate the perimeter of a rectangle. Take the length and width as inputs and use the formula:

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * (length + width);

        Console.WriteLine("The perimeter of the rectangle is " + perimeter);
    }
}



