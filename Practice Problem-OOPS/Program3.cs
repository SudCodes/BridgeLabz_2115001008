using System;

class Person
{
    // Attributes
    public string Name { get; set; }
    public int Age { get; set; }

    // Default Constructor
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Parameterized Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy Constructor (Clones another person's attributes)
    public Person(Person otherPerson)
    {
        Name = otherPerson.Name;
        Age = otherPerson.Age;
        Console.WriteLine("Copy Constructor Called");
    }

    // Method to display the person's details
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program3
{
    public static void Main()
    {
        // Creating an object with the parameterized constructor
        Person person1 = new Person("John", 30);
        person1.Display();

        Console.WriteLine();

        // Creating a copy of person1 using the copy constructor
        Person person2 = new Person(person1);
        person2.Display();
    }
}
