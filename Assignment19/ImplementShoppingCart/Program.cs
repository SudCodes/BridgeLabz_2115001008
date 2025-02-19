using System;
using System.Collections.Generic;

class ShoppingCart
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>(); 
    private List<string> purchaseOrder = new List<string>(); 

    public void AddProduct(string product, double price)
    {
        if (!productPrices.ContainsKey(product))
        {
            productPrices[product] = price;
        }
        purchaseOrder.Add(product);
    }

    public void DisplayCart()
    {
        Console.WriteLine("\nShopping Cart:");
        foreach (var product in purchaseOrder)
        {
            Console.WriteLine($"{product}: ${productPrices[product]:0.00}");
        }
    }

    public void DisplaySortedByPrice()
    {
        Console.WriteLine("\nCart Items Sorted by Price:");

   
        List<(string, double)> sortedProducts = new List<(string, double)>();
        foreach (var pair in productPrices)
        {
            sortedProducts.Add(pair);
        }

        for (int i = 0; i < sortedProducts.Count - 1; i++)
        {
            for (int j = 0; j < sortedProducts.Count - i - 1; j++)
            {
                if (sortedProducts[j].Item2 > sortedProducts[j + 1].Item2)
                {
                    var temp = sortedProducts[j];
                    sortedProducts[j] = sortedProducts[j + 1];
                    sortedProducts[j + 1] = temp;
                }
            }
        }

        foreach (var (product, price) in sortedProducts)
        {
            Console.WriteLine($"{product}: ${price:0.00}");
        }
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in purchaseOrder)
        {
            total += productPrices[product];
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

       
        cart.AddProduct("Laptop", 999.99);
        cart.AddProduct("Phone", 699.99);
        cart.AddProduct("Mouse", 29.99);
        cart.AddProduct("Keyboard", 49.99);
        cart.AddProduct("Headphones", 149.99);

        
        cart.DisplayCart();

        
        cart.DisplaySortedByPrice();

        // Display total price
        Console.WriteLine($"\nTotal Price: ${cart.GetTotalPrice():0.00}");
    }
}
