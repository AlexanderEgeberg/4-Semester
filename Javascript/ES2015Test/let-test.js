//Example from: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/let

function varTest(){
    var x=1;
    if(true){
        var x=2;        //same global variable
        console.log(x); //2
    }
    console.log(x);     //2
}


function letTest(){
    let x=1;
    if(true){
        let x=2;        //new local variable
        console.log(x); //2
    }
    console.log(x);     //1
}