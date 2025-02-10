class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }

    public Course(string coursename, int duration)
    {
        this.CourseName = coursename;
        this.Duration = duration;
    }
    public virtual void DisplayCourseDetails()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks");
    }
}

class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    public OnlineCourse(string coursename, int duration, string platform, bool isRecorded) : base (coursename, duration)
    {
        this.Platform = platform;
        this.IsRecorded = isRecorded;
    }
    public override void DisplayCourseDetails()
    {
        base.DisplayCourseDetails();
        Console.WriteLine($"Platform: {Platform}, Recorded: {(IsRecorded ? "Yes" : "No")}");
    }
}

class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; }

    public PaidOnlineCourse(string coursename, int duration, string platform, bool isRecorded, double fee, double discount) : base (coursename, duration, platform, isRecorded)
    {
        this.Fee = fee;
        this.Discount = discount;
    }
    public override void DisplayCourseDetails()
    {
        base.DisplayCourseDetails();
        double finalPrice = Fee - (Fee * Discount / 100);
        Console.WriteLine($"Fee: {Fee:C}, Discount: {Discount}%, Final Price: {finalPrice:C}");
    }
}

class Program
{
    static void Main()
    {
        Course basicCourse = new Course("Introduction to Programming", 6);
        OnlineCourse onlineCourse = new OnlineCourse("Web Development", 8, "Udemy", true);
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("Data Science Bootcamp", 12, "Coursera", true, 500, 20);

        basicCourse.DisplayCourseDetails();
        Console.WriteLine();
        onlineCourse.DisplayCourseDetails();
        Console.WriteLine();
        paidCourse.DisplayCourseDetails();
    }
}