using System;
using System.Collections;

class Program
{
#pragma warning disable CS8602 // Disables warnings for possible null references
#pragma warning disable CS8619 // Disables warnings for nullable assignment

    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Apple");
        list.Add(10);
        list.Add(true);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

#pragma warning restore CS8602 // Re-enables the warnings
#pragma warning restore CS8619
}
