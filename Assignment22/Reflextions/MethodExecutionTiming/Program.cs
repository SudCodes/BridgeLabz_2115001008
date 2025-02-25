using System;
using System.Diagnostics;
using System.Reflection;

class MethodTimer
{
    public static void MeasureExecutionTime(object obj, string methodName, params object[] parameters)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

        if (method == null)
        {
            Console.WriteLine("Method not found.");
            return;
        }

        Stopwatch stopwatch = Stopwatch.StartNew();
        object result = method.Invoke(obj, parameters);
        stopwatch.Stop();

        Console.WriteLine($"Method {methodName} executed in {stopwatch.ElapsedMilliseconds} ms");

        if (method.ReturnType != typeof(void))
        {
            Console.WriteLine($"Return Value: {result}");
        }
    }
}

class SampleClass
{
    public void FastMethod()
    {
        Console.WriteLine("Executing FastMethod...");
    }

    private void SlowMethod()
    {
        Console.WriteLine("Executing SlowMethod...");
        System.Threading.Thread.Sleep(1000);
    }
}

class Program
{
    static void Main()
    {
        SampleClass sample = new SampleClass();

        MethodTimer.MeasureExecutionTime(sample, "FastMethod");
        MethodTimer.MeasureExecutionTime(sample, "SlowMethod");
    }
}
