export class Product {
  constructor(
    public id?: number,
    public firstname?: string,
    public lastname?: string,
    public address?: string,
    public city?: string,
    public orders?: Orders[]

  ) { }


}
export class Orders {
  constructor(
    public product1?: string,
    public price?:number,
    public quantity?: number,
   
    public ordertotal?: number
   
  ) { }
}


