interface Payment{
    amount:number;
    Pay():void;
}

interface Refundable{
    Refund():void
}

class CreditCardPayment implements Payment,Refundable{
    amount: number;

    constructor(amount:number){
        this.amount=amount;
    }

    Pay(): void {
        console.log(`paid ${this.amount} using Credit Card`);
    }

    Refund(): void {
        console.log("Refund intiated to Credit Card");
    }
}

class UPIPayment implements Payment{
    amount: number;

    constructor(amount:number) {
        this.amount=amount;
    }

    Pay(): void {
        console.log(`Paid ${this.amount} using UPI`);
    }
}

const credit=new CreditCardPayment(1000);
credit.Pay();
credit.Refund();

const upi=new UPIPayment(500);
upi.Pay();