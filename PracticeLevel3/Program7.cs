using System;

public class Program7
{
    // Method to generate a 6-digit OTP number using Math.Random()
    public static int GenerateOTP()
    {
        Random random = new Random();
        int otp = random.Next(100000, 999999); 
        return otp;
    }

    // Method to ensure that the OTP numbers generated are unique
    public static bool AreUniqueOTPs(int[] otpNumbers)
    {
        // Check if any OTP appears more than once in the array
        for (int i = 0; i < otpNumbers.Length; i++)
        {
            for (int j = i + 1; j < otpNumbers.Length; j++)
            {
                if (otpNumbers[i] == otpNumbers[j]) 
                {
                    return false; 
                }
            }
        }
        return true; // Return true if all OTPs are unique
    }

    // Main method to generate 10 OTPs and ensure they are unique
    public static void Main()
    {
        int[] otpNumbers = new int[10]; // Array to hold the 10 OTP numbers

        // Generate 10 OTPs
        for (int i = 0; i < 10; i++)
        {
            otpNumbers[i] = GenerateOTP();
            Console.WriteLine($"Generated OTP {i + 1}: {otpNumbers[i]}");
        }

      
        bool areUnique = AreUniqueOTPs(otpNumbers);

       
        if (areUnique)
        {
            Console.WriteLine("All OTPs are unique.");
        }
        else
        {
            Console.WriteLine("Some OTPs are not unique.");
        }
    }
}
