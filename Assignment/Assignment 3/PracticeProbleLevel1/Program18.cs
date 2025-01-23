using System;
class Program18
{
    // Function to calculate and display the multiplication table from 6 to 9
    public void DisplayMultiplicationTable(int number)
    {
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}