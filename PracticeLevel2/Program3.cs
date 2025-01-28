using System;

class Program3{
    static int NumberOfRounds(double side1, double side2, double side3, double distance){
		
        double perimeter = side1 + side2 + side3;

        double rounds = (distance * 1000) / perimeter;
        return (int)Math.Ceiling(rounds);
    }

    static void Main(string[] args){
		
		//Taking input from the user
        Console.WriteLine("Enter the sides of the park ");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the distance the athlete wants to run ");
        double distance = double.Parse(Console.ReadLine());

        int rounds = NumberOfRounds(side1, side2, side3, distance);

        //Displaying the result
        Console.WriteLine("Number of rounds required to complete " + rounds);
    }
}
