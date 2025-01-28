using System;


class Program9{
	
    public static int[] choclates(int number,int children){ 
	
    int choc= number/children ;
    int remaining= number%children ;

    return new int[] {choc,remaining};
}
    public static void Main(String[] args){
		
        //user input 
        Console.WriteLine("Enter the number of choclates ");
        int number = int.Parse(Console.ReadLine());
		
        Console.WriteLine("Enter the number of children ");
        int children = int.Parse(Console.ReadLine());

        int[] result = choclates(number,children);
		
        Console.WriteLine("Number of choclates " + result[0] + "\nThe remaining choclates is " + result[1]);
    }
}
