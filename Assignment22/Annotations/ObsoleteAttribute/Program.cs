using System;

class Example
{
    [Obsolete("Use NewMethod() instead.")]
    public void OldMethod()
    {
        Console.WriteLine("This method is obsolete.");
    }

    public void NewMethod()
    {
        Console.WriteLine("This is the new method.");
    }
}

class Program
{
    static void Main()
    {
        Example ex = new Example();
        ex.OldMethod();  // Shows a warning
        ex.NewMethod();
    }
}
