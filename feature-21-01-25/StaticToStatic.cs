/* Static -> Static
Meaning: A static method calling a static member (field or method).
How to Call: Static members can be called directly within the same class or by using the class name. */


using System;

class StaticToStatic {
    static void StaticMethod() {
        Console.WriteLine("Static method");
    }

    static void CallStaticMethod() {
        StaticMethod();  // Calling static method from another static method
    }

    static void Main(string[] args) {
        CallStaticMethod();  // Calling the static method
    }
}