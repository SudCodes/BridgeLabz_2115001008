using System;
using System.Collections.Generic;

class VotingSystem
{
    private Dictionary<string, int> voteCount = new Dictionary<string, int>(); 
    private List<string> voteOrder = new List<string>();

    public void CastVote(string candidate)
    {
        if (voteCount.ContainsKey(candidate))
        {
            voteCount[candidate]++;
        }
        else
        {
            voteCount[candidate] = 1;
        }
        voteOrder.Add(candidate);
    }

    public void DisplayVotes()
    {
        Console.WriteLine("\nVote Count:");
        foreach (var pair in voteCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} votes");
        }
    }

    public void DisplayVotesInSortedOrder()
    {
        Console.WriteLine("\nSorted Vote Count (Alphabetical Order):");
        List<string> sortedCandidates = new List<string>(voteCount.Keys);

        // Manual Sorting (Bubble Sort)
        for (int i = 0; i < sortedCandidates.Count - 1; i++)
        {
            for (int j = 0; j < sortedCandidates.Count - i - 1; j++)
            {
                if (string.Compare(sortedCandidates[j], sortedCandidates[j + 1]) > 0)
                {
                    string temp = sortedCandidates[j];
                    sortedCandidates[j] = sortedCandidates[j + 1];
                    sortedCandidates[j + 1] = temp;
                }
            }
        }

        foreach (var candidate in sortedCandidates)
        {
            Console.WriteLine($"{candidate}: {voteCount[candidate]} votes");
        }
    }

    public void DisplayVoteOrder()
    {
        Console.WriteLine("\nVote Order:");
        foreach (var candidate in voteOrder)
        {
            Console.Write(candidate + " -> ");
        }
        Console.WriteLine("End");
    }
}

class Program
{
    static void Main()
    {
        VotingSystem votingSystem = new VotingSystem();

        votingSystem.CastVote("Rahul");
        votingSystem.CastVote("Deepak");
        votingSystem.CastVote("Rahul");
        votingSystem.CastVote("Sudhanshu");
        votingSystem.CastVote("Rahul");
        votingSystem.CastVote("Deepak");

        // Display results
        votingSystem.DisplayVotes();
        votingSystem.DisplayVotesInSortedOrder();
        votingSystem.DisplayVoteOrder();
    }
}
