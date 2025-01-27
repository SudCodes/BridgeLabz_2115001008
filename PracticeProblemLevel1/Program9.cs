//Q9. Working with Multi-Dimensional Arrays. Write a C# program to create a 2D Array and Copy the 2D Array into a single dimension array
// Hint => 
// Take user input for rows and columns, create a 2D array (Matrix), and take the user input 
// Copy the elements of the matrix to a 1D array. For this create a 1D array of size rows*columns as in int[] array = new int[rows * columns];
// Define the index variable and Loop through the 2D array. Copy every element of the 2D array into the 1D array and increment the index
// Note: For looping through the 2D array, you will need Nested for loop, Outer for loop for rows, and the inner for loops to access each element


using System;

class Program9
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        string rowsInput = Console.ReadLine();
        Console.Write("Enter the number of columns: ");
        string colsInput = Console.ReadLine();

        // Validate input for rows and columns
        if (!int.TryParse(rowsInput, out int rows) || rows <= 0 ||
            !int.TryParse(colsInput, out int cols) || cols <= 0)
        {
            Console.Error.WriteLine("Error: Please enter valid positive integers for rows and columns.");
            Environment.Exit(1);
        }

        // Call function to create and populate 2D array
        int[,] matrix = CreateAndPopulateMatrix(rows, cols);

        // Call function to copy elements to 1D array
        int[] oneDArray = CopyMatrixTo1DArray(matrix);

        // Display the 1D array
        Console.WriteLine("\nThe elements of the 1D array are:");
        for (int i = 0; i < oneDArray.Length; i++)
        {
            Console.Write(oneDArray[i] + (i < oneDArray.Length - 1 ? ", " : "\n"));
        }
    }

    // Function to create and populate a 2D matrix
    static int[,] CreateAndPopulateMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter element at position [{i},{j}]: ");
                string elementInput = Console.ReadLine();

                if (!int.TryParse(elementInput, out matrix[i, j]))
                {
                    Console.Error.WriteLine("Error: Please enter a valid integer.");
                    Environment.Exit(1);
                }
            }
        }
        return matrix;
    }

    // Function to copy elements of a 2D matrix into a 1D array
    static int[] CopyMatrixTo1DArray(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] oneDArray = new int[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                oneDArray[index++] = matrix[i, j];
            }
        }
        return oneDArray;
    }
}
