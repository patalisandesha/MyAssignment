 // this is component and its work is to tske the values from the value and connect to the view
import { Component } from "@angular/core"; //code in the model.ts bought here. loading
import { Model, TodoItem} from "./model"; //import is the command used to load into the browzer memory
@Component({  //it is typer script annotation. it lets we creat component. {} it is to creat local variables. 
  selector: "todo-app",  //selector property it is the means of reprecenting the component in the dom
  templateUrl: "app.component.html"  //both are properties and are instance of the component
   // directives and the pipes are written in th app.component.html
  //we can write new component in this bt using template: <c1-a> here c1-a is the child component. and the c1-a is the child component
})
export class AppComponent {  //it is the component and we are registring it in the app.modules

  model = new Model();
  checkBox = false;

  getName() { //it have the 2 power of watch and digest
    return this.model.user; //sharing the imformation  to the view
  }
  getTodoItems() {
    return this.model.items.filter(item => !item.done || this.checkBox  == true) ;//item is just an pointer we can use anything
  //=> it is for return
  //we are ading the filter here only to print only those are not done
  //this is used only becuase it will become the privilaged
  }
  addItem(newItem) {
    if (newItem != "") {
      this.model.items.push(new TodoItem(newItem, false));
    }
  }
  fun() {
    //if (e.target.checked) {
    return this.model.items.filter(item => !item.done);
    }
  }

























































//import { Component } from '@angular/core';

//@Component({
//  selector: 'app-root',
//  templateUrl: './app.component.html',
//  styleUrls: ['./app.component.css']
//})
//export class AppComponent {
//  title = 'todo';
//}
