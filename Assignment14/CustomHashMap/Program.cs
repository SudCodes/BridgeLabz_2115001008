
using System;
using System.Collections.Generic;

class CustomHashMap<K, V>
{
    private const int Size = 1000;
    private LinkedList<KeyValuePair<K, V>>[] buckets;

    public CustomHashMap()
    {
        buckets = new LinkedList<KeyValuePair<K, V>>[Size];
    }

    private int GetBucketIndex(K key)
    {
        return Math.Abs(key.GetHashCode()) % Size;
    }

    public void Insert(K key, V value)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] == null)
            buckets[index] = new LinkedList<KeyValuePair<K, V>>();

        foreach (var pair in buckets[index])
        {
            if (pair.Key.Equals(key))
            {
                buckets[index].Remove(pair);
                break;
            }
        }
        buckets[index].AddLast(new KeyValuePair<K, V>(key, value));
    }

    public bool Remove(K key)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] == null) return false;

        foreach (var pair in buckets[index])
        {
            if (pair.Key.Equals(key))
            {
                buckets[index].Remove(pair);
                return true;
            }
        }
        return false;
    }

    public V Get(K key)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] != null)
        {
            foreach (var pair in buckets[index])
            {
                if (pair.Key.Equals(key))
                    return pair.Value;
            }
        }
        throw new KeyNotFoundException("Key not found");
    }

    public static void Main()
    {
        CustomHashMap<int, string> map = new CustomHashMap<int, string>();
        map.Insert(1, "One");
        map.Insert(2, "Two");
        Console.WriteLine(map.Get(1));
        Console.WriteLine(map.Remove(2));
        Console.WriteLine(map.Remove(3));
    }
}

