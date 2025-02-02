using System;

class Circle
{
    // Radius attribute
    public double Radius { get; set; }

    // Default Constructor (calls the parameterized constructor with default value)
    public Circle() : this(1.0) // Constructor chaining
    {
        Console.WriteLine("Default Constructor Called");
    }

    // Parameterized Constructor
    public Circle(double radius)
    {
        Radius = radius;
        Console.WriteLine("Parameterized Constructor Called");
    }

    // Method to calculate the area of the circle
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Method to display the circle's radius and area
    public void Display()
    {
        Console.WriteLine($"Radius: {Radius}");
        Console.WriteLine($"Area: {GetArea()}");
    }
}

class Program2
{
    public static void Main()
    {
        
        Circle circle1 = new Circle();
        circle1.Display();

        Console.WriteLine();

        
        Circle circle2 = new Circle(5.0);
        circle2.Display();
    }
}
