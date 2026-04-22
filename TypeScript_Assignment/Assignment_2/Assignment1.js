"use strict";
class Vehicle {
    brand;
    speed;
    constructor(brand, speed) {
        this.brand = brand;
        this.speed = speed;
    }
    Move() {
        console.log("Vehicle is moving");
    }
}
class Car extends Vehicle {
    fuelType;
    constructor(brand, speed, fuel) {
        super(brand, speed);
        this.fuelType = fuel;
    }
    Move() {
        console.log(`Car is moving at ${this.speed} km/h`);
    }
}
class Bike extends Vehicle {
    hasGear;
    constructor(brand, speed, hasGear) {
        super(brand, speed);
        this.hasGear = hasGear;
    }
    Move() {
        console.log(`Bike is moving at ${this.speed} km/h`);
    }
}
const car = new Car("Toyota", 80, "Petrol");
const bike = new Bike("Yamaha", 60, true);
car.Move();
bike.Move();
console.log("Car Brand: ", car.brand);
console.log("Bike Brand: ", bike.brand);
