using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cine_GBA.Data.Models;

namespace Cine_GBA.Data.Command
{
    public class NewTicket
    {
        public void GenTicket(Tickets ticket) 
        {
            using (var context = new ApplicationDbContext()) 
            {
                context.Tickets.Add(ticket);
                context.SaveChanges();
            }
        }
    }
}
