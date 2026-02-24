let students = [
  { name: "Akhil", marks: 85 },
  { name: "Priya", marks: 72 },
  { name: "Ravi", marks: 90 },
  { name: "Meena", marks: 45 },
  { name: "Karan", marks: 30 }
];

let passed=students.filter(student=>student.marks>=40);
console.log(passed);

let distinction=students.filter(student=>student>=85);
console.log(distinction);

let average=students.reduce((sum,student)=>sum+student.marks,0)/students.length
console.log(average);

let topper=students.reduce((best,student)=>student.marks>best.marks?student:best);
console.log(topper);

let failedCount=students.filter(student=>student.marks<40).length
console.log("Failed Students:",failedCount);

let gradedStudents=students.map(student=>{
    let grade;

    if(student.marks>=85) grade='A';
    else if(student.marks>=60) grade="B";
    else if(student.marks>=40) grade="C";
    else grade="Fail";
    
    return {...student,grade};
});
console.log(gradedStudents);

let ranked=[...students].sort((a,b)=>b.marks-a.marks).map((student,index)=>({
    ...student,rank:index+1
}));
console.log(ranked)

let lowest=students.reduce((low,s)=>s.marks<low.marks?s:low);
let withoutLowest=students.filter(s=>s!==lowest);
console.log(withoutLowest);

let leaderboard=[...students].sort((a,b)=>b.marks-a.marks);
console.log(leaderboard);