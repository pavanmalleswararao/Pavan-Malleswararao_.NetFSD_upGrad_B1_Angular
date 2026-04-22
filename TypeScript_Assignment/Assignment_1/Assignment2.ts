interface IShape{
    AreaofRectangle(length:number,width:number):number;
    AreaofTriangle(width:number,height:number):number;
    AreaofCircle(radius:number):number;
    AreaofSquare(side:number):number;
}

class Shape implements Shape{
    AreaofRectangle(length:number,width:number):number{
        return length*width;
    }
    AreaofTriangle(width:number,height:number):number{
        return 0.5*width*height;
    }
    AreaofCircle(radius:number):number{
        return Math.PI*radius*radius;
    }
    AreaofSquare(side:number):number{
        return side*side;
    }
}

const shape=new Shape();
console.log("Rectangle: ",shape.AreaofRectangle(10,5));
console.log("Triangle: ",shape.AreaofRectangle(10,5));
console.log("Circle: ",shape.AreaofCircle(7));
console.log("Square: ",shape.AreaofSquare(4));