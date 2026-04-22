"use strict";
class BankAccount {
    depositorName;
    accountNumber;
    accountType;
    balance;
    constructor(name, accNO, accType, balance) {
        this.depositorName = name;
        this.accountNumber = accNO;
        this.accountType = accType;
        this.balance = balance;
    }
    deposite(amount) {
        this.balance += amount;
        console.log("Deposited: ", amount);
    }
    Withdraw(amount) {
        if (amount > this.balance) {
            console.log("In sufficient balance");
        }
        else {
            this.balance -= amount;
            console.log("Withdraw: ", amount);
        }
    }
    Display() {
        console.log("Name: ", this.depositorName);
        console.log("Balance: ", this.balance);
    }
}
let bank = new BankAccount("Pavan", 12345, "Savings", 1000);
bank.deposite(500);
bank.Withdraw(300);
bank.Display();
