using System;
using System.Globalization;
using NUnit.Framework;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            return date.ToString("dd-MM-yyyy");
        }
        throw new FormatException("Invalid date format");
    }
}

[TestFixture]
public class DateFormatterTests
{
    private DateFormatter _dateFormatter;

    [SetUp]
    public void Setup()
    {
        _dateFormatter = new DateFormatter();
    }

    [Test]
    public void FormatDate_ShouldConvertCorrectly()
    {
        Assert.AreEqual("25-12-2023", _dateFormatter.FormatDate("2023-12-25"));
        Assert.AreEqual("01-01-2000", _dateFormatter.FormatDate("2000-01-01"));
    }

    [Test]
    public void FormatDate_ShouldThrowException_WhenInvalidDate()
    {
        Assert.Throws<FormatException>(() => _dateFormatter.FormatDate("25-12-2023"));
        Assert.Throws<FormatException>(() => _dateFormatter.FormatDate("invalid-date"));
    }
}
