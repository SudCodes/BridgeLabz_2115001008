using System;
using NUnit.Framework;

public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    public void Connect()
    {
        IsConnected = true;
        Console.WriteLine("Database connected.");
    }

    public void Disconnect()
    {
        IsConnected = false;
        Console.WriteLine("Database disconnected.");
    }
}

[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection _dbConnection;

    [SetUp]
    public void Setup()
    {
        _dbConnection = new DatabaseConnection();
        _dbConnection.Connect();
    }

    [Test]
    public void Connect_ShouldSetIsConnectedToTrue()
    {
        Assert.IsTrue(_dbConnection.IsConnected);
    }

    [TearDown]
    public void Teardown()
    {
        _dbConnection.Disconnect();
        Assert.IsFalse(_dbConnection.IsConnected);
    }
}
