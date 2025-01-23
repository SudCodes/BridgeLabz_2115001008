// Creating Class with name Program5 to check voting eligibility
using System;
class Program5
{
    public static string CheckVotingEligibility(int age)
    {
        // Check if age is 18 or above
        bool canVote = age >= 18;

        // Return the result
        return canVote
            ? $"The person's age is {age} and can vote."
            : $"The person's age is {age} and cannot vote.";
    }
}