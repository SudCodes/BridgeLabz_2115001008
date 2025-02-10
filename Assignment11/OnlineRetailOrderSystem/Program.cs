using System;

class Order
{
    public int OrderID { get; set; }
    public string OrderDate { get; set; }

    public Order(int orderId, string orderDate)
    {
        this.OrderID = orderId;
        this.OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order placed successfully!";
    }
    public virtual void DisplayOrderDetails()
    {
        Console.WriteLine($"Order ID: {OrderID}, Order Date: {OrderDate}, Status: {GetOrderStatus()}");
    }
}

class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    public ShippedOrder(int orderId, string orderDate, string trackingNumber) : base(orderId, orderDate)
    {
        this.TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order Shipped Successfully!!";
    }
    public override void DisplayOrderDetails()
    {
        base.DisplayOrderDetails();
        Console.WriteLine($"Tracking Number: {TrackingNumber}");
    }

}

class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate { get; set; }

    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate) : base(orderId, orderDate, trackingNumber)
    {
        this.DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order Delivered Successfully!!!";
    }
    public override void DisplayOrderDetails()
    {
        base.DisplayOrderDetails();
        Console.WriteLine($"Delivery Date: {DeliveryDate}");
    }
}
class Program
{
    static void Main()
    {
        Order order = new Order(1001, "2024-02-08");
        ShippedOrder shippedOrder = new ShippedOrder(1002, "2024-02-07", "TRK123456");
        DeliveredOrder deliveredOrder = new DeliveredOrder(1003, "2024-02-06", "TRK789012", "2024-02-08");

        order.DisplayOrderDetails();
        Console.WriteLine();
        shippedOrder.DisplayOrderDetails();
        Console.WriteLine();
        deliveredOrder.DisplayOrderDetails();
    }
}
