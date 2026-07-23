using Assignment5.Interface;
using Assignment5.Models;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            // a. Create a Cinema and open it
            Cinema cinema = new Cinema("Cinema City");
            cinema.OpenCinema();

            // b. Create one of each ticket type, book them, and add to Cinema
            StandardTicket t1 = new StandardTicket("Inception", 80m, "A5");
            VIPTicket t2 = new VIPTicket("Avengers", 200m, true);
            IMAXTicket t3 = new IMAXTicket("Dune", 100m, true); // 100 + 30 (3D fee) = 130

            t1.Book();
            t2.Book();
            t3.Book();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            // c. Print all tickets through the Cinema
            cinema.PrintAllTickets();

            // d. Clone a VIP ticket, change clone's movie name, and prove independence
            Console.WriteLine("\n--- Clone Test ---");
            VIPTicket t2Clone = (VIPTicket)t2.Clone();
            t2Clone.MovieName = "Interstellar"; // Modifying clone does not affect original

            Console.WriteLine($"Original : {t2}");
            Console.WriteLine($"Clone    : {t2Clone}");

            // e. Cancel one ticket and reprint to show updated status
            Console.WriteLine("\n--- After Cancellation ---");
            t1.Cancel();
            t1.Print();

            // f. Use the utility method to print an array of printable tickets
            IPrintable[] allPrintables = { t1, t2, t3 };
            BookingHelper.PrintAll(allPrintables);

            // g. Close the Cinema
            cinema.CloseCinema();
        }
    }
}