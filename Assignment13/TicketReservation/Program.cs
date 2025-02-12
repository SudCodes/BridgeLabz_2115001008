using System;

class Ticket
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public int SeatNumber;
    public DateTime BookingTime;
    public Ticket Next;

    public Ticket(int ticketID, string customerName, string movieName, int seatNumber, DateTime bookingTime)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = bookingTime;
        Next = null;
    }
}

class TicketReservationSystem
{
    private Ticket head;
    private int ticketCount = 0;

    public void AddTicket(int ticketID, string customerName, string movieName, int seatNumber, DateTime bookingTime)
    {
        Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber, bookingTime);
        if (head == null)
        {
            head = newTicket;
            head.Next = head;
        }
        else
        {
            Ticket temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTicket;
            newTicket.Next = head;
        }
        ticketCount++;
    }

    public void RemoveTicket(int ticketID)
    {
        if (head == null) return;
        Ticket temp = head, prev = null;
        do
        {
            if (temp.TicketID == ticketID)
            {
                if (prev != null)
                    prev.Next = temp.Next;
                else
                {
                    Ticket last = head;
                    while (last.Next != head)
                    {
                        last = last.Next;
                    }
                    head = temp.Next;
                    last.Next = head;
                }
                ticketCount--;
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void DisplayTickets()
    {
        if (head == null) return;
        Ticket temp = head;
        do
        {
            Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
            temp = temp.Next;
        } while (temp != head);
    }

    public Ticket SearchTicket(string customerName, string movieName = null)
    {
        if (head == null) return null;
        Ticket temp = head;
        do
        {
            if (temp.CustomerName == customerName || (movieName != null && temp.MovieName == movieName))
                return temp;
            temp = temp.Next;
        } while (temp != head);
        return null;
    }

    public int GetTotalTickets()
    {
        return ticketCount;
    }
}

public class Program
{
    public static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();
        system.AddTicket(1, "Alice", "Inception", 5, DateTime.Now);
        system.AddTicket(2, "Bob", "Interstellar", 10, DateTime.Now);
        system.AddTicket(3, "Charlie", "Dune", 15, DateTime.Now);

        Console.WriteLine("Current Reservations:");
        system.DisplayTickets();

        Console.WriteLine("\nTotal Tickets: " + system.GetTotalTickets());

        Console.WriteLine("\nSearching for Bob's Ticket:");
        Ticket found = system.SearchTicket("Bob");
        if (found != null)
            Console.WriteLine($"Found Ticket - ID: {found.TicketID}, Movie: {found.MovieName}");

        Console.WriteLine("\nRemoving Alice's Ticket:");
        system.RemoveTicket(1);
        system.DisplayTickets();
    }
}
