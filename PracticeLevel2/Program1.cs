using System;

class Program1{
	
	public static double findSI(double p, double r, int t){
		
		return ((p*r*t)/100);
	}
	
	public static void Main(String[] args){
			
			double principal= double.Parse(Console.ReadLine());
			double rate= double.Parse(Console.ReadLine());
			int time= int.Parse(Console.ReadLine());
			
			double si = findSI(principal, rate, time);
			
			Console.WriteLine("Simple Interest is " + si);
	}
}
			