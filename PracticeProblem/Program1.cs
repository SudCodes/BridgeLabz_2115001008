using System;

class Program1
{
    static void Main()
    {
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        
        // GMT (UTC)
        Console.WriteLine("GMT (UTC) Time: " + utcNow.ToString("yyyy-MM-dd HH:mm:ss"));
        
        // IST (Indian Standard Time, UTC+5:30)
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istZone);
        Console.WriteLine("IST Time: " + istTime.ToString("yyyy-MM-dd HH:mm:ss"));
        
        // PST (Pacific Standard Time)
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);
        Console.WriteLine("PST Time: " + pstTime.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}
