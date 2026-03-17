using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling_Assignment
{
    class TicketException : Exception
    {
        public TicketException(string message):base(message) { }
    }
    class MovieTicket
    {
        public static int availableTickets = 15;
        public void BookTickets(int tickets)
        {
            if (tickets > availableTickets)
            {
                throw new TicketException("Tickets not Available! Booking Exceeds Limit");
            }
            else
            {
                availableTickets -= tickets;
                Console.WriteLine("Tickets booked Successfully");
                Console.WriteLine("Remaining Tickets: "+availableTickets);
            }
        }
    }
}
