using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGestor.APIContracts.Snacks
{
    public class SnackBuyLineDto
    {
        public Guid TicketId { get; set; }
        public int Amount { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
    }
}
