import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { SnackResultSnackDto } from 'src/app/models/Snacks/SnackResultSnackDto';
import { TicketBuyTicketDto } from 'src/app/models/Tickets/TicketBuyTicketDto';
import { ConcertService } from 'src/app/services/concert.service';
import { TicketsService } from 'src/app/services/tickets.service';
import { SnacksService } from 'src/app/services/snack.service';
import { SnackBuyDto } from 'src/app/models/Snacks/SnackBuyDto';

@Component({
  selector: 'app-buy',
  templateUrl: './buy.component.html'
})
export class BuyComponent implements OnInit {

  selectedTourName: String = "";
  selectedId: Number = 0;
  amount : Number = 0;
  snackList: Array<SnackResultSnackDto> = new Array();
  selectedSnack: string = '';
  snackAmount : number = 0;
  buyedSnacks: Array<SnackBuyDto> = new Array();
  totalAmount: number = 0;

  constructor(private snackService: SnacksService,private toastr: ToastrService, private ticketService: TicketsService, private service: ConcertService, private router: Router, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.snackService.Get().subscribe(res => { this.snackList = res })
    this.activatedRoute.params.subscribe(params => {
      this.service.GetById(params["id"]).subscribe(concert => { 
        this.selectedTourName = concert.tourName
        this.selectedId = concert.concertId
      })
    })
  }

  Confirmar() {
    let dto = new TicketBuyTicketDto()
    dto.Amount = this.amount
    dto.concertId = this.selectedId
    dto.snackBuys = this.buyedSnacks
    this.ticketService.Shopping(dto).subscribe(res => {
      this.toastr.success("Ticket comprado con ID: " + res.ticketId)
    }, error => {
      this.toastr.error(error.error)
    })
  }

  AgregarSnack() {
    if (this.selectedSnack == '') {
      this.toastr.error("Debe seleccionar un snack")
      return
    }
    if (this.snackAmount == 0) {
      this.toastr.error("Debe seleccionar una cantidad")
      return
    }
    if (this.buyedSnacks.find(x => x.name == this.selectedSnack) != undefined) {
      var snack = this.buyedSnacks.find(x => x.name == this.selectedSnack)
      let price = this.snackList.find(x => x.name == this.selectedSnack)?.price ?? 0
      snack!.quantity += this.snackAmount
      this.totalAmount += price * this.snackAmount;
    }
    else {
      let snack = new SnackBuyDto();
      snack.name = this.selectedSnack;
      snack.quantity = this.snackAmount;
      let price = this.snackList.find(x => x.name == this.selectedSnack)?.price ?? 0
      snack.amount = price * this.snackAmount;
      this.totalAmount += snack.amount;
      this.buyedSnacks.push(snack);
    }
  }

}
