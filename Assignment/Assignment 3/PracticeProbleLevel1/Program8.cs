// Creating a project named PracticeProblemsLevel1

using System;

// Class to handle countdown using a while loop
class Program8
{
    internal static bool CountdownUsingWhile(int startValue)
    {
        throw new NotImplementedException();
    }

    public void CountdownWithWhileLoop()
    {
        // Prompting the user to input the starting number for the countdown
        Console.Write("Enter the countdown start value: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        // Using a while loop to perform the countdown
        while (counter >= 1)
        {
            Console.WriteLine(counter); // Displaying the current counter value
            counter--; // Decrementing the counter
        }

        // Indicating the end of the countdown
        Console.WriteLine("Liftoff!");
    }
}