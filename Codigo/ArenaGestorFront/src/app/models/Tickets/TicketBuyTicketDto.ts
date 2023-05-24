import { SnackBuyDto } from "../Snacks/SnackBuyDto";

export class TicketBuyTicketDto {
    concertId: Number = 0;
    Amount: Number = 0;
    snackBuys: Array<SnackBuyDto> = new Array();
}