class BankAccount{
    depositorName:string;
    accountNumber:number;
    accountType:string;
    balance:number;

    constructor(name:string,accNO:number,accType:string,balance:number){
        this.depositorName=name;
        this.accountNumber=accNO;
        this.accountType=accType;
        this.balance=balance;
    }

    deposite(amount:number):void{
        this.balance+=amount;
        console.log("Deposited: ",amount);
    }

    Withdraw(amount:number):void{
        if(amount>this.balance){
            console.log("In sufficient balance");
        }
        else{
            this.balance-=amount;
            console.log("Withdraw: ",amount);
        }
    }

    Display():void{
        console.log("Name: ",this.depositorName);
        console.log("Balance: ",this.balance);
    }
}

let bank=new BankAccount("Pavan",12345,"Savings",1000);

bank.deposite(500);
bank.Withdraw(300);
bank.Display();