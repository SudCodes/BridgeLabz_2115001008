/* Static -> Non-Static
Meaning: A static method trying to access non-static members.
How to Call: Static methods cannot directly access non-static members. You must create an instance of the class. */


using System;
class StaticToNonStatic {
    void NonStaticMethod() {
        Console.WriteLine("Non-static method");
    }

    static void StaticMethod() {
        Example obj = new Example();  // Creating an instance of the class
        obj.NonStaticMethod();  // Calling non-static method
    }

    static void Main(string[] args) {
        StaticMethod();  // Calling the static method
    }
}