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
    public class SnacksManagement : ISnacksManagement
    {
        private readonly DbSet<Snack> snacks;
        private readonly DbContext context;

        public SnacksManagement(DbContext context)
        {
            this.snacks = context.Set<Snack>();
            this.context = context;
        }

        public void InsertSnack(Snack snack)
        {
            snacks.Add(snack);
        }

        public void DeleteSnack(string snackName)
        {
            var s = snacks.FirstOrDefault(s => s.Name == snackName);
            snacks.Remove(s);
        }

        public List<Snack> GetAllSnacks()
        {
            return snacks.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
