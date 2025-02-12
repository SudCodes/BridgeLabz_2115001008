using System;
using System.Collections.Generic;

class User
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs;
    public User Next;

    public User(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private User head;

    public void AddUser(int userID, string name, int age)
    {
        User newUser = new User(userID, name, age);
        newUser.Next = head;
        head = newUser;
    }

    public void AddFriend(int userID1, int userID2)
    {
        User user1 = SearchUser(userID1);
        User user2 = SearchUser(userID2);
        if (user1 != null && user2 != null && !user1.FriendIDs.Contains(userID2))
        {
            user1.FriendIDs.Add(userID2);
            user2.FriendIDs.Add(userID1);
        }
    }

    public void RemoveFriend(int userID1, int userID2)
    {
        User user1 = SearchUser(userID1);
        User user2 = SearchUser(userID2);
        if (user1 != null && user2 != null)
        {
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);
        }
    }

    public List<int> FindMutualFriends(int userID1, int userID2)
    {
        User user1 = SearchUser(userID1);
        User user2 = SearchUser(userID2);
        if (user1 == null || user2 == null) return new List<int>();
        return new List<int>(user1.FriendIDs.FindAll(id => user2.FriendIDs.Contains(id)));
    }

    public void DisplayFriends(int userID)
    {
        User user = SearchUser(userID);
        if (user != null)
        {
            Console.WriteLine($"Friends of {user.Name}:");
            foreach (int friendID in user.FriendIDs)
            {
                User friend = SearchUser(friendID);
                if (friend != null)
                    Console.WriteLine($"- {friend.Name} (ID: {friend.UserID})");
            }
        }
    }

    public User SearchUser(int userID, string name = null)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID || (name != null && temp.Name == name))
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public int CountFriends(int userID)
    {
        User user = SearchUser(userID);
        return user != null ? user.FriendIDs.Count : 0;
    }
}

public class SocialMediaManager
{
    public static void Main()
    {
        SocialMedia sm = new SocialMedia();
        sm.AddUser(1, "Rahul", 25);
        sm.AddUser(2, "Deepak", 30);
        sm.AddUser(3, "Sudhanshu", 22);

        sm.AddFriend(1, 2);
        sm.AddFriend(1, 3);

        Console.WriteLine("Initial Friends List:");
        sm.DisplayFriends(1);
        sm.DisplayFriends(2);

        Console.WriteLine("\nMutual Friends between Rahul and Deepak:");
        List<int> mutualFriends = sm.FindMutualFriends(1, 2);
        foreach (int id in mutualFriends)
        {
            Console.WriteLine($"User ID: {id}");
        }

        Console.WriteLine("\nRemoving Friendship between Rahul and Deepak:");
        sm.RemoveFriend(1, 2);
        sm.DisplayFriends(1);
    }
}