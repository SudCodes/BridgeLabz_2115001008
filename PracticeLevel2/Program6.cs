using System;

class Program6{
	
	public static int SumNatural(int n){
		int sum=0;
		for(int i=0; i<=n; i++){
			sum+= n;
		}
		return sum;
	}
	
	public static void Main(String[] args){
		
		int number= int.Parse(Console.ReadLine());
		
		Console.WriteLine("Sum of natural numbers = " + SumNatural(number));
	}
}