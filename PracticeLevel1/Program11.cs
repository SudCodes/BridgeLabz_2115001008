using System;

class Program11{
	
    static void FindRoots(double a, double b, double c){
		
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if(delta>0){
            double root1 = (-b+Math.Sqrt(delta))/(2*a);
            double root2 = (-b-Math.Sqrt(delta))/(2*a);
            Console.WriteLine("Roots = " + root1 + " and " + root2);
        }
        else if(delta == 0){
            double root = -b/(2*a);
            Console.WriteLine("Root = " + root);
        }
        else{
            Console.WriteLine("No real roots exists");
        }
    }

    public static void Main(){
		
        Console.Write("Enter value of a ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value of c ");
        double c = double.Parse(Console.ReadLine());

        FindRoots(a, b, c);
    }
}
