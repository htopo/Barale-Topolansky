using ArenaGestor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGestor.BusinessInterface
{
    public interface ISnacksService
    {
        Snack InsertSnack(Snack snack);
        void DeleteSnack(string snackName);
        List<Snack> GetAllSnacks();
    }
}
