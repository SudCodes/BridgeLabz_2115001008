using System;

class Program3{
	
    public static bool IsLeap(int year){
        if(year < 1582){
            Console.WriteLine("The Leap Year program only works for years from 1582 onwards.");
            return false;
        }
		
        return (year%4==0 && year%100!=0) || (year%400==0);
    }

    public static void Main(){
		
        Console.Write("Enter a year to check ");
        int year = int.Parse(Console.ReadLine());
		
        if(IsLeap(year)){
            Console.WriteLine(year + " is a Leap Year.");
        }
        else{
            Console.WriteLine(year + " is NOT a Leap Year.");
        }
    }
}
