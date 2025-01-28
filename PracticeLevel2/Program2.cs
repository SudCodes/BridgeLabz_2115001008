using System;

class Program2{
	
	public static int PossibleHandshake(int n){
		return ((n*(n-1))/2);
	}
	
	public static void Main(String[] args){
		
		int number= int.Parse(Console.ReadLine());
		
		Console.WriteLine("Possible number of handshake = " + PossibleHandshake(number));
	}
}