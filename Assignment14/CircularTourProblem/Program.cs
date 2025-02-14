using System;
using System.Collections.Generic;

class CircularTour
{
    public static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        Queue<int> queue = new Queue<int>();
        int start = 0, currentPetrol = 0, deficit = 0;

        for (int i = 0; i < n; i++)
        {
            currentPetrol += petrol[i] - distance[i];
            queue.Enqueue(i);

            while (currentPetrol < 0 && queue.Count > 0)
            {
                deficit += petrol[queue.Peek()] - distance[queue.Peek()];
                currentPetrol -= petrol[queue.Dequeue()] - distance[queue.Dequeue()];
                start = queue.Count > 0 ? queue.Peek() : i + 1;
            }
        }
        return (currentPetrol + deficit >= 0) ? start : -1;
    }

    public static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };
        Console.WriteLine(FindStartingPoint(petrol, distance));
    }
}



