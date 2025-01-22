/*Write a program that takes your height in centimeters and converts it into feet and inches
Hint: 1 foot = 12 inches and 1 inch = 2.54 cm
I/P => height
O/P => Your Height in cm is ___ while in feet is ___ and inches is ___
*/

using System;

class HeightConversion{
    // Function to convert height from cm to feet and inches
    public static void ConvertHeight(double cm){
        // 1 inch = 2.54 cm and 1 foot = 12 inches
        double totalInches = cm / 2.54;
        int feet = (int)(totalInches / 12);  // Convert to feet
        int inches = (int)(totalInches % 12);  // Remaining inches

        // Output the results
        Console.WriteLine("Your Height in cm is " + cm + " while in feet is " + feet + " and inches is " + inches);
    }

    public static void Main(){
        // Prompt user to enter height in centimeters
        Console.Write("Enter your height in cm: ");
        double cm = Convert.ToDouble(Console.ReadLine());

        // Call the function to convert the height
        ConvertHeight(cm);
    }
}