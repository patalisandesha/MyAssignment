import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from "@angular/forms"
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent //we are registring a component with a module.. Declaration section is register componets and directives
  ],
  imports: [ //these are to specify the helper module
    BrowserModule, FormsModule],
  //FormsMdoule is to do forms kind of thingd like UI
  //BrowserModule is used simce we are running the code in the browzer
  providers: [], //to register services
  bootstrap: [AppComponent]  //ng-component- loading the component in the dom
})
export class AppModule { }
