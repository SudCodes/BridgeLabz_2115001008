// Class to handle countdown using a for loop
using System;
class Program9
{
    public void CountdownWithForLoop()
    {
        // Prompting the user to input the starting number for the countdown
        Console.Write("Enter the countdown start value: ");
        int startValue = Convert.ToInt32(Console.ReadLine());

        // Using a for loop to perform the countdown
        for (int i = startValue; i >= 1; i--)
        {
            Console.WriteLine(i); // Displaying the current loop value
        }

        // Indicating the end of the countdown
        Console.WriteLine("Liftoff!");
    }
}