using System;
using System.IO;

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public float GPA { get; set; }

    public Student(int rollNumber, string name, float gpa)
    {
        RollNumber = rollNumber;
        Name = name;
        GPA = gpa;
    }

    public override string ToString()
    {
        return $"Roll No: {RollNumber}, Name: {Name}, GPA: {GPA}";
    }
}

class StudentDataHandler
{
    private static string filePath = "D:\\Capgemini-Tranning\\Assignments\\Assignment20\\ReadAndWrite\\students.dat";

    public static void StoreStudentData(Student student)
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(student.RollNumber);
                writer.Write(student.Name);
                writer.Write(student.GPA);
            }
            Console.WriteLine("Student data saved successfully!");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File operation failed: {ex.Message}");
        }
    }

    public static void RetrieveStudentData()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No student data found.");
                return;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                Console.WriteLine("\nStored Student Data:");
                while (fs.Position < fs.Length)
                {
                    int rollNumber = reader.ReadInt32();
                    string name = reader.ReadString();
                    float gpa = reader.ReadSingle();
                    Console.WriteLine($"Roll No: {rollNumber}, Name: {name}, GPA: {gpa}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File operation failed: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Storing Student Data
        StudentDataHandler.StoreStudentData(new Student(101, "Rahul", 3.8f));
        StudentDataHandler.StoreStudentData(new Student(102, "Sameer", 3.5f));
        StudentDataHandler.StoreStudentData(new Student(103, "Vidya", 3.9f));

        // Retrieving Student Data
        StudentDataHandler.RetrieveStudentData();
    }
}
