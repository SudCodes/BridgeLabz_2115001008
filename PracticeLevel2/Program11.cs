using System;

class Program11{

    public static double[] Calculations(double angle){
		
        double radians = Math.PI*angle/180;
        return new double[] { Math.Sin(radians), Math.Cos(radians), Math.Tan(radians) };
		
    }
	
    public static void Main(String[] args){
        
		Console.Write("Enter angle in degrees ");
        double angle = double.Parse(Console.ReadLine());

        double[] trigValues = Calculations(angle);

        Console.WriteLine("Sin= " + trigValues[0]);
        Console.WriteLine("Cos= " + trigValues[1]);
        Console.WriteLine("Tan= " + trigValues[2]);
    }
}
