using Assignment5.Interface;

namespace Assignment5.Models
{
    public static class BookingHelper
    {
        private static int _bookingCounter = 0;

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;
            return numberOfTickets >= 5 ? total * 0.9 : total;
        }

        public static decimal CalcGroupDiscount(int numberOfTickets, decimal pricePerTicket)
        {
            decimal total = numberOfTickets * pricePerTicket;
            return numberOfTickets >= 5 ? total * 0.9m : total;
        }

        public static string GenerateBookingReference()
        {
            return $"BK-{++_bookingCounter}";
        }

        // Utility method demonstrating interface polymorphism as a parameter
        public static void PrintAll(IPrintable[] items)
        {
            Console.WriteLine("\n--- BookingHelper.PrintAll ---");
            foreach (var item in items)
            {
                item.Print();
            }
        }
    }
}