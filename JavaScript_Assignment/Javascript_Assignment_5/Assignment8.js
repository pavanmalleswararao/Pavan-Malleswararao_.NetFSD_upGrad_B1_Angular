class Payment{
    pay(amount){
        console.log("Payment processing of ₹"+amount)
    }
}

class CreditCardPayment extends Payment{
    pay(amount){
        console.log(`Paid ₹${amount} using Credit Card`);
    }
}

class UPIPayment extends Payment{
    pay(amount){
        console.log(`Paid ₹${amount} using UPI`);
    }
}

class CashPayment extends Payment{
    pay(amount){
        console.log(`Paid ₹${amount} using Cash`);
    }
}

let Payments=[new CreditCardPayment(), new UPIPayment(), new CashPayment()]
Payments.forEach(payment=>payment.pay(50000));