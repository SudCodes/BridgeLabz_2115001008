using System;

class Course
{
    // Instance variables
    public string CourseName { get; set; }
    public string Duration { get; set; }
    public double Fee { get; set; }

    // Class variable (shared among all courses)
    public static string InstituteName { get; set; } = "Unknown Institute";

    // Constructor
    public Course(string courseName, string duration, double fee)
    {
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }

    // Instance method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Fee: ${Fee}");
        Console.WriteLine($"Institute: {InstituteName}");
    }

    // Class method to update the institute name for all courses
    public static void UpdateInstituteName(string newInstituteName)
    {
        InstituteName = newInstituteName;
        Console.WriteLine($"Institute name updated to: {InstituteName}");
    }
}

class Program8
{
    public static void Main()
    {
        // Creating courses
        Course course1 = new Course("Web Development", "3 months", 400);
        course1.DisplayCourseDetails();

        Console.WriteLine();

        Course course2 = new Course("Data Science", "6 months", 600);
        course2.DisplayCourseDetails();

        Console.WriteLine();

        // Updating institute name for all courses
        Course.UpdateInstituteName("Tech Academy");

        // Displaying updated course details
        Console.WriteLine("\nUpdated Course Details:");
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}
