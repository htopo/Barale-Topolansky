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
            if (snack.Name == "" || snack.Price == 0)
            {
                throw new ArgumentException("Hay campos sin completar");
            }
            if (snacksManagement.GetSnackByName(snack.Name) != null)
            {
                throw new ArgumentException("It already exists a snack with that name");
            }
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
