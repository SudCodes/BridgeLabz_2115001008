using System;

class Program7{

    public static int[] Result(int number1, int number2, int number3){
		
        int smallest = (number1<number2)?((number1<number3)?number1:number3):((number2<number3)?number2:number3);

        int largest = (number1>number2)?((number1>number3)?number1:number3):((number2>number3)?number2:number3);

        return new int[] {smallest,largest};
    }
	
    public static void Main(String[] args){
		
        Console.Write("Enter first number ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number ");
        int number3 = int.Parse(Console.ReadLine());

        int[] result = Result(number1, number2, number3);

        Console.WriteLine("Smallest number " + result[0]);
        Console.WriteLine("Largest number " + result[1]);
    }
}
