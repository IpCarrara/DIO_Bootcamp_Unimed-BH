import {Injectable} from "@angular/core";
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {book} from "./model/book";


export const books: book[] = [
    {type: 'codigo1', value: {image: "string", isbn13: "string",price: "string",subtitle: "string",title: "string",url: "string"}},
    {type: 'codigo2', value: {image: "string", isbn13: "string",price: "string",subtitle: "string",title: "string",url: "string"}},
    {type: 'codigo3', value: {image: "string", isbn13: "string",price: "string",subtitle: "string",title: "string",url: "string"}},
  ];

@Injectable()


export class BooksService {

  // Troquei a API por uma mais completa. 
  // Docs em https://api.itbook.store/

  private url = 'https://api.itbook.store/1.0/new'

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
    
   constructor( private http: HttpClient){}


    getBooks() {
      return this.http.get(this.url)
    }
}