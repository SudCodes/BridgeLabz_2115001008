using System;
using System.Reflection;
using System.Reflection.Emit;

interface IGreeting
{
    void SayHello(string name);
}

class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

class LoggingProxy
{
    public static T Create<T>(T instance) where T : class
    {
        return DispatchProxy.Create<T, LoggingHandler<T>>();
    }
}

class LoggingHandler<T> : DispatchProxy
{
    private T _instance;

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine($"[LOG] Calling method: {targetMethod.Name}");

        return targetMethod.Invoke(_instance, args);
    }

    public void SetInstance(T instance)
    {
        _instance = instance;
    }
}

class Program
{
    static void Main()
    {
        IGreeting original = new Greeting();
        IGreeting proxy = LoggingProxy.Create(original);

        ((LoggingHandler<IGreeting>)(object)proxy).SetInstance(original);

        proxy.SayHello("Amit");
    }
}
