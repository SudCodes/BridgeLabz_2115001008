using System;

class Program5{
	
    static double yards2feet = 3, feet2yards = 0.333333, meters2inches = 39.3701, inches2meters = 0.0254, inches2cm = 2.54;

    //Yards to Feet
    public static double ConvertYardsToFeet(double yards){
		return yards*yards2feet; 
	}

    //Feet to Yards
    public static double ConvertFeetToYards(double feet){
		return feet*feet2yards; 
	}

    //meters to inches
    public static double ConvertMetersToInches(double meters){
		return meters * meters2inches; 
	}

    //inches to meters
    public static double ConvertInchesToMeters(double inches){
		return inches * inches2meters; 
	}

    //inches to cm
    public static double ConvertInchesToCm(double inches){
		return inches * inches2cm; 
	}

    public static void Main(){
		
        Console.Write("Enter yards to convert to feet ");
        double yards = double.Parse(Console.ReadLine());
        Console.WriteLine(yards + " yards = " + ConvertYardsToFeet(yards) + " feet");

        Console.Write("Enter feet to convert to yards ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet = " + ConvertFeetToYards(feet) + " yards");

        Console.Write("Enter meters to convert to inches ");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(meters + " meters = " + ConvertMetersToInches(meters) + " inches");

        Console.Write("Enter inches to convert to meters ");
        double inches = double.Parse(Console.ReadLine());
        Console.WriteLine(inches + " inches = " + ConvertInchesToMeters(inches) + " meters");

        Console.Write("Enter inches to convert to centimeters ");
        double inchesToCm = double.Parse(Console.ReadLine());
        Console.WriteLine(inchesToCm + " inches = " + ConvertInchesToCm(inchesToCm) + " cm");
    }
}
