using System;
using NUnit.Framework;

public class BankAccount
{
    private double _balance;

    public void Deposit(double amount)
    {
        if (amount < 0) throw new ArgumentException("Deposit amount cannot be negative");
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > _balance) throw new InvalidOperationException("Insufficient funds");
        _balance -= amount;
    }

    public double GetBalance()
    {
        return _balance;
    }
}

[TestFixture]
public class BankAccountTests
{
    private BankAccount _bankAccount;

    [SetUp]
    public void Setup()
    {
        _bankAccount = new BankAccount();
    }

    [Test]
    public void Deposit_ShouldIncreaseBalance()
    {
        _bankAccount.Deposit(100);
        Assert.AreEqual(100, _bankAccount.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldDecreaseBalance()
    {
        _bankAccount.Deposit(200);
        _bankAccount.Withdraw(50);
        Assert.AreEqual(150, _bankAccount.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldThrowException_WhenInsufficientFunds()
    {
        Assert.Throws<InvalidOperationException>(() => _bankAccount.Withdraw(50));
    }
}
