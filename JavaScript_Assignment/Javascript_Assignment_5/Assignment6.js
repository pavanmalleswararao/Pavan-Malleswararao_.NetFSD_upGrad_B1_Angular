class Shape{
    calculateArea(){
        return 0;
    }
}

class Circle extends Shape{
    constructor(radius){
        super()
        this.radius=radius
    }
    calculateArea(){
        return Math.PI*this.radius**2;
    }
}

class Rectangle extends Shape{
    constructor(length,width){
        super()
        this.length=length;
        this.width=width;
    }
    calculateArea(){
        return this.length*this.width;
    }
}

class Triangle extends Shape{
    constructor(hight,width){
        super()
        this.hight=hight;
        this.width=width;
    }
    calculateArea(){
        return 0.5*this.hight*this.width;
    }
}

const shapes=[new Circle(3), new Rectangle(4,5), new Triangle(6,7)];
shapes.forEach(shape=> console.log(shape.calculateArea()));