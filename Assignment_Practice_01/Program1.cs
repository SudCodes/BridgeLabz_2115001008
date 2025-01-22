/* Write a program to find the age of Harry if the birth year is 2000. Assume the Current Year is 2024
I/P => NONE
O/P => Harry's age in 2024 is ___
*/

using System;

class Program1{
    // Function to calculate age
    public static int CalculateAge(int birthYear, int currentYear){
        // Subtract birth year from current year to calculate age
        return currentYear - birthYear;
    }

    public static void Main(){
        // Initialize birth year and current year
        int birthYear = 2000;
        int currentYear = 2024;

        // Call the CalculateAge function to get Harry's age
        int age = CalculateAge(birthYear, currentYear);
        // Output Harry's age
        Console.WriteLine("Harry's age in 2024 is " + age);
    }
}
