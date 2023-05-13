import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { SnackInsertSnackDto } from '../models/Snacks/SnackInsertSnackDto';
import { SnackResultSnackDto } from '../models/Snacks/SnackResultSnackDto';

@Injectable({
  providedIn: 'root'
})
export class SnacksService {

  private apiUrl: string

  constructor(private http: HttpClient) {
    this.apiUrl = environment.apiURL + "snacks"
  }

  Insert(snack: SnackInsertSnackDto): Observable<SnackResultSnackDto> {
    return this.http.post<SnackResultSnackDto>(this.apiUrl, snack)
  }

  Get(): Observable<Array<SnackResultSnackDto>> {
    return this.http.get<Array<SnackResultSnackDto>>(this.apiUrl)
  }

  Delete(snackName: string) {
    return this.http.delete(this.apiUrl + "/" + snackName)
  }

}