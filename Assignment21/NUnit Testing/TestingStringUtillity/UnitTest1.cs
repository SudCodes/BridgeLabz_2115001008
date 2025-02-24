using System;
using NUnit.Framework;

public class StringUtils
{
    public string Reverse(string str) => new string(str.Reverse().ToArray());

    public bool IsPalindrome(string str)
    {
        string reversed = Reverse(str);
        return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str) => str.ToUpper();
}

[TestFixture]
public class StringUtilsTests
{
    private StringUtils _stringUtils;

    [SetUp]
    public void Setup()
    {
        _stringUtils = new StringUtils();
    }

    [Test]
    public void Reverse_ShouldReturnReversedString()
    {
        Assert.AreEqual("cba", _stringUtils.Reverse("abc"));
    }

    [Test]
    public void IsPalindrome_ShouldReturnTrueForPalindrome()
    {
        Assert.IsTrue(_stringUtils.IsPalindrome("madam"));
    }

    [Test]
    public void IsPalindrome_ShouldReturnFalseForNonPalindrome()
    {
        Assert.IsFalse(_stringUtils.IsPalindrome("hello"));
    }

    [Test]
    public void ToUpperCase_ShouldConvertStringToUpperCase()
    {
        Assert.AreEqual("HELLO", _stringUtils.ToUpperCase("hello"));
    }
}
