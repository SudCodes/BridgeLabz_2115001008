using System;

class Program9{
	
    public static bool IsPositive(int number){
        return number>=0;
    }

    public static bool IsEven(int number){
        return number%2==0;
    }

    public static int Compare(int number1, int number2){
        if(number1>number2){
            return 1;
		}
        else if(number1 < number2){
            return -1;
		}
        else{
            return 0;
		}
    }

    public static void Main(){
		
        int[] numbers = new int[5];

        for(int i= 0; i<5; i++){
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for(int i= 0; i<numbers.Length; i++){
            if(IsPositive(numbers[i])){
                Console.Write(numbers[i] + " is Positive and ");
                if (IsEven(numbers[i]))
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
            else{
                Console.WriteLine(numbers[i] + " is Negative");
            }
        }

		if(numbers[0]>numbers[4]){
			Console.WriteLine("First number is greater than the last number.");
		}
		else if(numbers[0]<numbers[4]){
			Console.WriteLine("First number is less than the last number.");
		}
		else{
			Console.WriteLine("First and last numbers are equal.");
		}
    }
}
