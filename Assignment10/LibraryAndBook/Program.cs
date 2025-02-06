using System;

// Book class (Independent entity)
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}

// Library class (Aggregates Book objects)
class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void DisplayBooks()
    {
        Console.WriteLine($"Library: {Name} has the following books:");
        foreach (var book in Books)
        {
            book.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create books (exist independently of any library)
        Book book1 = new Book("The Catcher in the Rye", "J.D. Salinger");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        Book book3 = new Book("1984", "George Orwell");

        // Create libraries
        Library library1 = new Library("City Library");
        Library library2 = new Library("Community Library");

        // Add books to libraries
        library1.AddBook(book1);
        library1.AddBook(book2);

        library2.AddBook(book2); // Same book can be in multiple libraries
        library2.AddBook(book3);

        // Display books in each library
        library1.DisplayBooks();
        Console.WriteLine();
        library2.DisplayBooks();
    }
}
