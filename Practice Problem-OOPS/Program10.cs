using System;

class Student
{
    public int RollNumber { get; set; }
    protected string Name { get; set; }

    private double CGPA { get; set; }

    public Student(int rollNumber, string name, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        SetCGPA(cgpa); 
    }

    // Public method to access CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public method to modify CGPA
    public void SetCGPA(double cgpa)
    {
        if (cgpa >= 0 && cgpa <= 10)
        {
            CGPA = cgpa;
        }
        else
        {
            Console.WriteLine("Invalid CGPA. CGPA should be between 0 and 10.");
        }
    }

    // Method to display student details
    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"CGPA: {GetCGPA()}");
    }
}

class PostgraduateStudent : Student
{
    // Constructor for postgraduate student
    public PostgraduateStudent(int rollNumber, string name, double cgpa)
        : base(rollNumber, name, cgpa)
    {
    }

    // Method to access protected member (Name) from base class
    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine($"Postgraduate Student Details:");
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Name: {Name}"); // Accessing protected member from base class
    }
}

class Program10
{
    public static void Main()
    {
        // Creating a student object
        Student student1 = new Student(101, "John Doe", 8.5);
        student1.DisplayStudentDetails();

        Console.WriteLine();

        // Accessing and modifying CGPA using public methods
        student1.SetCGPA(9.2);
        Console.WriteLine($"Updated CGPA: {student1.GetCGPA()}");

        Console.WriteLine();

        // Creating a postgraduate student object
        PostgraduateStudent pgStudent = new PostgraduateStudent(201, "Jane Smith", 9.0);
        pgStudent.DisplayPostgraduateDetails();
        pgStudent.DisplayStudentDetails();
    }
}
