"use strict";
class Shape {
    AreaofRectangle(length, width) {
        return length * width;
    }
    AreaofTriangle(width, height) {
        return 0.5 * width * height;
    }
    AreaofCircle(radius) {
        return Math.PI * radius * radius;
    }
    AreaofSquare(side) {
        return side * side;
    }
}
const shape = new Shape();
console.log("Rectangle: ", shape.AreaofRectangle(10, 5));
console.log("Triangle: ", shape.AreaofRectangle(10, 5));
console.log("Circle: ", shape.AreaofCircle(7));
console.log("Square: ", shape.AreaofSquare(4));
