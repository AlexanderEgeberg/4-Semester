var makeAdder = (x) => {
    return test = (y) => {
        return x + y;
    }
}

var add5 = makeAdder(5);
var add10 = makeAdder(10);
var addHello = makeAdder("Hello ");

console.log(add5(2));  // 7
console.log(add10(2)); // 12
console.log(addHello("Henrik")); // Hello Henrik
