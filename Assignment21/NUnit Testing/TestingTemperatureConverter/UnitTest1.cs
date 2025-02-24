
using System;
using NUnit.Framework;

public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter _temperatureConverter;

    [SetUp]
    public void Setup()
    {
        _temperatureConverter = new TemperatureConverter();
    }

    [Test]
    public void CelsiusToFahrenheit_ShouldConvertCorrectly()
    {
        Assert.AreEqual(32, _temperatureConverter.CelsiusToFahrenheit(0), 0.001);
        Assert.AreEqual(212, _temperatureConverter.CelsiusToFahrenheit(100), 0.001);
    }

    [Test]
    public void FahrenheitToCelsius_ShouldConvertCorrectly()
    {
        Assert.AreEqual(0, _temperatureConverter.FahrenheitToCelsius(32), 0.001);
        Assert.AreEqual(100, _temperatureConverter.FahrenheitToCelsius(212), 0.001);
    }
}