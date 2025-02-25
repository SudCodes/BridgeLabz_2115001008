using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Constructor)]
class Inject : Attribute { }

class DIContainer
{
    private Dictionary<Type, Type> _typeMappings = new Dictionary<Type, Type>();

    public void Register<TInterface, TImplementation>()
    {
        _typeMappings[typeof(TInterface)] = typeof(TImplementation);
    }

    public T Resolve<T>()
    {
        return (T)Resolve(typeof(T));
    }

    private object Resolve(Type type)
    {
        if (!_typeMappings.ContainsKey(type))
        {
            throw new InvalidOperationException($"No registration for {type}");
        }

        Type implementationType = _typeMappings[type];
        ConstructorInfo constructor = implementationType.GetConstructors()
            .FirstOrDefault(c => c.GetCustomAttribute<Inject>() != null)
            ?? implementationType.GetConstructors().First();

        ParameterInfo[] parameters = constructor.GetParameters();
        object[] dependencies = parameters.Select(p => Resolve(p.ParameterType)).ToArray();

        return Activator.CreateInstance(implementationType, dependencies);
    }
}

interface IService
{
    void Serve();
}

class ServiceA : IService
{
    public void Serve()
    {
        Console.WriteLine("ServiceA is serving.");
    }
}

class Client
{
    private readonly IService _service;

    [Inject]
    public Client(IService service)
    {
        _service = service;
    }

    public void Execute()
    {
        _service.Serve();
    }
}

class Program
{
    static void Main()
    {
        DIContainer container = new DIContainer();
        container.Register<IService, ServiceA>();
        container.Register<Client, Client>();

        Client client = container.Resolve<Client>();
        client.Execute();
    }
}
