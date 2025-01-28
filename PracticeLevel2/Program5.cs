using System;

class Program5{

    public static bool IsSpringSeason(int month, int day){
		
        if((month==3 && day>=20 && day<= 31)||(month==4 && day>=1 && day<=30)||(month==5 && day>=1 && day<=31)||(month==6 && day>=1 && day<=20)){
            return true;
        }
        return false;
    }

    public static void Main(string[] args){
		
        Console.WriteLine("Enter Month ");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter day ");
        int day = int.Parse(Console.ReadLine());

        bool isSpring = IsSpringSeason(month, day);

        if(isSpring){
            Console.WriteLine("It's a Spring Season");
        }
        else{
            Console.WriteLine("It's not a Spring Season");
        }
    }
}
