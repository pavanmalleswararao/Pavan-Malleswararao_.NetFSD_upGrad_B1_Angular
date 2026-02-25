class BankAccount{
    #bal=0;
    constructor(accountHolder,balance){
        this.Name=accountHolder;
        this.#bal=balance
        console.log('Welcome : '+this.Name);
    }
    deposit(amount){
        this.#bal+=amount;
        console.log('Deposited: '+amount);
    }
    withdraw(amount){
        if (amount<=this.#bal){
            this.#bal-=amount;
            console.log('Transcation successful: '+amount);
        }
        else{
            console.log('Insuffeicent balance');
        }
    }
    checkBalance(){
        console.log("Balanca: "+this.#bal);
    }
}

const bankAccount=new BankAccount("Rahul",10000);
bankAccount.deposit(2000);
bankAccount.withdraw(5000);
bankAccount.checkBalance();