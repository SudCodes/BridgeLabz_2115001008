using System;

class Book
{
    public string ISBN { get; set; }

    protected string Title { get; set; }

    private string Author { get; set; }

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        SetAuthor(author); // Setting author using the setter method
    }

    // Public method to access author name
    public string GetAuthor()
    {
        return Author;
    }

    // Public method to modify author name
    public void SetAuthor(string author)
    {
        Author = author;
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {GetAuthor()}");
    }
}

class EBook : Book
{
    // Constructor for EBook
    public EBook(string isbn, string title, string author)
        : base(isbn, title, author)
    {
    }

    // Method to display eBook details
    public void DisplayEBookDetails()
    {
        Console.WriteLine("EBook Details:");
        Console.WriteLine($"ISBN: {ISBN}"); // Accessing public member (ISBN)
        Console.WriteLine($"Title: {Title}"); // Accessing protected member (Title)
    }
}

class Program11
{
    public static void Main()
    {
        // Creating a Book object
        Book book1 = new Book("978-3-16-148410-0", "The Great Gatsby", "F. Scott Fitzgerald");
        book1.DisplayBookDetails();

        Console.WriteLine();

        // Creating an EBook object
        EBook ebook1 = new EBook("978-0-14-118263-6", "1984", "George Orwell");
        ebook1.DisplayEBookDetails();
        ebook1.DisplayBookDetails();
    }
}
