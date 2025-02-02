using System;

class Program4
{
    public static void Main()
    {
        // Prompt the user for the number of Fibonacci terms
        Console.Write("Enter the number of Fibonacci terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());
        
        // Generate and print the Fibonacci sequence
        GenerateFibonacci(terms);
    }

    // Function to generate and print the Fibonacci sequence
    public static void GenerateFibonacci(int terms)
    {
        int first = 0, second = 1, next;
        
        Console.WriteLine("Fibonacci Sequence:");
        
        for (int i = 0; i < terms; i++)
        {
            Console.Write(first + " "); 
            next = first + second; 
            first = second;
            second = next; 
        }
        
        Console.WriteLine(); 
    }
}
