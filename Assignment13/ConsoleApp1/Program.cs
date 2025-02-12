using System;
class Student
{
    public int rollNumber;
    public string name;
    public int age;
    public char grade;
    public Student next;

    public Student(int rollNumber, string name, int age, char grade)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.age = age;
        this.grade = grade;
        this.next = null;
    }

}

class StudentList
{
    private Student head;

    public void addStudentAtBeginning(int rollNumber, String name, int age, char grade)
    {
        Student newStudent = new Student(rollNumber, name, age, grade);
        newStudent.next = head;
        head = newStudent;
    }
    public void addStudentAtEnd(int rollNumber, String name, int age, char grade)
    {
        Student newStudent = new Student(rollNumber, name, age, grade);
        if(head == null)
        {
            head = newStudent;
            return;
        }
        Student temp = head;
        while(temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newStudent;
    }

    public void addStudentAtPosition(int rollnumber, String name, int age, char grade, int position)
    {
        if(position <= 0)
        {
            addStudentAtBeginning(rollnumber, name, age, grade);
            return;
        }

        Student newStudent = new Student(rollnumber, name, age, grade);
        Student temp = head;

        for(int i = 0; i < position-1 && temp != null; i++)
        {
            temp = temp.next;
        }
        if(temp == null)
        {
            addStudentAtEnd(rollnumber, name, age, grade);
            return;
        }
        newStudent.next = temp.next;
        temp.next = newStudent;
    }

    public void deleteStudent(int rollnumber)
    {
        if (head == null) return;
        if (head.rollNumber == rollnumber)
        {
            head = head.next;
            return;
        }
        Student temp = head;

        while (temp.next != null && temp.next.rollNumber != rollnumber)
        {
            temp = temp.next;
        }
        if (temp.next != null)
        {
            temp.next = temp.next.next;
        }

    }
    public Student searchStudent(int rollNumber)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.rollNumber == rollNumber)
            {
                return temp;
            }
            temp = temp.next;
        }
        return null;
    }

    public void updateGrade(int rollNumber, char newGrade)
    {
        Student student = searchStudent(rollNumber);
        if (student != null)
        {
            student.grade = newGrade;
        }
    }
    public void displayStudents()
    {
        Student temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Roll No: { temp.rollNumber} , Name: {temp.name}, Age: {temp.age}, Grade: {temp.grade}");
            temp = temp.next;
        }
    }
}
public class StudentRecordManager
{
    public static void Main(String[] args)
    {
        StudentList studentList = new StudentList();
        studentList.addStudentAtBeginning(101, "Alice", 20, 'A');
        studentList.addStudentAtEnd(102, "Bob", 21, 'B');
        studentList.addStudentAtPosition(103, "Charlie", 22, 'C', 1);
        studentList.displayStudents();
        Console.WriteLine("After deletion:");
        studentList.deleteStudent(102);
        studentList.displayStudents();
        Console.WriteLine("Updating grade:");
        studentList.updateGrade(103, 'A');
        studentList.displayStudents();
    }
}
