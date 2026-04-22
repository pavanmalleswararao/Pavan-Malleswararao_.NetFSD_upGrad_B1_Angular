"use strict";
class Student {
    rollno;
    studentName;
    markInEng;
    markInMath;
    markInScience;
    constructor(rollNo, name, eng, math, science) {
        this.rollno = rollNo;
        this.studentName = name;
        this.markInEng = eng;
        this.markInMath = math;
        this.markInScience = science;
    }
    Total() {
        return this.markInEng + this.markInMath + this.markInScience;
    }
    Percentage() {
        return this.Total() / 3;
    }
    Display() {
        console.log("RollNo: ", this.rollno);
        console.log("Student Name: ", this.studentName);
        console.log("Total: ", this.Total());
        console.log("Percentage: ", this.Percentage());
    }
}
const stu = new Student(1, "Pavan", 93, 92, 95);
stu.Display();
