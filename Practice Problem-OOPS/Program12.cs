using System;

class BankAccount
{
    public string AccountNumber { get; set; }
    protected string AccountHolder { get; set; }
    private double Balance { get; set; }

    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        SetBalance(balance);
    }

    public double GetBalance()
    {
        return Balance;
    }

    public void SetBalance(double balance)
    {
        if (balance >= 0)
        {
            Balance = balance;
        }
        else
        {
            Console.WriteLine("Invalid balance amount. Balance cannot be negative.");
        }
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Balance: ${GetBalance()}");
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string accountHolder, double balance)
        : base(accountNumber, accountHolder, balance)
    {
    }

    public void DisplaySavingsAccountDetails()
    {
        Console.WriteLine("Savings Account Details:");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolder}");
    }
}

class Program
{
    public static void Main()
    {
        BankAccount account1 = new BankAccount("12345", "Rahul", 5000);
        account1.DisplayAccountDetails();

        Console.WriteLine();

        SavingsAccount savingsAccount1 = new SavingsAccount("67890", "Deepak", 10000);
        savingsAccount1.DisplaySavingsAccountDetails();
        savingsAccount1.DisplayAccountDetails();
    }
}
