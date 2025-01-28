using System;

class Program7{ 

    public static bool CanStudentVote(int age){
        if(age<0){
            return false;
        }
		
        return age >= 18;
    }

    public static void Main(){
		
        int[] studentAges = new int[10];

        for(int i= 0; i<studentAges.Length; i++){
			
            Console.Write("Enter age of student ");
            studentAges[i] = int.Parse(Console.ReadLine());

            if(CanStudentVote(studentAges[i])){
                Console.WriteLine("Student " + (i + 1) + " is eligible to vote.");
            }
            else{
                Console.WriteLine("Student " + (i + 1) + " is Not eligible to vote.");
            }
        }
    }
}
