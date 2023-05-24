import { SnackBuyLineDto } from "../Snacks/SnackBuyLineDto";
import { TicketGetTicketResultDto } from "./TicketGetTicketResultDto";

export class TicketSnackBuyDto {
    ticketDto: Array<TicketGetTicketResultDto> = new Array(); 
    snacksDto: Array<SnackBuyLineDto> = new Array();
}