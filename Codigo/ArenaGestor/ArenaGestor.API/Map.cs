using ArenaGestor.APIContracts.Snacks;
using ArenaGestor.APIContracts.Ticket;
using ArenaGestor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArenaGestor.API
{
    public class Map
    {
        public TicketBuy dtoToTicketBuy(TicketBuyTicketDto dto)
        {
            return new TicketBuy()
            {
                ConcertId = dto.ConcertId,
                Amount = dto.Amount,
            };
        }

        public SnackBuy dtoToSnackBuy(SnackBuyDto dto)
        {
            return new SnackBuy()
            {
                TicketId = new Guid(),
                Name = dto.Name,
                Amount = dto.Amount,
                Quantity = dto.Quantity,
            };
        }

        public List<SnackBuy> dtoToSnacksBuy(TicketBuyTicketDto dto)
        {
            var list = new List<SnackBuy>();
            if (dto.SnackBuys != null)
            {
                foreach (var snackbuy in dto.SnackBuys)
                {
                    list.Add(dtoToSnackBuy(snackbuy));
                }
            }
            return list;
        }

        public List<SnackBuyLineDto> snackBuyToDto(List<SnackBuy> snackBuys)
        {
            var list = new List<SnackBuyLineDto>();
            if (snackBuys != null)
            {
                foreach (var snackbuy in snackBuys)
                {
                    SnackBuyLineDto dto = new SnackBuyLineDto()
                    {
                        TicketId = snackbuy.TicketId,
                        Amount = snackbuy.Amount,
                        Name = snackbuy.Name,
                        Quantity = snackbuy.Quantity,
                    };
                    list.Add(dto);
                }
            }
            return list;
        }
    }
}
