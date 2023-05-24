using ArenaGestor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGestor.DataAccessInterface
{
    public interface ISnacksManagement
    {
        void InsertSnack(Snack snack);
        void DeleteSnack(string snackName);
        List<Snack> GetAllSnacks();
        Snack GetSnackByName(string snackName);
        void Save();
    }
}
