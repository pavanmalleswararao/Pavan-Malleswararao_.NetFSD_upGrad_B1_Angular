let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];

let totalCartValue=cart.reduce((sum,item)=>sum+item.price*item.qty,0);
console.log(totalCartValue);

let incresedQuantity=cart.map(item=> item.id===2?{...item,qty:item.qty+1}:item);
console.log(incresedQuantity);

let removedCart=cart.filter(item=>item.id!==3);
console.log(removedCart);

let discountedCart=cart.map(item=>item.price>10000?{...item,price:item.price*0.9}:item);
console.log(discountedCart);

let sortedCart=[...cart].sort((a,b)=>(a.price*a.qty)-(b.price*b.qty));
console.log(sortedCart);

let hasLuxuryItem=cart.some(item=>item.price>50000);
console.log(hasLuxuryItem);

let allInStock=cart.every(item=>item.qty>0);
console.log("All items in stock?",allInStock);

let invoice=cart.map(
    item=>`${item.product} x${item.qty} = ₹${item.price*item.qty}`).join("\n");
console.log(invoice);

let expensiveItem=cart.reduce((max,item)=>item.price>max.price?item:max);
console.log(expensiveItem);

let gst=totalCartValue*0.18;
let finalAmount=totalCartValue+gst;
console.log("GST: ₹",gst);
console.log("Final Amount: ₹",finalAmount);