using System;

class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool IsAvailable;
    public Book Prev;
    public Book Next;

    public Book(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
        Prev = null;
        Next = null;
    }
}

class Library
{
    private Book head;
    private Book tail;
    private int bookCount = 0;

    public void AddBookAtBeginning(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        bookCount++;
    }

    public void AddBookAtEnd(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        if (tail == null)
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        bookCount++;
    }

    public void RemoveBook(int bookID)
    {
        Book temp = head;
        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;
        }
        if (temp == null) return;
        if (temp == head) head = temp.Next;
        if (temp == tail) tail = temp.Prev;
        if (temp.Prev != null) temp.Prev.Next = temp.Next;
        if (temp.Next != null) temp.Next.Prev = temp.Prev;
        bookCount--;
    }

    public Book SearchBook(string title, string author = null)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.Title == title || (author != null && temp.Author == author))
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void UpdateAvailability(int bookID, bool isAvailable)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.IsAvailable = isAvailable;
                return;
            }
            temp = temp.Next;
        }
    }

    public void DisplayBooksForward()
    {
        Book temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, BookID: {temp.BookID}, Available: {temp.IsAvailable}");
            temp = temp.Next;
        }
    }

    public void DisplayBooksReverse()
    {
        Book temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, BookID: {temp.BookID}, Available: {temp.IsAvailable}");
            temp = temp.Prev;
        }
    }

    public int CountBooks()
    {
        return bookCount;
    }
}

public class LibraryManager
{
    public static void Main()
    {
        Library library = new Library();
        library.AddBookAtBeginning("The Hobbit", "J.R.R. Tolkien", "Fantasy", 101, true);
        library.AddBookAtEnd("1984", "George Orwell", "Dystopian", 102, true);
        library.AddBookAtEnd("To Kill a Mockingbird", "Harper Lee", "Fiction", 103, false);

        Console.WriteLine("Library Books (Forward Order):");
        library.DisplayBooksForward();

        Console.WriteLine("\nLibrary Books (Reverse Order):");
        library.DisplayBooksReverse();

        Console.WriteLine("\nUpdating availability of '1984':");
        library.UpdateAvailability(102, false);
        library.DisplayBooksForward();

        Console.WriteLine("\nTotal books in library: " + library.CountBooks());
    }
}
