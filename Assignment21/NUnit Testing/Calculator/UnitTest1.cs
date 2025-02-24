using System;
using NUnit.Framework;

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero");
        return a / b;
    }
}

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        Assert.AreEqual(5, _calculator.Add(2, 3));
    }

    [Test]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        Assert.AreEqual(1, _calculator.Subtract(4, 3));
    }

    [Test]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        Assert.AreEqual(12, _calculator.Multiply(4, 3));
    }

    [Test]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        Assert.AreEqual(2, _calculator.Divide(6, 3));
    }

    [Test]
    public void Divide_ByZero_ShouldThrowException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
    }
}
