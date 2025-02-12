using System;

class Item
{
    public string itemName;
    public int itemId;
    public int quantity;
    public double price;
    public Item next;

    public Item(string itemName, int itemId, int quantity, double price)
    {
        this.itemName = itemName;
        this.itemId = itemId;
        this.quantity = quantity;
        this.price = price;
        this.next = null;
    }
}

class Inventory
{
    private Item head;

    public void AddItemAtBeginning(string itemName, int itemId, int quantity, double price)
    {
        Item newItem = new Item(itemName, itemId, quantity, price);
        newItem.next = head;
        head = newItem;
    }

    public void AddItemAtEnd(string itemName, int itemId, int quantity, double price)
    {
        Item newItem = new Item(itemName, itemId, quantity, price);
        if (head == null)
        {
            head = newItem;
            return;
        }
        Item temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newItem;
    }

    public void RemoveItem(int itemId)
    {
        if (head == null) return;
        if (head.itemId == itemId)
        {
            head = head.next;
            return;
        }
        Item temp = head;
        while (temp.next != null && temp.next.itemId != itemId)
        {
            temp = temp.next;
        }
        if (temp.next != null)
        {
            temp.next = temp.next.next;
        }
    }

    public void UpdateQuantity(int itemId, int newQuantity)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.itemId == itemId)
            {
                temp.quantity = newQuantity;
                return;
            }
            temp = temp.next;
        }
    }

    public Item SearchItem(int itemId, string itemName = null)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.itemId == itemId || (itemName != null && temp.itemName == itemName))
                return temp;
            temp = temp.next;
        }
        return null;
    }

    public double CalculateTotalValue()
    {
        double totalValue = 0;
        Item temp = head;
        while (temp != null)
        {
            totalValue += temp.price * temp.quantity;
            temp = temp.next;
        }
        return totalValue;
    }

    public void DisplayInventory()
    {
        Item temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Item Name: {temp.itemName}, ID: {temp.itemId}, Quantity: {temp.quantity}, Price: {temp.price}");
            temp = temp.next;
        }
    }
}

public class InventoryManager
{
    public static void Main()
    {
        Inventory inventory = new Inventory();
        inventory.AddItemAtBeginning("Laptop", 101, 5, 1200.00);
        inventory.AddItemAtEnd("Mouse", 102, 10, 25.50);
        inventory.AddItemAtEnd("Keyboard", 103, 7, 45.75);

        Console.WriteLine("Current Inventory:");
        inventory.DisplayInventory();

        Console.WriteLine("\nUpdating quantity of Mouse:");
        inventory.UpdateQuantity(102, 15);
        inventory.DisplayInventory();

        Console.WriteLine("\nTotal Inventory Value: " + inventory.CalculateTotalValue());

        Console.WriteLine("\nRemoving Keyboard:");
        inventory.RemoveItem(103);
        inventory.DisplayInventory();
    }
}
