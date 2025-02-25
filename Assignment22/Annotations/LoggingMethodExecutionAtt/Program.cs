using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class LogExecutionTime : Attribute { }

class PerformanceTest
{
    [LogExecutionTime]
    public void FastMethod()
    {
        for (int i = 0; i < 1000; i++) { }
    }

    [LogExecutionTime]
    public void SlowMethod()
    {
        for (int i = 0; i < 1000000; i++) { }
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(PerformanceTest);
        object instance = Activator.CreateInstance(type);
        MethodInfo[] methods = type.GetMethods();

        Console.WriteLine("Method Execution Times:");
        foreach (var method in methods)
        {
            if (Attribute.IsDefined(method, typeof(LogExecutionTime)))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                method.Invoke(instance, null);
                stopwatch.Stop();
                Console.WriteLine($"Method: {method.Name}, Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
