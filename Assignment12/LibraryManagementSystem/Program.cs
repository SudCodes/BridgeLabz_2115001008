using System;
using System.Collections.Generic;

abstract class LibraryItem
{
    public int ItemId { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }

    public LibraryItem(int itemId, string title, string author)
    {
        ItemId = itemId;
        Title = title;
        Author = author;
    }

    public abstract int GetLoanDuration();

    public virtual void GetItemDetails()
    {
        Console.WriteLine($"Item ID: {ItemId}, Title: {Title}, Author: {Author}, Loan Duration: {GetLoanDuration()} days");
    }
}

interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

class Book : LibraryItem, IReservable
{
    private bool isReserved;

    public Book(int itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 14;
    }

    public void ReserveItem()
    {
        if (!isReserved)
        {
            isReserved = true;
            Console.WriteLine($"Book '{Title}' has been reserved.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' is already reserved.");
        }
    }

    public bool CheckAvailability()
    {
        return !isReserved;
    }
}

class Magazine : LibraryItem
{
    public Magazine(int itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 7;
    }
}

class DVD : LibraryItem, IReservable
{
    private bool isReserved;

    public DVD(int itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 5;
    }

    public void ReserveItem()
    {
        if (!isReserved)
        {
            isReserved = true;
            Console.WriteLine($"DVD '{Title}' has been reserved.");
        }
        else
        {
            Console.WriteLine($"DVD '{Title}' is already reserved.");
        }
    }

    public bool CheckAvailability()
    {
        return !isReserved;
    }
}

class Program
{
    static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book(101, "The Alchemist", "Paulo Coelho"),
            new Magazine(102, "National Geographic", "Various"),
            new DVD(103, "Inception", "Christopher Nolan")
        };

        foreach (var item in items)
        {
            item.GetItemDetails();
            Console.WriteLine();
        }

        IReservable reservableBook = new Book(104, "Rich Dad Poor Dad", "Robert Kiyosaki");
        reservableBook.ReserveItem();
        Console.WriteLine($"Is available: {reservableBook.CheckAvailability()}");

        IReservable reservableDvd = new DVD(105, "The Matrix", "The Wachowskis");
        reservableDvd.ReserveItem();
        Console.WriteLine($"Is available: {reservableDvd.CheckAvailability()}");
    }
}
