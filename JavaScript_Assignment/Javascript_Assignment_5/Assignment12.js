class Wallet{
    #balance;
    constructor(balance){
        this.#balance=balance;
    }
    
    addMoney(amount){
        this.#balance+=amount;
        console.log("Money Added: "+amount);
    }

    spendMoney(amount){
        this.#balance-=amount;
        console.log("Spended Money: "+amount);
    }

    getBalance(){
        console.log("Balance Money: "+this.#balance);
    }
}

const wallet=new Wallet(50000);
wallet.addMoney(5000);
wallet.spendMoney(2000);
wallet.getBalance();