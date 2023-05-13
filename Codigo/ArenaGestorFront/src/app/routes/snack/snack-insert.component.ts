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

  constructor(private service: SnacksService, private toastr: ToastrService, private router: Router) { }

  ngOnInit(): void {
  }

  Confirmar() {
    this.service.Insert(this.model).subscribe(res => {
      this.toastr.success("Snack agregado correctamente", "Éxito")
      this.router.navigate(["/administracion/snacks"])
    },
      err => {
        this.toastr.error(err.error, "Error")
      })
  }

}
