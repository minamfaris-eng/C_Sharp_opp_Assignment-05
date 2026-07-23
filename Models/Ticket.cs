using Assignment5.Interface;

namespace Assignment5.Models
{
    public class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int _ticketCounter = 0;
        private decimal _price;

        public string MovieName { get; set; }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value > 0) _price = value;
                else throw new ArgumentException("Price must be greater than 0.");
            }
        }

        // Protected setter allows the Clone method to assign a new ID
        public int TicketId { get; protected set; }
        public decimal PriceAfterTax => Price * 1.14m;
        public bool IsBooked { get; private set; }

        public Ticket(string movieName, decimal price)
        {
            TicketId = ++_ticketCounter;
            MovieName = movieName;
            Price = price;
        }

        public static int GetTotalTickets() => _ticketCounter;

        // IBookable Implementation
        public bool Book()
        {
            if (IsBooked) return false;
            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked) return false;
            IsBooked = false;
            return true;
        }

        // IPrintable Implementation
        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }

        // ICloneable Implementation (Deep Copy)
        public virtual object Clone()
        {
            var clone = (Ticket)this.MemberwiseClone();

            // Reset state for the new independent clone
            clone.TicketId = ++_ticketCounter;
            clone.IsBooked = false;

            return clone;
        }

        public override string ToString()
        {
            return $"[Ticket #{TicketId}] {MovieName} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}";
        }
    }
}