using System;

class Program12{

    public static int[] RandomArray(int size){
		
		
		//Generate random numbers
		
        Random random = new Random();
        int[] numbers = new int[size];

        for(int i= 0; i<size; i++){
            numbers[i] = random.Next(1000, 10000);
        }
		
        return numbers;
    }

    public static double[] Results(int[] numbers){
		
        int min= numbers[0], max= numbers[0], sum= numbers[0];

        for(int i= 1; i<numbers.Length; i++){
            sum += numbers[i];
            if(numbers[i]<min){
                min = numbers[i];
			}
            if(numbers[i]>max){
                max = numbers[i];
			}
        }

        double average= (double)sum/numbers.Length;
        return new double[] {average, min, max};
    }
	
	public static void Main(){
	
        int size = 5;
        int[] numbers = RandomArray(size);

        Console.WriteLine("Generated Numbers ");
        for(int i= 0; i<size; i++){
            Console.Write(numbers[i] + " ");
        }
		
        Console.WriteLine();

        double[] results = Results(numbers);

        Console.WriteLine("Average " + results[0]);
        Console.WriteLine("Minimum " + results[1]);
        Console.WriteLine("Maximum " + results[2]);
    }
}
