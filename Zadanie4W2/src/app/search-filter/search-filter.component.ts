import { CommonModule } from '@angular/common';
import { Component, inject } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-search-filter',
  imports: [],
  templateUrl: './search-filter.component.html',
  styleUrl: './search-filter.component.css'
})
@Component({
  selector: 'app-search-filter',
  imports: [CommonModule],
  templateUrl: './search-filter.component.html',
  styleUrl: './search-filter.component.css'
})
export class SearchFilterComponent {


  private readonly activatedRoute = inject(ActivatedRoute);
  private readonly router = inject(Router);

 searchTerm: string = '';

  constructor() {}

  // onFilter(): void {
  // if (this.searchTerm?.trim()) {
  //   // Nawigacja do podstrony z filtrem
  //   this.router.navigate(['/filtr', this.searchTerm.trim()]);
  // }
  // }

}

