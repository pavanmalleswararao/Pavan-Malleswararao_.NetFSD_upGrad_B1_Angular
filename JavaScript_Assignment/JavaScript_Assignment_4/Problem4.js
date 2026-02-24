let employees = [
 { id:1, name:"Ravi", dept:"IT", salary:70000 },
 { id:2, name:"Anita", dept:"HR", salary:50000 },
 { id:3, name:"Karan", dept:"IT", salary:80000 },
 { id:4, name:"Meena", dept:"Finance", salary:60000 }
];

let totalSalary=employees.reduce((sum,emp)=>sum+emp.salary,0);
console.log(totalSalary);

let highestPaid=employees.reduce((max,emp)=>emp.salary>max.salary?emp:max);
let lowestPaid=employees.reduce((min,emp)=>emp.salary<min.salary?emp:min);
console.log("Highest Paid:",highestPaid);
console.log("Lowest Paid:",lowestPaid);

let updatedSalaries=employees.map(emp=>emp.dept==="IT"?{...emp,salary:emp.salary*1.15}:emp);
console.log(updatedSalaries);

let groupedByDept=employees.reduce((group,emp)=>{
    if(!group[emp.dept]){
        group[emp.dept]=[];
    }
    group[emp.dept].push(emp);
    return group;
},{});
console.log(groupedByDept);

let deptAverage=employees.reduce((acc,emp)=>{
    if(!acc[emp.dept]){
        acc[emp.dept]={total:0,count:0};
    }
    acc[emp.dept].total+=emp.salary;
    acc[emp.dept].count++;
    return acc;
},{});
for(let dept in deptAverage){
    deptAverage[dept]=deptAverage[dept].total/deptAverage[dept].count;
}
console.log(deptAverage);

let sortedEmployees=[...employees].sort((a,b)=>b.salary-a.salary);
console.log(sortedEmployees);

let afterTax=employees.map(emp=>({
    ...emp,salaryAfterTax:emp.salary*0.9
}));
console.log(afterTax);

let avgSalary=totalSalary/employees.length;
let aboveAverage=employees.filter(emp=>emp.salary>avgSalary);
console.log("Above Average:",aboveAverage);

let tableHtml=`
<table border=1>
<tr>
<th>ID</th><th>Name</th><th>Depatment</th><th>Salary</th>
</tr>
${employees.map(emp=>`
<tr>
<td>${emp.id}</td>
<td>${emp.name}</td>
<td>${emp.dept}</td>
<td>${emp.salary}</td>
</tr>
`).join("")}
</table>`;
console.log(tableHtml);