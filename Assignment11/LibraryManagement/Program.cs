using System;
class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, int publicationyear)
    {
        this.Title = title;
        this.PublicationYear = publicationyear;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}");
    }
}

class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }

    public Author(string title, int publicationyear, string name, string bio) : base(title, publicationyear)
    {
        this.Name = name;
        this.Bio = bio;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author's Name: {Name}\nBio: {Bio}");
    }
}
class Program
{
    public static void Main()
    {
        Author author = new Author("The Guide", 1958, "R. K. Narayan", "Renowned Indian writer known for his works set in Malgudi.");

        author.DisplayInfo();
    }
}
