using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Xml;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string jsonString = @"
        {
            ""name"": ""Amit"",
            ""age"": 25,
            ""email"": ""amit473@gmail.com"",
            ""address"": {
                ""city"": ""Delhi"",
                ""zip"": ""281406""
            }
        }";

        XmlDocument xmlDocument = JsonConvert.DeserializeXmlNode(jsonString, "Root");

        string xmlString = XDocument.Parse(xmlDocument.OuterXml).ToString();

        Console.WriteLine(xmlString);
    }
}