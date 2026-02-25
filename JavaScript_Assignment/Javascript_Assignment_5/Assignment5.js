class Employee{
    constructor(name,salary){
        this.name=name;
        this.salary=salary;
    }
    getDetails(){
        console.log(`Name: ${this.name}`);
        console.log(`Salary: ₹${this.salary}`)
    }
}

class Manager extends Employee{
    constructor(name,salary,bonus){
        super(name,salary);
        this.bonus=bonus;
    }
    getTotalSalary(){
        let TotalSalary=this.bonus+this.salary;
        console.log("Total Salary: ₹"+TotalSalary);
    }
}

class Director extends Manager{
    constructor(name,salary,bonus,stockOptions){
        super(name,salary,bonus);
        this.stockOptions=stockOptions;
    }
    getFullCompensation(){
        let fullComp = this.salary + this.bonus + this.stockOptions;
        console.log(`Full Compensation: ₹${fullComp}`);
    }
}

let director=new Director("Pavan",50000,20000,50000);
director.getDetails();
director.getTotalSalary();
director.getFullCompensation()