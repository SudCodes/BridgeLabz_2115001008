using System;
using System.Collections.Generic;

abstract class CourseType
{
    public string EvaluationMethod { get; set; }

    public CourseType(string evaluationMethod)
    {
        EvaluationMethod = evaluationMethod;
    }

    public abstract void DisplayEvaluation();
}

// Exam-based courses
class ExamCourse : CourseType
{
    public int ExamDuration { get; set; } 

    public ExamCourse(int examDuration) : base("Written Exam")
    {
        ExamDuration = examDuration;
    }

    public override void DisplayEvaluation()
    {
        Console.WriteLine($"Evaluation: {EvaluationMethod}, Duration: {ExamDuration} mins");
    }
}

// Assignment-based courses
class AssignmentCourse : CourseType
{
    public int NumberOfAssignments { get; set; }

    public AssignmentCourse(int numAssignments) : base("Assignments")
    {
        NumberOfAssignments = numAssignments;
    }

    public override void DisplayEvaluation()
    {
        Console.WriteLine($"Evaluation: {EvaluationMethod}, Number of Assignments: {NumberOfAssignments}");
    }
}

// Generic Course class restricted to CourseType
class Course<T> where T : CourseType
{
    public string CourseName { get; set; }
    public string Department { get; set; }
    public T CourseEvaluation { get; set; }

    public Course(string courseName, string department, T courseEvaluation)
    {
        CourseName = courseName;
        Department = department;
        CourseEvaluation = courseEvaluation;
    }

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {CourseName} | Department: {Department}");
        CourseEvaluation.DisplayEvaluation();
    }
}

// University Course Management
class University
{
    private List<Course<CourseType>> courses = new List<Course<CourseType>>();

    public void AddCourse<T>(Course<T> course) where T : CourseType
    {
        courses.Add(course as Course<CourseType>);
    }

    public void DisplayAllCourses()
    {
        Console.WriteLine("\n=== University Course Catalog ===");
        foreach (var course in courses)
        {
            course.DisplayCourseInfo();
            Console.WriteLine("--------------------------------");
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Creating courses
        Course<ExamCourse> mathCourse = new Course<ExamCourse>("Mathematics 101", "Science", new ExamCourse(120));
        Course<AssignmentCourse> literatureCourse = new Course<AssignmentCourse>("Literature 101", "Arts", new AssignmentCourse(5));

        // Managing courses dynamically
        University university = new University();
        university.AddCourse(mathCourse);
        university.AddCourse(literatureCourse);

        // Display all courses
        university.DisplayAllCourses();
    }
}
