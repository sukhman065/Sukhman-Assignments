function test()
{
    console.log("hello world");
}

function test2(num1,num2)
{
    return (num1+num2);
}


test();

let sum= test2(12,56);
console.log(sum);

//using arrow function
const testme=()=>console.log("hello world2");
let sum2=(n1,n2)=>(n1+n2);
testme();
console.log(sum2(1,6));

//variable.map(element)=>print(element)
var arr=[12,14,16,18,90];
arr.map((ele)=>console.log(ele));

//example 2
const numbers=[1,2,3,4,5,6];
const square= numbers.map(value => value*value);
console.log(square);

const people=[
    {id: 1,name:"sukh",country: "USA"},
    {id: 2,name:"suh",country: "india"},
    {id: 3,name:"sukhman",country: "japan"}
]
const ids=people.map( p => p.id);
console.log(ids);

//filter function 
//array.filter(ele=>(condition))

var filterered=numbers.filter(x => x>3);
console.log(filterered);