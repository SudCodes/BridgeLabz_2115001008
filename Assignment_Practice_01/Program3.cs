/*3. Create a program to convert the distance of 10.8 kilometers to miles.
Hint: 1 km = 1.6 miles
I/P => NONE
O/P => The distance ___ km in miles is ___
*/

using System;

class Program3{
	//Fuction to convert kilometers to miles
	public static double CalculateMiles(double kilometers){
		return kilometers * 1.6;
	}
	public static void Main(){
		//Initialize the kilometers
		double kilometers = 10.8.;
		
		//call the CalculateMiles function to convert KM to Miles
		double miles = CalculateMiles(kilometers); 
		
		//Output 
		Console.WriteLine("The distance " + kilometers + " km in miles is " + miles);
	}
}