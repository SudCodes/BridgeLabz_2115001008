/*5. Suppose you have to divide 14 pens among 3 students equally. Write a program to find how many pens each student will get if the pens must be divided equally. Also, find the remaining non-distributed pens.
Hint:
Use Modulus Operator (%) to find the reminder.
Use Division Operator to find the Quantity of pens
I/P => NONE
O/P => The Pen Per Student is ___ and the remaining pen not distributed is ___
*/

using System;

class Program5{
    // Function to calculate pens per student and remaining pens
    public static void CalculatePens(int totalPens, int totalStudents){
        // Calculate the number of pens each student will get
        int pensPerStudent = totalPens / totalStudents;

        // Calculate the remaining pens (non-distributed)
        int remainingPens = totalPens % totalStudents;

        // Display the results
        Console.WriteLine($"The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remainingPens}");
    }

    public static void Main(){
        // Total number of pens and students
        int totalPens = 14;
        int totalStudents = 3;

        // Call the function to calculate pens per student and remaining pens
        CalculatePens(totalPens, totalStudents);
    }
}
