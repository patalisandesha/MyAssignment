import { Component } from "@angular/core";
import { ProductRepository } from "../model/product.repository";
import { Product,Orders } from "../model/product.model";
import { StaticDataSource } from "../model/static.data";

@Component({

  selector: "customer",
  templateUrl: "customer.html"
})
export class CustomerComponent {
  public lines: Product[] = [];

  constructor(private repository: ProductRepository) { }

  get products(): Product[] {
    return this.repository.getProducts();
    
  }
 
  
  Add(id,first, last, city,adress) {
    console.log(first);
    console.log(last); console.log(city);
    this.products.push(new Product(id,first, last, city,adress));
  }

  remove(product: Product) { 
    let index = this.products.indexOf(product);
    //if (index !== -1) {

      this.products.splice(index,1);
    

  }



  //remove(id) {
    //  //const index: number = this.products.indexOf(id);
    //  //console.log(index);
    //  //if (index == -1) {
    //  //  this.products.splice(index);
    //  this.products.splice(this.products.indexOf(id), 1);
    //}
    //for (let i = this.products.length - 1; i >= 0; i--) {
    //  if (this.products[i] === id) {
    //    this.products.splice(i, 1);
    //  }
    //}
  }


