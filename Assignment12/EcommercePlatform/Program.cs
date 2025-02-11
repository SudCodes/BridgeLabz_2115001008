using System;
using System.Collections.Generic;

abstract class Product
{
    public int ProductId { get; private set; }
    public string Name { get; private set; }
    public double Price { get; private set; }

    public Product(int productId, string name, double price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }

    public abstract double CalculateDiscount();

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: {Price:C}, Discount: {CalculateDiscount():C}");
    }

    public double GetPriceAfterDiscount()
    {
        return Price - CalculateDiscount();
    }
}

interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

class Electronics : Product, ITaxable
{
    public Electronics(int productId, string name, double price) : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.1;
    }

    public double CalculateTax()
    {
        return Price * 0.18;
    }

    public string GetTaxDetails()
    {
        return "18% GST applied on Electronics.";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"{GetTaxDetails()} Tax: {CalculateTax():C}");
    }
}

class Clothing : Product, ITaxable
{
    public Clothing(int productId, string name, double price) : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.15;
    }

    public double CalculateTax()
    {
        return Price * 0.05;
    }

    public string GetTaxDetails()
    {
        return "5% GST applied on Clothing.";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"{GetTaxDetails()} Tax: {CalculateTax():C}");
    }
}

class Groceries : Product
{
    public Groceries(int productId, string name, double price) : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("No tax applied on Groceries.");
    }
}

class Program
{
    static void CalculateFinalPrice(List<Product> products)
    {
        foreach (var product in products)
        {
            double finalPrice = product.GetPriceAfterDiscount();
            if (product is ITaxable taxableProduct)
            {
                finalPrice += taxableProduct.CalculateTax();
            }

            product.DisplayDetails();
            Console.WriteLine($"Final Price: {finalPrice:C}\n");
        }
    }

    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics(101, "Laptop", 50000),
            new Clothing(102, "T-Shirt", 1500),
            new Groceries(103, "Rice Bag", 2000)
        };

        CalculateFinalPrice(products);
    }
}
