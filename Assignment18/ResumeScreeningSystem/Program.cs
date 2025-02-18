using System;
using System.Collections.Generic;

// Abstract class for Job Roles
abstract class JobRole
{
    public string RoleName { get; set; }
    public List<string> RequiredSkills { get; set; }

    public JobRole(string roleName, List<string> skills)
    {
        RoleName = roleName;
        RequiredSkills = skills;
    }

    public abstract void DisplayRoleDetails();
}

// Software Engineer Job Role
class SoftwareEngineer : JobRole
{
    public SoftwareEngineer() : base("Software Engineer", new List<string> { "C#", "ASP.NET", "SQL", "OOP" }) { }

    public override void DisplayRoleDetails()
    {
        Console.WriteLine($"Role: {RoleName}, Required Skills: {string.Join(", ", RequiredSkills)}");
    }
}

// Data Scientist Job Role
class DataScientist : JobRole
{
    public DataScientist() : base("Data Scientist", new List<string> { "Python", "Machine Learning", "Statistics", "SQL" }) { }

    public override void DisplayRoleDetails()
    {
        Console.WriteLine($"Role: {RoleName}, Required Skills: {string.Join(", ", RequiredSkills)}");
    }
}

// Generic Resume Class
class Resume<T> where T : JobRole
{
    public string CandidateName { get; set; }
    public List<string> CandidateSkills { get; set; }
    public T Job { get; set; }

    public Resume(string name, List<string> skills, T job)
    {
        CandidateName = name;
        CandidateSkills = skills;
        Job = job;
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Candidate: {CandidateName} | Applied for: {Job.RoleName}");
        Console.WriteLine($"Skills: {string.Join(", ", CandidateSkills)}");
        Console.WriteLine($"Required Skills: {string.Join(", ", Job.RequiredSkills)}");
        Console.WriteLine("----------------------------------");
    }
}

// Resume Screening System
class ResumeScreeningSystem
{
    private List<object> screenedResumes = new List<object>();

    public void AddResume<T>(Resume<T> resume) where T : JobRole
    {
        screenedResumes.Add(resume);
    }

    public void ScreenResumes()
    {
        Console.WriteLine("\n=== Resume Screening Results ===");
        foreach (var resume in screenedResumes)
        {
            dynamic r = resume;
            r.DisplayResume();
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Creating job roles
        SoftwareEngineer softwareRole = new SoftwareEngineer();
        DataScientist dataRole = new DataScientist();

        // Creating resumes
        Resume<SoftwareEngineer> resume1 = new Resume<SoftwareEngineer>(
            "Alice Johnson", new List<string> { "C#", "ASP.NET", "SQL" }, softwareRole
        );

        Resume<DataScientist> resume2 = new Resume<DataScientist>(
            "Bob Smith", new List<string> { "Python", "Machine Learning", "SQL" }, dataRole
        );

        // Screening system
        ResumeScreeningSystem screeningSystem = new ResumeScreeningSystem();
        screeningSystem.AddResume(resume1);
        screeningSystem.AddResume(resume2);

        // Display results
        screeningSystem.ScreenResumes();
    }
}
