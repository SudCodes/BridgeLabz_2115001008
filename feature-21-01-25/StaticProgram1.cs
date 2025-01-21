//Static Class
/*
A static class is declared with the help of static keyword. A static class can only contain static data members, static methods, and a static constructor. 
It is not allowed to create objects of the static class. Static classes are sealed, means one cannot inherit a static class from another class.
*/

using System;

// Creating static class
// Using static keyword
static class Tutorial {

    // Static data members of Tutorial
    public static string Topic = "Static class";
}

// Driver Class
public class StaticProgram1 {

    // Main Method
    static public void Main()
    {

        // Accessing the static data members of Tutorial
        Console.WriteLine("Topic name is : {0} ", Tutorial.Topic);
    }
}