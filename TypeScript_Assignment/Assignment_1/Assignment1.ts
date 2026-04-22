class Book{
    isbn:string;
    bookName:string;
    bookTitle:string;
    bookAuthor:string;
    quantity:number;
    price:number;
    
    constructor(isbn:string,name:string,title:string,author:string,qty:number,price:number){
        this.isbn=isbn;
        this.bookName=name;
        this.bookTitle=title;
        this.bookAuthor=author;
        this.quantity=qty;
        this.price=price;
    }

    CalculateBill():number{
        return this.quantity*this.price;
    }

    displayDetails():void{
        console.log("ISBN: ",this.isbn);
        console.log("Book Name: ",this.bookName);
        console.log("Title: ",this.bookTitle);
        console.log("Author: ",this.bookAuthor);
        console.log("Quality: ",this.quantity);
        console.log("Price: ",this.price);
        console.log("Total Bill: ",this.CalculateBill());
    }
}

const book1=new Book('101','DotNet','Asp.Net','Microsoft',2,500);
book1.displayDetails();