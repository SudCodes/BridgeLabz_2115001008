using System;

class Book
{
    // Attributes
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool Availability { get; set; } // true means available, false means borrowed

    // Default Constructor
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
        Availability = true; // Book is available by default
    }

    // Parameterized Constructor
    public Book(string title, string author, double price, bool availability)
    {
        Title = title;
        Author = author;
        Price = price;
        Availability = availability;
    }

    // Method to borrow a book
    public void BorrowBook()
    {
        if (Availability)
        {
            Availability = false; // Mark the book as borrowed
            Console.WriteLine($"You have successfully borrowed '{Title}' by {Author}.");
        }
        else
        {
            Console.WriteLine($"Sorry, '{Title}' is currently unavailable.");
        }
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        string availabilityStatus = Availability ? "Available" : "Not Available";
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nPrice: {Price}\nAvailability: {availabilityStatus}");
    }
}

class Program5
{
    public static void Main()
    {
        // Creating a book using the parameterized constructor
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99, true);
        book1.DisplayBookDetails();

        // Borrowing the book
        Console.WriteLine();
        book1.BorrowBook();
        book1.DisplayBookDetails();

        // Trying to borrow the same book again
        Console.WriteLine();
        book1.BorrowBook(); // Book is now unavailable
    }
}
