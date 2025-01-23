// Creating Class with name Program7 to check if the date falls in Spring Season
using System;
class Program7
{
    public static string CheckSpringSeason(int month, int day)
    {
        // Check if the date is within Spring Season
        bool isSpring = (month == 3 && day >= 20)||
                        (month > 3 && month < 6)||
                        (month == 6 && day <= 20);

        // Return the result
        return isSpring ? "It's a Spring Season." : "Not a Spring Season.";
    }
}