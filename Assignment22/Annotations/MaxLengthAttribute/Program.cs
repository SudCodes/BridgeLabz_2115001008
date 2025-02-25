using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
class MaxLength : Attribute
{
    public int Value { get; }
    public MaxLength(int value) => Value = value;
}

class User
{
    [MaxLength(10)]
    private string Username;

    public User(string username)
    {
        FieldInfo field = typeof(User).GetField("Username", BindingFlags.NonPublic | BindingFlags.Instance);
        MaxLength attribute = (MaxLength)Attribute.GetCustomAttribute(field, typeof(MaxLength));

        if (attribute != null && username.Length > attribute.Value)
        {
            throw new ArgumentException($"Username exceeds max length of {attribute.Value} characters.");
        }

        Username = username;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            User user1 = new User("ShortName");
            Console.WriteLine("User1 created successfully.");

            User user2 = new User("ThisIsTooLong");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
