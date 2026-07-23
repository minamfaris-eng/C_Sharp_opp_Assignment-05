using Assignment5.Models;

public class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movieName, decimal price, bool is3D)
        : base(movieName, is3D ? price + 30m : price)
    {
        Is3D = is3D;
    }

    public override string ToString() => $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}";
}
