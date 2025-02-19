using System;
using System.Collections.Generic;

class Program
{
    static string FindNthFromEnd(LinkedList<string> list, int n)
    {
        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

  
        for (int i = 0; i < n; i++)
        {
            if (first == null) return "N is larger than the list size";
            first = first.Next;
        }

   
        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        return second.Value;
    }

    static void Main()
    {
        LinkedList<string> linkedList = new LinkedList<string>(new[] { "A", "B", "C", "D", "E" });
        int N = 2;

        Console.WriteLine($"Nth element from end: {FindNthFromEnd(linkedList, N)}");
    }
}
