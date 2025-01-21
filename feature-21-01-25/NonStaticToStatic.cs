/* Non-Static -> Static
Meaning: A non-static method accessing static members.
How to Call: Non-static methods can directly access static members without requiring an instance. */



using System;

class NonStaticToStatic {
    static void StaticMethod() {
        Console.WriteLine("Static method");
    }

    void NonStaticMethod() {
        StaticMethod();  // Calling static method from non-static method
    }

    static void Main(string[] args) {
        Example obj = new Example();
        obj.NonStaticMethod();  // Calling the non-static method
    }
}