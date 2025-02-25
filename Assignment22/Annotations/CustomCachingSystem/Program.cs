using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class CacheResult : Attribute { }

class CachedCalculator
{
    private static Dictionary<string, object> cache = new Dictionary<string, object>();

    [CacheResult]
    public int ExpensiveComputation(int number)
    {
        string key = $"ExpensiveComputation:{number}";
        if (cache.ContainsKey(key))
        {
            Console.WriteLine("Returning cached result...");
            return (int)cache[key];
        }

        Console.WriteLine("Computing result...");
        int result = number * number;
        cache[key] = result;
        return result;
    }
}

class Program
{
    static void Main()
    {
        CachedCalculator calculator = new CachedCalculator();

        Console.WriteLine(calculator.ExpensiveComputation(10));
        Console.WriteLine(calculator.ExpensiveComputation(10));
        Console.WriteLine(calculator.ExpensiveComputation(5));
        Console.WriteLine(calculator.ExpensiveComputation(5));
    }
}
