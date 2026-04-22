"use strict";
class CreditCardPayment {
    amount;
    constructor(amount) {
        this.amount = amount;
    }
    Pay() {
        console.log(`paid ${this.amount} using Credit Card`);
    }
    Refund() {
        console.log("Refund intiated to Credit Card");
    }
}
class UPIPayment {
    amount;
    constructor(amount) {
        this.amount = amount;
    }
    Pay() {
        console.log(`Paid ${this.amount} using UPI`);
    }
}
const credit = new CreditCardPayment(1000);
credit.Pay();
credit.Refund();
const upi = new UPIPayment(500);
upi.Pay();
