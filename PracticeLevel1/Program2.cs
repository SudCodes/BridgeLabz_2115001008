using System;

class Program2{
	
    static int Sum(int n){
        if(n==1) 
			return 1;
        return n+Sum(n - 1);
    }

    static int SumFormula(int n){
        return n*(n+1)/2;
    }

    public static void Main(String[] args){
		
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());


        //Sum using recursion
        int sumRecursive = Sum(n);

        //Sum using formula
        int sumFormula = SumFormula(n);

        //Displaying results
        Console.WriteLine("Sum using recursion: " + sumRecursive);
        Console.WriteLine("Sum using formula: " + sumFormula);

        //Comparing result of both methods
        if(sumRecursive == sumFormula){
            Console.WriteLine("The result is correct");
        }
        else{
            Console.WriteLine("Both the results are not matching");
        }
    }
}
