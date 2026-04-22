class Student{
    rollno:number;
    studentName:string;
    markInEng:number;
    markInMath:number;
    markInScience:number;

    constructor(rollNo:number,name:string,eng:number,math:number,science:number){
        this.rollno=rollNo;
        this.studentName=name;
        this.markInEng=eng;
        this.markInMath=math;
        this.markInScience=science;
    }

    Total():number{
        return this.markInEng+this.markInMath+this.markInScience;
    }

    Percentage():number{
        return this.Total()/3;
    }

    Display():void{
        console.log("RollNo: ",this.rollno);
        console.log("Student Name: ",this.studentName);
        console.log("Total: ",this.Total());
        console.log("Percentage: ",this.Percentage());
    }
}

const stu=new Student(1,"Pavan",93,92,95);
stu.Display();