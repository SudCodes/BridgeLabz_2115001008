using System;
using System.Diagnostics;

class FibonacciComparison
{
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    public static int FibonacciIterative(int n)
    {
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    public static void Main()
    {
        int n = 30;

        Stopwatch sw = Stopwatch.StartNew();
        FibonacciRecursive(n);
        sw.Stop();
        Console.WriteLine("Recursive Fibonacci Time: " + sw.ElapsedMilliseconds + " ms");

        sw = Stopwatch.StartNew();
        FibonacciIterative(n);
        sw.Stop();
        Console.WriteLine("Iterative Fibonacci Time: " + sw.ElapsedMilliseconds + " ms");
    }
}

