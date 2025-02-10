using System;

class Animal
{
    public string name;
    public int age;

    public Animal(string Name, int Age)
    {
        this.name = Name;
        this.age = Age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Birds chirps");
    }
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog("Kutta", 3);
        Animal myCat = new Cat("Billy", 2);
        Animal myBird = new Bird("Tota", 1);

        myDog.MakeSound();
        myCat.MakeSound();
        myBird.MakeSound();
    }
}