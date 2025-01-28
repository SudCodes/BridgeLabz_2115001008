using System;

class Program8{
	
    public static string Youngest(string[] names, int[] ages){
		
        int minAge = ages[0];
        string youngest = names[0];

        for(int i=1; i<ages.Length; i++){
			
            if (ages[i]<minAge){
                minAge = ages[i];
                youngest = names[i];
            }
        }
        return youngest;
    }


    public static string FindTallest(string[] names, double[] heights){
        double maxHeight = heights[0];
        string tallest = names[0];

        for(int i=1; i<heights.Length; i++){
			
            if (heights[i]>maxHeight){
                maxHeight = heights[i];
                tallest = names[i];
            }
        }
        return tallest;
    }

    public static void Main(){
		
        string[] friends = {"Amar", "Akbar", "Anthony"};
        int[] ages = new int[3]; 
        double[] heights = new double[3]; 
		
        for (int i = 0; i < 3; i++){
			
            Console.Write("Enter the age of " + friends[i] + " ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height of " + friends[i] + " ");
            heights[i] = double.Parse(Console.ReadLine());
        }

		//finding youngest and tallest among them
		
        string youngestFriend = Youngest(friends, ages);
        string tallestFriend = FindTallest(friends, heights);

        //displaying the results
        Console.WriteLine("The youngest friend is " + youngestFriend);
        Console.WriteLine("The tallest friend is " + tallestFriend);
    }
}
