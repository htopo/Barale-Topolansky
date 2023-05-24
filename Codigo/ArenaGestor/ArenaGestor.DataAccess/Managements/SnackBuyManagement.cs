using ArenaGestor.DataAccessInterface;
using ArenaGestor.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGestor.DataAccess.Managements
{
    public class SnackBuyManagement : ISnackBuysManagement
    {
        private readonly DbSet<SnackBuy> snackbuys;
        private readonly DbContext context;

        public SnackBuyManagement(DbContext context)
        {
            this.snackbuys = context.Set<SnackBuy>();
            this.context = context;
        }

        public void InsertSnackBuy(SnackBuy snackbuy)
        {
            snackbuys.Add(snackbuy);
        }

        public List<SnackBuy> GetSnackBuysByTicketId(Guid ticketId)
        {
            return snackbuys.Where(sb => sb.TicketId == ticketId).ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
