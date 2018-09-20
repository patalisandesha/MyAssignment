 export class Model { //creating module
  user;
  items;

  constructor() {

    this.user = "Adam";
    this.items = [
      new TodoItem("Buy Flowers", false),
      new TodoItem("get shoes", false),
      new TodoItem("collect Tickets", true),
      new TodoItem("call joe", false)]

    
  }
}
export class TodoItem { //we are exporting the es6 entities.

  action;
  done;

  constructor(action, done) {

    this.action = action;
    this.done = done;

  }
}
