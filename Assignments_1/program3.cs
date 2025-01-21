//Q3. Write a program that takes the temperature in Celsius as input and converts it to Fahrenheit using the formula:

using System;

class Program{
    static void Main(string[] args){
     
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine(celsius + "C is equal to " + fahrenheit+"F");
    }
}
