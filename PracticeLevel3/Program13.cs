using System;

class Program13
{
    static void Main(string[] args)
    {
        // Example usage
        int rows = 3;
        int cols = 3;

        double[,] matrixA = CreateRandomMatrix(rows, cols);
        double[,] matrixB = CreateRandomMatrix(rows, cols);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA);
        
        Console.WriteLine("Matrix B:");
        DisplayMatrix(matrixB);

        Console.WriteLine("Addition of A and B:");
        DisplayMatrix(AddMatrices(matrixA, matrixB));

        Console.WriteLine("Subtraction of A and B:");
        DisplayMatrix(SubtractMatrices(matrixA, matrixB));

        Console.WriteLine("Multiplication of A and B:");
        DisplayMatrix(MultiplyMatrices(matrixA, matrixB));

        Console.WriteLine("Transpose of Matrix A:");
        DisplayMatrix(Transpose(matrixA));

        Console.WriteLine($"Determinant of Matrix A (2x2 or 3x3): {Determinant(matrixA)}");

        if (rows == 2)
            Console.WriteLine("Inverse of Matrix A:");
            DisplayMatrix(Inverse2x2(matrixA));
        
        if (rows == 3)
            Console.WriteLine("Inverse of Matrix A:");
            DisplayMatrix(Inverse3x3(matrixA));
    }

    // Method to create a random matrix
    static double[,] CreateRandomMatrix(int rows, int cols)
    {
        Random rand = new Random();
        double[,] matrix = new double[rows, cols];
        
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = rand.NextDouble() * 10; // Random values between 0 and 10

        return matrix;
    }

    // Method to add two matrices
    static double[,] AddMatrices(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = a[i, j] + b[i, j];

        return result;
    }

    // Method to subtract two matrices
    static double[,] SubtractMatrices(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = a[i, j] - b[i, j];

        return result;
    }

    // Method to multiply two matrices
    static double[,] MultiplyMatrices(double[,] a, double[,] b)
    {
        int rowsA = a.GetLength(0);
        int colsA = a.GetLength(1);
        int colsB = b.GetLength(1);
        
        if (colsA != b.GetLength(0))
            throw new Exception("Incompatible matrices for multiplication.");

        double[,] result = new double[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
            for (int j = 0; j < colsB; j++)
                for (int k = 0; k < colsA; k++)
                    result[i, j] += a[i, k] * b[k, j];

        return result;
    }

    // Method to find the transpose of a matrix
    static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transposed = new double[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transposed[j, i] = matrix[i, j];

        return transposed;
    }

    // Method to find the determinant of a 2x2 matrix
    static double Determinant2x2(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            throw new Exception("Matrix must be 2x2.");
        
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    // Method to find the determinant of a 3x3 matrix
    static double Determinant3x3(double[,] matrix)
    {
       if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3)
           throw new Exception("Matrix must be 3x3.");

       return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
              matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
              matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
   }

   // Method to find the determinant of any square matrix
   static double Determinant(double[,] matrix)
   {
       if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
           return Determinant2x2(matrix);
       else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
           return Determinant3x3(matrix);
       else
           throw new Exception("Currently only supports determinants for matrices of size 2x2 or 3x3.");
   }

   // Method to find the inverse of a 2x2 matrix
   static double[,] Inverse2x2(double[,] matrix)
   {
       if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
           throw new Exception("Matrix must be 2x2.");

       double det = Determinant2x2(matrix);
       if (det == 0)
           throw new Exception("Matrix is singular and cannot be inverted.");

       return new double[,]
       {
           {matrix[1,1]/det , -matrix[0,1]/det},
           {-matrix[1,0]/det , matrix[0,0]/det}
       };
   }

   // Method to find the inverse of a 3x3 matrix
   static double[,] Inverse3x3(double[,] matrix)
   {
       if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3)
           throw new Exception("Matrix must be 3x3.");

       double det = Determinant3x3(matrix);
       if (det == 0)
           throw new Exception("Matrix is singular and cannot be inverted.");

       var invDet = 1.0 / det;

       return new double[,]
       {
           {
               invDet * (matrix[1,1]*matrix[2,2]-matrix[1,2]*matrix[2,1]),
               invDet * (matrix[0,2]*matrix[2,1]-matrix[0,1]*matrix[2,2]),
               invDet * (matrix[0,1]*matrix[1,2]-matrix[0,2]*matrix[1,1])
           },
           {
               invDet * (matrix[1,2]*matrix[2,0]-matrix[1,0]*matrix[2,2]),
               invDet * (matrix[0,0]*matrix[2,2]-matrix[0,2]*matrix[2,0]),
               invDet * (matrix[0,2]*matrix[1,0]-matrix[0,0]*matrix[1,2])
           },
           {
               invDet * (matrix[1][0]*matrix[2][1]-matrix[1][1]*matrix[2][0]),
               invDet * (matrix[0][1]*matrix[2][0]-matrix[0][0]*matrix[2][1]),
               invDet * (matrix[0][0]*matrix[1][1]-matrix[0][1]*matrix[1][0])
           }
       };
   }

   // Method to display a matrix
   static void DisplayMatrix(double[,] matrix)
   {
       int rows = matrix.GetLength(0);
       int cols = matrix.GetLength(1);

       for (int i = 0; i < rows; i++)
       {
           for (int j = 0; j < cols; j++)
               Console.Write($"{matrix[i,j]:F4} ");
           Console.WriteLine();
       }
       Console.WriteLine();
   }
}
