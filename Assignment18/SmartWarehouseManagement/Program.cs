using System;

abstract class WarehouseItem
{
    public String Name { get; set; }
    public double Price { get; set; }

    public WarehouseItem(string name, double price)
    {
        this.Name = name;
        this.Price = price;
    }

    public abstract void displayInfo();

}

class Electronics : WarehouseItem
{
    public int warrantyMonths { get; set; }

    public Electronics(string name, double price, int waranty) : base(name, price)
    {
        this.warrantyMonths = waranty;
    }

    public override void displayInfo()
    {
        Console.WriteLine($"[Electronics] Name: {Name}, Price: {Price}rs, Warranty: {warrantyMonths} months");
    }
}
class Groceries : WarehouseItem
{
    public DateTime ExpiryDate { get; set; }

    public Groceries(string name, double price, DateTime expiry) : base(name, price)
    {
        this.ExpiryDate = expiry;
    }

    public override void displayInfo()
    {
        Console.WriteLine($"[Groceries] Name: {Name}, Price: {Price}rs, Expiry Date: {ExpiryDate.ToShortDateString()}");
    }
}
class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, double price, string material) : base(name, price)
    {
        this.Material = material;
    }

    public override void displayInfo()
    {
        Console.WriteLine($"[Furniture] Name: {Name}, Price: {Price}rs, Material: {Material}");
    }
}

class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>(); 

    public void addItems(T item)
    {
        items.Add(item);
    }

    public void DisplayAllItems()
    {
        foreach (var item in items)
        {
            item.displayInfo();
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Storage<Electronics> electronics = new Storage<Electronics>();
        electronics.addItems(new Electronics("Laptop", 55000, 12));
        electronics.addItems(new Electronics("Phone", 20000, 6));

        Storage<Groceries> groceries = new Storage<Groceries>();  
        groceries.addItems(new Groceries("Sugar", 60, DateTime.Now.AddDays(10)));
        groceries.addItems(new Groceries("Milk", 32, DateTime.Now.AddDays(2)));

        Storage<Furniture> furniture = new Storage<Furniture>();
        furniture.addItems(new Furniture("Table", 1200, "Metal"));
        furniture.addItems(new Furniture("Chair", 1000, "Wood"));

        Console.WriteLine("<====Electronics Storage====>");
        electronics.DisplayAllItems();

        Console.WriteLine("<====Groceries Storage====>");
        groceries.DisplayAllItems();

        Console.WriteLine("<====Furniture Storage====>");
        furniture.DisplayAllItems();


    }
}