/*  Non-Static -> Non-Static
Meaning: A non-static method calling non-static members.
How to Call: Non-static members can be directly accessed from non-static methods of the same instance. */


using System;

class NonStaticToNonStatic {
    void NonStaticMethod1() {
        Console.WriteLine("Non-static method 1");
    }

    void NonStaticMethod2() {
        NonStaticMethod1();  // Calling another non-static method
    }

    static void Main(string[] args) {
        Example obj = new Example();  // Creating an instance of the class
        obj.NonStaticMethod2();  // Calling the non-static method
    }
}