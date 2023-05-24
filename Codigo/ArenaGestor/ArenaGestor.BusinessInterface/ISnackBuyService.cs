using ArenaGestor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGestor.BusinessInterface
{
    public interface ISnackBuyService
    {
        void InsertSnackBuy(SnackBuy snackbuy);
        List<SnackBuy> GetSnackLinesByTicketId(Guid ticketId);
    }
}
