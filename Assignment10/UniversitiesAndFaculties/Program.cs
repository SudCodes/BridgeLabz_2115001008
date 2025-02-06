using System;
using System.Collections.Generic;

// Faculty class (Independent entity, Aggregation)
class Faculty
{
    public string Name { get; set; }

    public Faculty(string name)
    {
        Name = name;
    }
}

// Department class (Composition - Exists only within University)
class Department
{
    public string Name { get; set; }
    public List<Faculty> Faculties { get; set; }

    public Department(string name)
    {
        Name = name;
        Faculties = new List<Faculty>();
    }

    public void AddFaculty(Faculty faculty)
    {
        Faculties.Add(faculty);
    }
}

// University class (Composition with Departments, Aggregation with Faculties)
class University
{
    public string Name { get; set; }
    private List<Department> Departments;
    public List<Faculty> FacultyMembers { get; set; }

    public University(string name)
    {
        Name = name;
        Departments = new List<Department>();
        FacultyMembers = new List<Faculty>();
    }

    public void AddDepartment(string departmentName)
    {
        Departments.Add(new Department(departmentName));
    }

    public void AddFaculty(Faculty faculty)
    {
        FacultyMembers.Add(faculty);
    }

    public void AssignFacultyToDepartment(string departmentName, Faculty faculty)
    {
        var department = Departments.Find(d => d.Name == departmentName);
        if (department != null)
        {
            department.AddFaculty(faculty);
        }
    }

    public void DisplayUniversityStructure()
    {
        Console.WriteLine($"University: {Name}");
        Console.WriteLine("Departments:");
        foreach (var department in Departments)
        {
            Console.WriteLine($"  {department.Name}");
            Console.WriteLine("    Faculty Members:");
            foreach (var faculty in department.Faculties)
            {
                Console.WriteLine($"      {faculty.Name}");
            }
        }
        Console.WriteLine("Independent Faculty Members:");
        foreach (var faculty in FacultyMembers)
        {
            Console.WriteLine($"  {faculty.Name}");
        }
    }
}

class Program
{
    static void Main()
    {
        University university = new University("GLA University");
        university.AddDepartment("Computer Science");
        university.AddDepartment("Mathematics");

        Faculty faculty1 = new Faculty("Prabhat Chouhan");
        Faculty faculty2 = new Faculty("Sahil");
        Faculty faculty3 = new Faculty("Chandra Sekhar");

        university.AddFaculty(faculty1);
        university.AddFaculty(faculty2);
        university.AddFaculty(faculty3);

        university.AssignFacultyToDepartment("Computer Science", faculty1);
        university.AssignFacultyToDepartment("Mathematics", faculty2);

        university.DisplayUniversityStructure();
    }
}
