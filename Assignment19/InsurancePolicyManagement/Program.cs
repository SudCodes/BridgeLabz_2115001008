using System;
using System.Collections.Generic;

class Policy
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Policy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public override string ToString()
    {
        return $"{PolicyNumber} | {CoverageType} | Expires: {ExpiryDate.ToShortDateString()}";
    }
}

class InsurancePolicyManagement
{
    private List<Policy> policies = new List<Policy>();
    private List<string> duplicatePolicyNumbers = new List<string>();

    public void AddPolicy(Policy policy)
    {
        // Manual uniqueness check
        bool exists = false;
        foreach (var p in policies)
        {
            if (p.PolicyNumber == policy.PolicyNumber)
            {
                exists = true;
                if (!duplicatePolicyNumbers.Contains(policy.PolicyNumber))
                {
                    duplicatePolicyNumbers.Add(policy.PolicyNumber);
                }
                break;
            }
        }

        if (!exists)
        {
            policies.Add(policy);
        }
    }

    public List<Policy> GetAllUniquePolicies()
    {
        return policies;
    }

    public List<Policy> GetExpiringSoonPolicies(int days)
    {
        DateTime today = DateTime.Today;
        List<Policy> expiringSoon = new List<Policy>();

        foreach (var policy in policies)
        {
            if ((policy.ExpiryDate - today).Days <= days)
            {
                expiringSoon.Add(policy);
            }
        }

        return expiringSoon;
    }

    public List<Policy> GetPoliciesByCoverageType(string coverageType)
    {
        List<Policy> filteredPolicies = new List<Policy>();

        foreach (var policy in policies)
        {
            if (policy.CoverageType == coverageType)
            {
                filteredPolicies.Add(policy);
            }
        }

        return filteredPolicies;
    }

    public List<string> GetDuplicatePolicyNumbers()
    {
        return duplicatePolicyNumbers;
    }

    public List<Policy> GetSortedPoliciesByExpiryDate()
    {
        List<Policy> sortedPolicies = new List<Policy>(policies);

 
        for (int i = 0; i < sortedPolicies.Count - 1; i++)
        {
            for (int j = 0; j < sortedPolicies.Count - i - 1; j++)
            {
                if (sortedPolicies[j].ExpiryDate > sortedPolicies[j + 1].ExpiryDate)
                {
                    // Swap
                    Policy temp = sortedPolicies[j];
                    sortedPolicies[j] = sortedPolicies[j + 1];
                    sortedPolicies[j + 1] = temp;
                }
            }
        }

        return sortedPolicies;
    }
}

class Program
{
    static void Main()
    {
        InsurancePolicyManagement policyManager = new InsurancePolicyManagement();

        policyManager.AddPolicy(new Policy("P001", "Health", DateTime.Today.AddDays(20)));
        policyManager.AddPolicy(new Policy("P002", "Auto", DateTime.Today.AddDays(40)));
        policyManager.AddPolicy(new Policy("P003", "Home", DateTime.Today.AddDays(10)));
        policyManager.AddPolicy(new Policy("P001", "Health", DateTime.Today.AddDays(20))); // Duplicate
        policyManager.AddPolicy(new Policy("P004", "Auto", DateTime.Today.AddDays(25)));

        Console.WriteLine("\nAll Unique Policies:");
        foreach (var policy in policyManager.GetAllUniquePolicies())
        {
            Console.WriteLine(policy);
        }

        Console.WriteLine("\nPolicies Expiring Soon (Within 30 Days):");
        foreach (var policy in policyManager.GetExpiringSoonPolicies(30))
        {
            Console.WriteLine(policy);
        }

        Console.WriteLine("\nPolicies with Coverage Type 'Auto':");
        foreach (var policy in policyManager.GetPoliciesByCoverageType("Auto"))
        {
            Console.WriteLine(policy);
        }

        Console.WriteLine("\nDuplicate Policy Numbers:");
        foreach (var policyNumber in policyManager.GetDuplicatePolicyNumbers())
        {
            Console.WriteLine(policyNumber);
        }

        Console.WriteLine("\nSorted Policies by Expiry Date:");
        foreach (var policy in policyManager.GetSortedPoliciesByExpiryDate())
        {
            Console.WriteLine(policy);
        }
    }
}
