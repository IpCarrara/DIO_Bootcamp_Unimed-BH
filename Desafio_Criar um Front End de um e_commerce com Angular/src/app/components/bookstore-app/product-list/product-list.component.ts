import { Component, OnInit } from '@angular/core';
import { BooksService, books } from './product-list.component.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  livros: any;
  booksService: BooksService;
  livrosMapped: any;

  constructor(  booksService: BooksService) {
    this.booksService = booksService;
   }

  ngOnInit(): void {
    this.livrosMapped = this.booksService.getBooks().subscribe((data => {
      this.livrosMapped = data;
      this.livros = Object.keys(this.livrosMapped.books).map(key => ({type: key, value: this.livrosMapped.books[key]}));
      console.log(this.livros);
    }))

  }

}
