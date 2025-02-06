using System;

// Course class
class Course
{
    public string Name { get; set; }
    public Professor AssignedProfessor { get; private set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course(string name)
    {
        Name = name;
        EnrolledStudents = new List<Student>();
    }

    public void AssignProfessor(Professor professor)
    {
        AssignedProfessor = professor;
        professor.AssignCourse(this);
    }

    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student);
            student.EnrollInCourse(this);
        }
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Course: {Name}");
        Console.WriteLine($"Professor: {(AssignedProfessor != null ? AssignedProfessor.Name : "Not Assigned")}");
        Console.WriteLine("Enrolled Students:");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine($"  {student.Name}");
        }
    }
}

// Professor class
class Professor
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Professor(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }

    public void AssignCourse(Course course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
          
        }
    }

    public void ViewCourses()
    {
        Console.WriteLine($"Professor: {Name} - Courses Teaching:");
        foreach (var course in Courses)
        {
            Console.WriteLine($"  {course.Name}");
        }
    }
}

// Student class
class Student
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }

    public void EnrollInCourse(Course course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
        }
    }

    public void ViewEnrolledCourses()
    {
        Console.WriteLine($"Student: {Name} - Enrolled Courses:");
        foreach (var course in Courses)
        {
            Console.WriteLine($"  {course.Name}");
        }
    }
}

class Program
{
    static void Main()
    {
        Professor prof1 = new Professor("Rahul Pradhan");
        Professor prof2 = new Professor("Mayank Srivastva");

        Student student1 = new Student("Aman Gupta");
        Student student2 = new Student("Akshat Shandilya");

        Course course1 = new Course("Mathematics");
        Course course2 = new Course("Physics");

        course1.AssignProfessor(prof1);
        course2.AssignProfessor(prof2);

        course1.EnrollStudent(student1);
        course1.EnrollStudent(student2);
        course2.EnrollStudent(student1);

        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();

        student1.ViewEnrolledCourses();
        student2.ViewEnrolledCourses();

        prof1.ViewCourses();
        prof2.ViewCourses();
    }
}
