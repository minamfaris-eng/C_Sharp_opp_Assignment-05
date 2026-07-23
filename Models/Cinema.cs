using Assignment5.Interface;
using Assignment5.Models;

public class Cinema
{
    // Using the interface type to store tickets
    private IPrintable[] _tickets = new IPrintable[20];
    private int _ticketCount = 0;
    private Projector _projector;
    public string CinemaName { get; set; }

    public Cinema(string cinemaName)
    {
        CinemaName = cinemaName;
        _projector = new Projector();
    }

    public bool AddTicket(IPrintable t)
    {
        if (_ticketCount < 20)
        {
            _tickets[_ticketCount++] = t;
            return true;
        }
        return false;
    }

    public void PrintAllTickets()
    {
        Console.WriteLine("\n--- All Tickets ---");
        for (int i = 0; i < _ticketCount; i++)
        {
            _tickets[i].Print();
        }
    }

    public void OpenCinema()
    {
        Console.WriteLine("=== Cinema Opened ===");
        _projector.Start();
    }

    public void CloseCinema()
    {
        Console.WriteLine("\n=== Cinema Closed ===");
        _projector.Stop();
    }
}