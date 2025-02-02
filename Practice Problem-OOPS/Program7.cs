using System;

class Product
{
    // Instance variables
    public string ProductName { get; set; }
    public double Price { get; set; }

    // Class variable (shared among all products)
    public static int TotalProducts { get; set; } = 0;

    // Constructor
    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
        TotalProducts++; // Increment the total product count when a new product is created
    }

    // Instance method to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: ${Price}");
    }

    // Class method to display the total number of products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products Created: {TotalProducts}");
    }
}

class Program7
{
    public static void Main()
    {
        // Creating products
        Product product1 = new Product("Laptop", 999.99);
        product1.DisplayProductDetails();

        Console.WriteLine();

        Product product2 = new Product("Smartphone", 599.99);
        product2.DisplayProductDetails();

        Console.WriteLine();

        // Display the total number of products created
        Product.DisplayTotalProducts();
    }
}
