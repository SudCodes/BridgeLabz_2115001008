/*
Static Constructor
A static constructor is declared with the help of static keyword. Static Constructor has to be invoked only once in the class and it has been invoked during the creation of 
the first reference to a static member in the class. A static constructor is initialized static fields or data of the class and to be executed only once.
*/

// C# Program to illustrate calling
// a Static constructor
using System;

class StaicConstructor {

    // It is invoked before the first
    // instance constructor is run.
    static StaicConstructor()
    {

        // The following statement produces
        // the first line of output,
        // and the line occurs only once.
        Console.WriteLine("Example of Static Constructor");
    }

    // Instance constructor.
    public StaicConstructor(int j)
    {
        Console.WriteLine("Instance Constructor " + j);
    }

    // Instance method.
    public string g1_detail(string name, string branch)
    {
        return "Name: " + name + " Branch: " + branch;
    }

    // Main Method
    public static void Main()
    {

        // Here Both Static and instance
        // constructors are invoked for
        // first instance
        StaicConstructor obj = new StaicConstructor(1);

        Console.WriteLine(obj.g1_detail("Sunil", "CSE"));

        // Here only instance constructor
        // will be invoked
        StaicConstructor ob = new StaicConstructor(2);

        Console.WriteLine(ob.g1_detail("Sweta", "ECE"));
    }
}