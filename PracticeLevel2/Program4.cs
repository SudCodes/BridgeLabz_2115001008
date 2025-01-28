using System ;


class Program4{
	
    public static int Check(int n){
        if(n>0){
            return 1;
        }
        else if(n<0){
            return -1;
        }
        else{
            return 0 ;
        }
	}
	
    public static void Main(string[] args){
		
		//user input
        Console.WriteLine("Enter a number ");
        int number = int.Parse(Console.ReadLine());

        int result = Check(number);
        
        if(result==1){
        Console.WriteLine("The number is Positive");
        }
        else if(result==-1){
        Console.WriteLine("The number is Negative");
        }
        else{
          Console.WriteLine("The number is Zero");
        }
    }
}