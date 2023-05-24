using ArenaGestor.BusinessInterface;
using ArenaGestor.DataAccessInterface;
using ArenaGestor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGestor.Business
{
    public class SnackBuyService : ISnackBuyService
    {
        private readonly ISnackBuysManagement snacksBuyManagement;

        public SnackBuyService(ISnackBuysManagement snacksManagement)
        {
            this.snacksBuyManagement = snacksManagement;
        }

        public void InsertSnackBuy(SnackBuy snackbuy)
        {
            snacksBuyManagement.InsertSnackBuy(snackbuy);
            snacksBuyManagement.Save();
        }

        public List<SnackBuy> GetSnackLinesByTicketId(Guid ticketId)
        {
            return snacksBuyManagement.GetSnackBuysByTicketId(ticketId);
        }

    }
}
