let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];

let uniqueNumbers=[...new Set(numbers)];
console.log(uniqueNumbers);

let sortedUnique=[...new Set(numbers)].sort((a,b)=>b-a);
let secondLargest=sortedUnique[1];
console.log(secondLargest);

let frequency=numbers.reduce((count,num)=>{
    count[num]=(count[num]||0)+1;
    return count;
},{});
console.log(frequency);

let firstUnique=numbers.find(num=>frequency[num]===1);
console.log(firstUnique);

let k=2;
let rotated=numbers.slice(-k).concat(numbers.slice(0,-k));
console.log(rotated);

let nested=[1,2,[3,4[5]]];
let flattend=nested.flat(2);
console.log(flattend);

let arr=[1,2,3,4,5,6];
let n=arr.length+1;
let expectedSum=(n*(n+1))/2;
let actualSum=arr.reduce((sum,num)=>sum+num,0);
let missing=expectedSum-actualSum;
console.log(missing);