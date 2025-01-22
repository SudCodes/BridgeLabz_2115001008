/*Create a program to convert distance in kilometers to miles.
Hint:
Create a variable km and assign type as double as in double km;
Create Scanner Object to take user input from Standard Input that is the Keyboard as in Scanner input = new Scanner(System.in);
Use Scanner Object to take user input for km as in km = input.nextInt();
Use 1 mile = 1.6 km formulae to calculate miles and show the output
I/P => km
O/P => The total miles is ___ mile for the given ___ km
*/



using System;

class KilometerToMile{
    // Function to convert kilometers to miles
    static double ConvertKmToMiles(double km){
        return km / 1.6;
    }

    static void Main(){
        // Prompt user to enter distance in kilometers
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        
        // Call the function to convert kilometers to miles
        double miles = ConvertKmToMiles(km);
        
        // Output the result
        Console.WriteLine("The total miles is " + miles + " mile(s) for the given " + km + " km.");
    }
}

