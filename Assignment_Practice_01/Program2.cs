/*2. Sam’s mark in Maths is 94, Physics is 95, and Chemistry is 96 out of 100. Find the average percent mark in PCM
I/P => NONE
O/P => Sam’s average mark in PCM is ___
*/

using System;

class Program2{
    // Function to calculate average marks
    public static double CalculateAverage(int maths, int physics, int chemistry){
        // Calculate the sum of the marks
        int totalMarks = maths + physics + chemistry;
        
        // Calculate and return the average
        return totalMarks / 3.0;  // Dividing by 3.0 to get a decimal result
    }

    public static void Main(){
        // Sam's marks in Maths, Physics, and Chemistry
        int maths = 94;
        int physics = 95;
        int chemistry = 96;

        // Calculate the average mark
        double average = CalculateAverage(maths, physics, chemistry);

        // Output Sam's average mark in PCM
        Console.WriteLine("Sam's average mark in PCM is "+average:F2);
    }
}