// Class to calculate bonus based on years of service
using System;
class Program17
{
    public double CalculateBonus(double salary, int yearsOfService)
    {
        // Checking if the employee is eligible for a bonus
        if (yearsOfService > 5)
        {
            double bonus = 0.05 * salary; // Calculating 5% bonus
            return bonus; // Returning the calculated bonus
        }
        else
        {
            return 0; // No bonus for less than or equal to 5 years of service
        }
    }
}