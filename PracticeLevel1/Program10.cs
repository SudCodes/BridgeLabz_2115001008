using System;

class Program10{
	
    static double[,] personData = new double[10, 3];
    static string[] bmiStatus = new string[10];     

    
    static void CalculateBMI(){
        for(int i= 0; i<10; i++){
            double heightMeters = personData[i,1]/100; 
            personData[i,2]= personData[i,0]/(heightMeters*heightMeters); 
            bmiStatus[i] = GetBMIStatus(personData[i,2]); 
        }
    }

    static string GetBMIStatus(double bmi){
        if(bmi<18.5) 
			return "Underweight";
        else if(bmi >= 18.5 && bmi < 24.9) 
			return "Normal weight";
        else if(bmi >= 25 && bmi < 39.9) 
			return "Overweight";
        else 
			return "Obesity";
    }
	
	public static void Main(){
		
        for(int i= 0; i<10; i++){
			
            Console.Write("Enter weight for person " + (i+1) + " ");
            personData[i, 0] = double.Parse(Console.ReadLine());
 
            Console.Write("Enter height for person " + (i+1) + " ");
            personData[i, 1] = double.Parse(Console.ReadLine());
        }

        CalculateBMI();

        //Displaying results
		
        for(int i= 0; i<10; i++){
            Console.WriteLine(personData[i,1] + " " + personData[i,0] + " " + personData[i,2].ToString("0.00") + " " +bmiStatus[i]);
        }
    }
}
