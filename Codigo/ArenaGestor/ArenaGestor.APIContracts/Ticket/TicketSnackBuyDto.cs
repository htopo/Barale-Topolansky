using ArenaGestor.APIContracts.Snacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGestor.APIContracts.Ticket
{
    public class TicketSnackBuyDto
    {
        public List<TicketGetTicketResultDto> TicketDto { get; set; }
        public List<SnackBuyLineDto> SnacksDto { get; set; }
    }
}
