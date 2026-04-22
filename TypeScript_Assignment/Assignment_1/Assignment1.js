"use strict";
class Book {
    isbn;
    bookName;
    bookTitle;
    bookAuthor;
    quantity;
    price;
    constructor(isbn, name, title, author, qty, price) {
        this.isbn = isbn;
        this.bookName = name;
        this.bookTitle = title;
        this.bookAuthor = author;
        this.quantity = qty;
        this.price = price;
    }
    CalculateBill() {
        return this.quantity * this.price;
    }
    displayDetails() {
        console.log("ISBN: ", this.isbn);
        console.log("Book Name: ", this.bookName);
        console.log("Title: ", this.bookTitle);
        console.log("Author: ", this.bookAuthor);
        console.log("Quality: ", this.quantity);
        console.log("Price: ", this.price);
        console.log("Total Bill: ", this.CalculateBill());
    }
}
const book1 = new Book('101', 'DotNet', 'Asp.Net', 'Microsoft', 2, 500);
book1.displayDetails();
