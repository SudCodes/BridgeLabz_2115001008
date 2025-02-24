using System;
using System.Globalization;
using System.Text.RegularExpressions;
using NUnit.Framework;

public class UserRegistration
{
    public void RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username cannot be empty");

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new ArgumentException("Invalid email format");

        if (password.Length < 8)
            throw new ArgumentException("Password must be at least 8 characters long");
    }
}

[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration _userRegistration;

    [SetUp]
    public void Setup()
    {
        _userRegistration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ShouldSucceed_WithValidInputs()
    {
        Assert.DoesNotThrow(() => _userRegistration.RegisterUser("JohnDoe", "john.doe@example.com", "StrongPass1"));
    }

    [Test]
    public void RegisterUser_ShouldThrowException_WhenUsernameIsEmpty()
    {
        Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("", "john.doe@example.com", "StrongPass1"));
    }

    [Test]
    public void RegisterUser_ShouldThrowException_WhenEmailIsInvalid()
    {
        Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "invalid-email", "StrongPass1"));
    }

    [Test]
    public void RegisterUser_ShouldThrowException_WhenPasswordIsTooShort()
    {
        Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "john.doe@example.com", "short"));
    }
}
