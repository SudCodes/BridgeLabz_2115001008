using System;

class Program1{

    //To find the factors of a number
    public static int[] FindFactors(int number){
		
        int count = 0;
        for(int i= 1; i<=number; i++){
            if(number % i == 0){
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        //loop to store the factors in the array
        for(int i = 1; i <= number; i++){
            if (number % i == 0){
                factors[index++] = i;
            }
        }

        return factors;
    }
	
	//To find the sum of factors
    public static int SumOfFactors(int[] factors){
        int sum = 0;
        for(int i=0; i< factors.Length; i++){
            sum += factors[i];
        }
        return sum;
    }

    // Method to calculate the product of the factors
    public static int ProductOfFactors(int[] factors){
        int p = 1;
        for(int i=0; i< factors.Length; i++){
            p *= factors[i];
        }
        return p;
    }

    //To calculate the sum of the square of the factors
    public static double SumOfSquareOfFactors(int[] factors){
        double sumOfSquares = 0;
        for(int i=0; i< factors.Length; i++){
            sumOfSquares += Math.Pow(factors[i], 2);
        }
        return sumOfSquares;
    }
	
	public static void Main(string[] args){
		
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        //Get the factors of the number
        int[] factors = FindFactors(number);
		
        Console.WriteLine("\nFactors of " + number + ":");
        
		for(int i=0; i< factors.Length; i++){
			Console.Write(factors[i] + " ");
		}

		//To find the sum, product and sum of square of factors
        int sumOfFactors = SumOfFactors(factors);
        int productOfFactors = ProductOfFactors(factors);
        double sumOfSquareOfFactors = SumOfSquareOfFactors(factors);

        // Display the results
		Console.WriteLine();
        Console.WriteLine("Sum of factors: " + sumOfFactors);
		Console.WriteLine("Product of factors: " + productOfFactors);
		Console.WriteLine("Sum of square of factors: " + sumOfSquareOfFactors);
    }
	
}


