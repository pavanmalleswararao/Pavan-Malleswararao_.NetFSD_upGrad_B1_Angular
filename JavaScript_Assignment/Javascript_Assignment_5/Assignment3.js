class Student{
    constructor(name,...marks){
        this.name=name;
        this.marks=marks;
    }
    addMark(mark){
        this.marks.push(mark);
        console.log("Mark added:", mark);
    }
    getAverage(){
        let average=this.marks.reduce((sum, m) => sum + m, 0) / this.marks.length;
        console.log("Average:", average);
    }
    getGrade(){
        console.log("Grades:")
        for(let mark of this.marks){
            if(mark>=90) console.log('Grade A');
            else if(mark>=75) console.log('Grade B');
            else if(mark>=50) console.log('Grade C');
            else console.log("Fail")
        }
    }
}

let student=new Student("Rohit",87,90,56,79);
student.addMark(50);
student.getAverage();
student.getGrade();