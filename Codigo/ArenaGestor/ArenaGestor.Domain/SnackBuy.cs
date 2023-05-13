using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGestor.Domain
{
    public class SnackBuy
    {
        [Required]
        public Guid TicketId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Quantity { get; set; }
    }
}
