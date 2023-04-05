using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Test
{
    [TestFixture]
    public class TicketServiceIntegrationTests
    {
        [Test]
        public void SaveTicketMustAddTicketInBase()
        {
            var ticketServiceTest = new TicketService();
            var newTicket = new Ticket(300, "Test ticket", 3000); //создаем новый билет

            ticketServiceTest.SaveTicket(newTicket); // добавляем созданный билет

            var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets(); //получаем все билеты после добавления
            CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket); //проверяем что добавленный билет содержится в списке

            ticketServiceTest.DeleteTicket(newTicket); // удалем билет

            var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets(); //получаем все билеты после удаления
            CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket); //проверяем что удаленный билет не содержится в списке
        }
    }
}
