//Dynamic Online Marketplace
//Concepts: Type Parameters, Generic Methods, Constraints
//Problem Statement: Build a generic product catalog for an online marketplace supporting various product types.
//Hints: 
//Define a generic class Product<T> where T is restricted to a category (BookCategory, ClothingCategory).
//Implement a generic method void ApplyDiscount<T>(T product, double percentage) where T : Product.
//Ensure type safety while allowing multiple product categories in the catalog.


using System;
using System.Collections.Generic;

abstract class ProductCategory
{
    public string CategoryName { get; set; }
}

class BookCategory : ProductCategory
{
    public BookCategory()
    {
        CategoryName = "Books";
    }
}

class ClothingCategory : ProductCategory
{
    public ClothingCategory()
    {
        CategoryName = "Clothing";
    }
}

class Product<T> where T : ProductCategory
{
    public string Name { get; set; }
    public double Price { get; set; }
    public T Category { get; set; }


    public Product(string name, double price, T category)
    {
        this.Name = name;
        this.Price = price;
        this.Category = category;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"[Category: {Category.CategoryName}] Name: {Name}, Price: ${Price}");
    }
}

class Discount
{
    public static void ApplyDiscount<T>(Product<T> product, double percentage) where T : ProductCategory
    {
        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine($"Discount applied! New price of {product.Name}: ${product.Price:F2}");
    }
}


class Program
{
    public static void Main( string[] args)
    {
        Product<BookCategory> book = new Product<BookCategory>("C# Programming", 500, new BookCategory());
        book.DisplayInfo();

        Product<ClothingCategory> cloth = new Product<ClothingCategory>("Shirt", 800, new ClothingCategory());
        cloth.DisplayInfo();

        Console.WriteLine("Applying Discount....");

        Discount.ApplyDiscount(book, 10);
        Discount.ApplyDiscount(cloth, 17);

    }
}