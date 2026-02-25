class Vehicle{
    constructor(brand,speed){
        this.brand=brand;
        this.speed=speed;
    }
    start(){
        console.log(`Brand: ${this.brand} Speed:${this.speed}`);
    }
}

class Car extends Vehicle{
    constructor(brand,speed,fueltype){
        super(brand,speed)
        this.fueltype=fueltype;
    }
    showDetails(){
        this.start();
        console.log(`FuelType: ${this.fueltype}`)
    }
}

let car=new Car('Audi',110,'Petrol');
car.showDetails();