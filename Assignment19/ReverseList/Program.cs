using System;
using System.Collections.Generic;

class Program
{
    // Reverse List<T>
    static List<int> ReverseList(List<int> list)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            // Swap elements
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
        return list;
    }

    // Reverse LinkedList<T>
    static LinkedList<int> ReverseLinkedList(LinkedList<int> linkedList)
    {
        LinkedList<int> reversedList = new LinkedList<int>();
        foreach (var item in linkedList)
        {
            reversedList.AddFirst(item); 
        }
        return reversedList;
    }

    static void Main()
    {
        // Test for List<T>
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original List: " + string.Join(", ", list));
        list = ReverseList(list);
        Console.WriteLine("Reversed List: " + string.Join(", ", list));

        // Test for LinkedList<T>
        LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("\nOriginal LinkedList: " + string.Join(", ", linkedList));
        LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);
        Console.WriteLine("Reversed LinkedList: " + string.Join(", ", reversedLinkedList));
    }
}
