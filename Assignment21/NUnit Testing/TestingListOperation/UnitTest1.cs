using System;
using System.Collections.Generic;
using NUnit.Framework;

public class ListManager
{
    public void AddElement(List<int> list, int element)
    {
        list.Add(element);
    }

    public void RemoveElement(List<int> list, int element)
    {
        list.Remove(element);
    }

    public int GetSize(List<int> list)
    {
        return list.Count;
    }
}

[TestFixture]
public class ListManagerTests
{
    private ListManager _listManager;
    private List<int> _list;

    [SetUp]
    public void Setup()
    {
        _listManager = new ListManager();
        _list = new List<int>();
    }

    [Test]
    public void AddElement_ShouldIncreaseListSize()
    {
        _listManager.AddElement(_list, 5);
        Assert.AreEqual(1, _listManager.GetSize(_list));
    }

    [Test]
    public void RemoveElement_ShouldDecreaseListSize()
    {
        _listManager.AddElement(_list, 10);
        _listManager.RemoveElement(_list, 10);
        Assert.AreEqual(0, _listManager.GetSize(_list));
    }

    [Test]
    public void GetSize_ShouldReturnCorrectSize()
    {
        _listManager.AddElement(_list, 3);
        _listManager.AddElement(_list, 7);
        Assert.AreEqual(2, _listManager.GetSize(_list));
    }
}
