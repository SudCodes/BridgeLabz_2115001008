using System;
class Book
{
    private string Title{ get; set; }
    private string Author{ get; set; }
    private double Price{ get; set; }


    // Default Constructors
    public Book()
    {
        Console.WriteLine("This is Default Constructor");
    }
    // Parameterized Constructors.
    public Book(string title, string author, double price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nPrice: {Price}");
    }
  
}
class Program1
{
    public static void Main(string[] args)
    {
        Book obj = new Book();
        Book obj2 = new Book("Harry Potter", "J. K. Rowling", 150.00);
        obj2.Display();

    }
}