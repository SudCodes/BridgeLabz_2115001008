using System;

class HotelBooking
{
    // Attributes
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }

    // Default Constructor
    public HotelBooking()
    {
        GuestName = "Unknown";
        RoomType = "Standard";
        Nights = 1;
    }

    // Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    // Copy Constructor (Clones another booking)
    public HotelBooking(HotelBooking otherBooking)
    {
        GuestName = otherBooking.GuestName;
        RoomType = otherBooking.RoomType;
        Nights = otherBooking.Nights;
        Console.WriteLine("Copy Constructor Called");
    }

    // Method to display booking details
    public void DisplayBookingDetails()
    {
        Console.WriteLine($"Guest: {GuestName}");
        Console.WriteLine($"Room Type: {RoomType}");
        Console.WriteLine($"Nights: {Nights}");
    }
}

class Program4
{
    public static void Main()
    {
        // Creating a booking using the default constructor
        HotelBooking booking1 = new HotelBooking();
        booking1.DisplayBookingDetails();

        Console.WriteLine();

        // Creating a booking using the parameterized constructor
        HotelBooking booking2 = new HotelBooking("Rahul", "Deluxe", 3);
        booking2.DisplayBookingDetails();

        Console.WriteLine();

        // Creating a copy of booking2 using the copy constructor
        HotelBooking booking3 = new HotelBooking(booking2);
        booking3.DisplayBookingDetails();
    }
}
