import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Usluga } from '../../models/usluga';
import { ActivatedRoute, Router } from '@angular/router';
import { ListaService } from '../lista.service';

@Component({
  selector: 'app-osoby-filter',
  imports: [CommonModule, ActivatedRoute, Router],
  templateUrl: './osoby-filter.component.html',
  styleUrl: './osoby-filter.component.css'
})
export class OsobyFilterComponent{
 osoby: Usluga[] = [];
  filterTerm: string = '';
  loading: boolean = false;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private osobyService: ListaService
  ) {}

  // ngOnInit(): void {
  //   this.route.params.subscribe(params => {
  //     this.filterTerm = params['filter'] || '';
  //     this.loadFilteredData();
  //   });
  // }

  // loadFilteredData(): void {
  //   this.loading = true;
    
  //   if (this.filterTerm) {
  //     this.osobyService.getByImie(this.filterTerm).subscribe({
  //       next: (data) => {
  //         this.osoby = data;
  //         this.loading = false;
  //       },
  //       error: (error) => {
  //         console.error('Błąd podczas filtrowania:', error);
  //         this.loading = false;
  //       }
  //     });
  //   } else {
  //     this.showAll();
  //   }
  // }

  showAll(): void {
    this.loading = true;
    this.osobyService.get().subscribe({
      next: (data) => {
        this.osoby = data;
        this.loading = false;
        this.filterTerm = '';
      },
      error: (error) => {
        console.error('Błąd podczas ładowania danych:', error);
        this.loading = false;
      }
    });
  }

  clearFilter(): void {
    this.router.navigate(['/osoby/filtr']);
  }
}
