using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTicketService.Test;

namespace UserTicketService
{
    public class TicketPrice
    {
        ITicketService ticketService;

        public TicketPrice(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        public int MakeTicketPrice(int ticketID) => ticketService.GetTicketPrice(ticketID);
    }
}
