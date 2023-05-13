import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { SnackResultSnackDto } from 'src/app/models/Snacks/SnackResultSnackDto';
import { SnacksService } from 'src/app/services/snack.service';

@Component({
  templateUrl: './snack.component.html'
})
export class SnackComponent implements OnInit {

  snackList: Array<SnackResultSnackDto> = new Array();
  snackToDelete: string = "";

  constructor(private toastr: ToastrService, private service: SnacksService, private router: Router) { }

  ngOnInit(): void {
    this.GetData();
  }

  GetData() {
    this.service.Get().subscribe(res => {
      this.snackList = res;
    })
  }

  SetSnackToDelete(name: string) {
    this.snackToDelete = name;
  }

  Delete() {
    this.service.Delete(this.snackToDelete).subscribe(res => {
      this.toastr.success("Usuario eliminado correctamente", "Éxito")
      this.GetData();
    },
      err => {
        this.toastr.error(err.error, "Error")
      })
  }
}
