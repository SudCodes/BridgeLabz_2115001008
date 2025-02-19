using System;
using System.Collections.Generic;

class BankingSystem
{
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>(); // Stores account balances
    private List<int> withdrawalQueue = new List<int>(); // Maintains withdrawal requests

    public void CreateAccount(int accountNumber, double initialBalance)
    {
        if (!accountBalances.ContainsKey(accountNumber))
        {
            accountBalances[accountNumber] = initialBalance;
        }
    }

    public void Deposit(int accountNumber, double amount)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            accountBalances[accountNumber] += amount;
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void Withdraw(int accountNumber, double amount)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            if (accountBalances[accountNumber] >= amount)
            {
                withdrawalQueue.Add(accountNumber); // Add request to queue
            }
            else
            {
                Console.WriteLine($"Insufficient balance in account {accountNumber}.");
            }
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void ProcessWithdrawals()
    {
        Console.WriteLine("\nProcessing Withdrawal Requests:");
        foreach (int accountNumber in withdrawalQueue)
        {
            if (accountBalances[accountNumber] > 0)
            {
                Console.WriteLine($"Withdrawal approved for account {accountNumber}.");
                accountBalances[accountNumber] -= 100; // Assuming a fixed withdrawal amount for simplicity
            }
        }
        withdrawalQueue.Clear();
    }

    public void DisplaySortedAccountsByBalance()
    {
        Console.WriteLine("\nAccounts Sorted by Balance:");

        // Manual Sorting (Bubble Sort)
        List<(int, double)> sortedAccounts = new List<(int, double)>();
        foreach (var pair in accountBalances)
        {
            sortedAccounts.Add(pair);
        }

        for (int i = 0; i < sortedAccounts.Count - 1; i++)
        {
            for (int j = 0; j < sortedAccounts.Count - i - 1; j++)
            {
                if (sortedAccounts[j].Item2 > sortedAccounts[j + 1].Item2)
                {
                    var temp = sortedAccounts[j];
                    sortedAccounts[j] = sortedAccounts[j + 1];
                    sortedAccounts[j + 1] = temp;
                }
            }
        }

        foreach (var (account, balance) in sortedAccounts)
        {
            Console.WriteLine($"Account {account}: ${balance:0.00}");
        }
    }
}

class Program
{
    static void Main()
    {
        BankingSystem bank = new BankingSystem();

 
        bank.CreateAccount(101, 1500);
        bank.CreateAccount(102, 2300);
        bank.CreateAccount(103, 900);
        bank.CreateAccount(104, 3000);

    
        bank.Deposit(101, 500);
        bank.Deposit(103, 600);

  
        bank.Withdraw(101, 100);
        bank.Withdraw(104, 100);
        bank.Withdraw(102, 5000);


        bank.ProcessWithdrawals();

  
        bank.DisplaySortedAccountsByBalance();
    }
}
