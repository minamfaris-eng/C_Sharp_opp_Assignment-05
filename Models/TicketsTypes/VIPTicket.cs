using Assignment5.Models;

public class VIPTicket : Ticket
{
    public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; } = 50m;

    public VIPTicket(string movieName, decimal price, bool loungeAccess)
        : base(movieName, price)
    {
        LoungeAccess = loungeAccess;
    }

    public override string ToString() => $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}";
}