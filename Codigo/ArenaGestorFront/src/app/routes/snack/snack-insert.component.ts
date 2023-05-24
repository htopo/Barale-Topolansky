import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { SnackInsertSnackDto } from 'src/app/models/Snacks/SnackInsertSnackDto';
import { SnacksService } from 'src/app/services/snack.service';

@Component({
  templateUrl: './snack-insert.component.html'
})
export class SnackInsertComponent implements OnInit {

  mode: String = "Insertar";
  model: SnackInsertSnackDto = new SnackInsertSnackDto();
  snackName: string = "";
  snackPrice: string = "";

  constructor(private service: SnacksService, private toastr: ToastrService, private router: Router) { }

  ngOnInit(): void {
  }

  Confirmar() {
    if(this.snackName == "" || this.snackPrice == "") {
      this.toastr.error("Hay datos sin completar", "Error")
      return;
    }
    if(isNaN(parseInt(this.snackPrice))) {
      this.toastr.error("El precio debe ser un valor numérico", "Error")
      return;
    }
    this.model.name = this.snackName;
    this.model.price = parseInt(this.snackPrice);
    this.service.Insert(this.model).subscribe(res => {
      this.toastr.success("Snack agregado correctamente", "Éxito")
      this.router.navigate(["/administracion/snacks"])
    },
      err => {
        this.toastr.error(err.error, "Error")
      })
  }

}
