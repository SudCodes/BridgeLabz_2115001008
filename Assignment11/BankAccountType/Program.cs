using System;

class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance:C}");
    }
}

class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(int accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountDetails()
    {
        base.DisplayAccountDetails();
        Console.WriteLine($"Account Type: Savings, Interest Rate: {InterestRate}%");
    }
}

class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountDetails()
    {
        base.DisplayAccountDetails();
        Console.WriteLine($"Account Type: Checking, Withdrawal Limit: {WithdrawalLimit:C}");
    }
}

class FixedDepositAccount : BankAccount
{
    public int MaturityPeriod { get; set; } // In months

    public FixedDepositAccount(int accountNumber, double balance, int maturityPeriod)
        : base(accountNumber, balance)
    {
        MaturityPeriod = maturityPeriod;
    }

    public override void DisplayAccountDetails()
    {
        base.DisplayAccountDetails();
        Console.WriteLine($"Account Type: Fixed Deposit, Maturity Period: {MaturityPeriod} months");
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount savings = new SavingsAccount(1001, 5000, 3.5);
        CheckingAccount checking = new CheckingAccount(1002, 3000, 1000);
        FixedDepositAccount fixedDeposit = new FixedDepositAccount(1003, 10000, 12);

        savings.DisplayAccountDetails();
        Console.WriteLine();
        checking.DisplayAccountDetails();
        Console.WriteLine();
        fixedDeposit.DisplayAccountDetails();
    }
}
