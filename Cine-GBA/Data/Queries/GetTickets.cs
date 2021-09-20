using Cine_GBA.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cine_GBA.Data.Queries
{
    public class GetTickets
    {
        public List<Tickets> GetTicketsFuncion(int id)
        {
            using var context = new ApplicationDbContext();
            var Tickets = (from ticket in context.Tickets
                           where ticket.FuncionId == id
                           select ticket).ToList();
            return Tickets;
        }
    }
}
