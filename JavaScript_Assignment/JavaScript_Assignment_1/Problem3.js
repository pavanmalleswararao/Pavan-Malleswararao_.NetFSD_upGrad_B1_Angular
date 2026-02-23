let purchaseAmount=4500;
let discount=0;
let discountAmount=0;
let finalAmout=0;

if(purchaseAmount>=5000){
    discount=0.20;
}else if(purchaseAmount>=3000){
    discount=0.10;
}
else{
    discount=0;
}

discountAmount=purchaseAmount*discount;
finalAmout=purchaseAmount-discountAmount;

console.log('Purchase Amount: ₹'+purchaseAmount);
console.log("Discount Applied: ₹"+discountAmount);
console.log('Final Payable Amount: ₹'+finalAmout);