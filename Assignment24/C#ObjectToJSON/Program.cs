using Newtonsoft.Json;
using System;
using System.Xml;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main()
    {
        Car car = new Car
        {
            Brand = "Toyota",
            Model = "Corolla",
            Year = 2022
        };

        string jsonString = JsonConvert.SerializeObject(car, Newtonsoft.Json.Formatting.Indented);
        Console.WriteLine(jsonString);
    }
}