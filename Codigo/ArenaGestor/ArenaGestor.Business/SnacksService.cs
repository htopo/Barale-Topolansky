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
    public class SnacksService : ISnacksService
    {
        private readonly ISnacksManagement snacksManagement;

        public SnacksService(ISnacksManagement snacksManagement)
        {
            this.snacksManagement = snacksManagement;
        }

        public Snack InsertSnack(Snack snack)
        {
            snacksManagement.InsertSnack(snack);
            snacksManagement.Save();
            return snack;
        }

        public void DeleteSnack(string snackName)
        {
            snacksManagement.DeleteSnack(snackName);
            snacksManagement.Save();
        }

        public List<Snack> GetAllSnacks()
        {
            return snacksManagement.GetAllSnacks();
        }
    }
}
