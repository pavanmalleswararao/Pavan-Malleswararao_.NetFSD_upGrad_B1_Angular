let books = [
  { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
  { id: 2, title: "React Guide", price: 650, stock: 5 },
  { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
  { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];

let titles=books.map(book=>book.title);
console.log(titles);

let totalValue=books.reduce((sum,book)=>sum+book.price*book.stock,0);
console.log(totalValue);

let expensiveBooks=books.filter(book=>book.price>500);
console.log(expensiveBooks);

let incresedPrize=books.map(book=>({
    ...book,
    price: +(book.price*1.05).toFixed(2)
}));
console.log(incresedPrize);

let sortedBooks=[...books].sort((a,b)=>a.price -b.price);
console.log(sortedBooks);

let removedId=2;
let remainingBooks=books.filter(book=>book.id!==removedId);
console.log(remainingBooks);

let hasOutOfStock=books.some(book=>book.stock===0);
console.log("Any out of stock?",hasOutOfStock);

let groupedBooks=books.reduce((group,book)=>{
    if(book.price<400) group.low.push(book);
    else if(book<=600) group.medium.push(book);
    else group.high.push(book);
    return group;
}, {low:[],medium:[],high:[]});
console.log(groupedBooks);

let discountedBooks=books.map(book=>book.price>600?{...book,price:book.price*0.9}:book);
console.log(discountedBooks);

let invoice=books.map(book=>`${book.title} - ${book.price}`).join(" | ");
console.log(invoice);