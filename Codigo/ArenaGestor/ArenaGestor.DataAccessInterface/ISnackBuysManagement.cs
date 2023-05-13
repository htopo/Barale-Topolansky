using ArenaGestor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGestor.DataAccessInterface
{
    public interface ISnackBuysManagement
    {
        void InsertSnackBuy(SnackBuy snackbuy);
        void Save();
    }
}
