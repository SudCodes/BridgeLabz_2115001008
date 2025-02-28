using Newtonsoft.Json.Linq;
using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string json1 = @"{
            'name': 'Amit',
            'age': 25
        }";

        string json2 = @"{
            'email': 'amit123@gmail.com',
            'city': 'Delhi'
        }"
        ;

        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);

        obj1.Merge(obj2, new JsonMergeSettings
        {
            MergeArrayHandling = MergeArrayHandling.Union
        });

        Console.WriteLine(obj1.ToString());
    }
}