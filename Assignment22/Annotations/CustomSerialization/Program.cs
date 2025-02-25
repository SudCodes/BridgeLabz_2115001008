using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
class JsonField : Attribute
{
    public string Name { get; }
    public JsonField(string name) => Name = name;
}

class User
{
    [JsonField("user_name")]
    private string Username;

    [JsonField("user_email")]
    private string Email;

    public User(string username, string email)
    {
        Username = username;
        Email = email;
    }

    public string ToJson()
    {
        var jsonDict = new Dictionary<string, object>();
        FieldInfo[] fields = GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            JsonField attribute = (JsonField)Attribute.GetCustomAttribute(field, typeof(JsonField));
            if (attribute != null)
            {
                jsonDict[attribute.Name] = field.GetValue(this);
            }
        }

        return JsonSerializer.Serialize(jsonDict, new JsonSerializerOptions { WriteIndented = true });
    }
}

class Program
{
    static void Main()
    {
        User user = new User("Amit", "amit@example.com");
        Console.WriteLine(user.ToJson());
    }
}
