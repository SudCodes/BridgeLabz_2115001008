using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Role: Teacher, Subject: {Subject}");
    }
}

class Student : Person
{
    public int Grade { get; set; }

    public Student(string name, int age, int grade)
        : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Role: Student, Grade: {Grade}");
    }
}

class Staff : Person
{
    public string Department { get; set; }

    public Staff(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Role: Staff, Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher("Mr. Sharma", 40, "Mathematics");
        Student student = new Student("Aditi", 16, 10);
        Staff staff = new Staff("Mrs. Verma", 35, "Administration");

        teacher.DisplayDetails();
        Console.WriteLine();
        student.DisplayDetails();
        Console.WriteLine();
        staff.DisplayDetails();
    }
}
