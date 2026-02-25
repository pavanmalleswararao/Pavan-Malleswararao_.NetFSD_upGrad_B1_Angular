class Product{
    constructor({name,price,category='General'}){
        this.name=name;
        this.price=price;
        this.category=category;
    }

    showDetails=()=>{
        console.log(`Name: ${this.name}| Price: ${this.price}| Category: ${this.category}`);
    }

    updateProduct=(newData)=>{
        ({...this, ...newData});
        console.log("Update Product: ",newData);
    }
    applyDiscount=(percentage=10)=>{
        this.price-=this.price*(percentage/100);
        console.log(`After ${percentage}% discount -> ₹${this.price}`);
    }
}

const product=new Product({name:'laptop',price:60000});
product.showDetails();
product.applyDiscount();
product.applyDiscount(20);
product.updateProduct({name:'Moblie',price:20000,category:'Eletronics'});
product.showDetails();