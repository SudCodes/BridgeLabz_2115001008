using System;

// Bank class
class Bank
{
    public string Name { get; set; }
    public List<Customer> Customers { get; set; }

    public Bank(string name)
    {
        Name = name;
        Customers = new List<Customer>();
    }

    public void OpenAccount(Customer customer, decimal initialDeposit)
    {
        BankAccount account = new BankAccount(this, initialDeposit);
        customer.AddAccount(account);
        if (!Customers.Contains(customer))
        {
            Customers.Add(customer);
        }
        Console.WriteLine($"Account opened for {customer.Name} at {Name} with balance {initialDeposit:C}");
    }
}

// Customer class
class Customer
{
    public string Name { get; set; }
    public List<BankAccount> Accounts { get; set; }

    public Customer(string name)
    {
        Name = name;
        Accounts = new List<BankAccount>();
    }

    public void AddAccount(BankAccount account)
    {
        Accounts.Add(account);
    }

    public void ViewBalance()
    {
        Console.WriteLine($"{Name}'s Bank Accounts:");
        foreach (var account in Accounts)
        {
            Console.WriteLine($"Bank: {account.Bank.Name}, Balance: {account.Balance:C}");
        }
    }
}

// BankAccount class
class BankAccount
{
    public Bank Bank { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(Bank bank, decimal initialDeposit)
    {
        Bank = bank;
        Balance = initialDeposit;
    }
}

class Program
{
    static void Main()
    {
        Bank bank1 = new Bank("Global Bank");
        Customer customer1 = new Customer("Alice");
        Customer customer2 = new Customer("Bob");

        bank1.OpenAccount(customer1, 500);
        bank1.OpenAccount(customer1, 1500);
        bank1.OpenAccount(customer2, 1000);

        customer1.ViewBalance();
        Console.WriteLine();
        customer2.ViewBalance();
    }
}
