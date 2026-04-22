class Vehicle{
    brand:string;
    speed:number;
    
    constructor(brand:string,speed:number){
        this.brand=brand;
        this.speed=speed;
    }

    Move():void{
        console.log("Vehicle is moving");
    }
}

class Car extends Vehicle{
    fuelType:string;
    
    constructor(brand:string,speed:number,fuel:string) {
        super(brand,speed);
        this.fuelType=fuel;
    }
    
    Move(): void {
        console.log(`Car is moving at ${this.speed} km/h`);
    }
}

class Bike extends Vehicle{
    hasGear:boolean;

    constructor(brand:string,speed:number,hasGear:boolean){
        super(brand,speed);
        this.hasGear=hasGear;
    }

    Move(): void {
        console.log(`Bike is moving at ${this.speed} km/h`);
    }
}

const car=new Car("Toyota",80,"Petrol");
const bike=new Bike("Yamaha",60,true);

car.Move();
bike.Move();

console.log("Car Brand: ",car.brand);
console.log("Bike Brand: ",bike.brand);