using System;
using System.Collections.Generic;

abstract class FoodItem
{
    public string ItemName { get; private set; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    public FoodItem(string itemName, double price, int quantity)
    {
        ItemName = itemName;
        Price = price;
        Quantity = quantity;
    }

    public abstract double CalculateTotalPrice();

    public virtual void GetItemDetails()
    {
        Console.WriteLine($"Item: {ItemName}, Price: {Price:C}, Quantity: {Quantity}, Total: {CalculateTotalPrice():C}");
    }
}

interface IDiscountable
{
    void ApplyDiscount(double percentage);
    string GetDiscountDetails();
}

class VegItem : FoodItem, IDiscountable
{
    private double discount;

    public VegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (Price * Quantity) - ((Price * Quantity) * discount / 100);
    }

    public void ApplyDiscount(double percentage)
    {
        discount = percentage;
    }

    public string GetDiscountDetails()
    {
        return $"Discount Applied: {discount}%";
    }

    public override void GetItemDetails()
    {
        base.GetItemDetails();
        Console.WriteLine(GetDiscountDetails());
    }
}

class NonVegItem : FoodItem, IDiscountable
{
    private double discount;
    private double additionalCharge = 10.0;

    public NonVegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return ((Price * Quantity) + additionalCharge) - ((Price * Quantity) * discount / 100);
    }

    public void ApplyDiscount(double percentage)
    {
        discount = percentage;
    }

    public string GetDiscountDetails()
    {
        return $"Discount Applied: {discount}%, Additional Charge: {additionalCharge:C}";
    }

    public override void GetItemDetails()
    {
        base.GetItemDetails();
        Console.WriteLine(GetDiscountDetails());
    }
}

class Program
{
    static void Main()
    {
        List<FoodItem> orderItems = new List<FoodItem>
        {
            new VegItem("Paneer Butter Masala", 200, 2),
            new NonVegItem("Chicken Biryani", 350, 1)
        };

        foreach (var item in orderItems)
        {
            if (item is IDiscountable discountableItem)
            {
                discountableItem.ApplyDiscount(10);
            }

            item.GetItemDetails();
            Console.WriteLine();
        }
    }
}
