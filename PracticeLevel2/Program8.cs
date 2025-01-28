using System;

class Program8{
	
	public static int[] Result(int n1, int n2){
		
		int rem= n1%n2;
		int quot= n1/n2;
		
		return new int[] {rem, quot};
	}
	
	public static void Main(String[] args){
		
		int number1= int.Parse(Console.ReadLine());
		int number2= int.Parse(Console.ReadLine());
		
		int[] res= Result(number1, number2);
		
		//Displaying Result
		
		Console.WriteLine("Remainder = " + res[0] + " Quotient = " + res[1]);
	}
}	