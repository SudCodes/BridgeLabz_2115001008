using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (password.Length < 8) return false;
        if (!Regex.IsMatch(password, ".*[A-Z].*")) return false;
        if (!Regex.IsMatch(password, ".*[0-9].*")) return false;
        return true;
    }
}

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator _passwordValidator;

    [SetUp]
    public void Setup()
    {
        _passwordValidator = new PasswordValidator();
    }

    [Test]
    public void Password_ShouldBeValid()
    {
        Assert.IsTrue(_passwordValidator.IsValid("StrongP@ss1"));
    }

    [Test]
    public void Password_ShouldBeInvalid_WhenTooShort()
    {
        Assert.IsFalse(_passwordValidator.IsValid("Short1"));
    }

    [Test]
    public void Password_ShouldBeInvalid_WhenMissingUppercase()
    {
        Assert.IsFalse(_passwordValidator.IsValid("weakpassword1"));
    }

    [Test]
    public void Password_ShouldBeInvalid_WhenMissingDigit()
    {
        Assert.IsFalse(_passwordValidator.IsValid("NoNumbersHere"));
    }
}