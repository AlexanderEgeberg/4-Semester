function makeGreeting(language) {
    return function(firstname, lastname){
        if (language==='en'){console.log('Hello ' + firstname + ' ' + lastname)};
        if (language==='dk'){console.log('Hej ' + firstname + ' ' + lastname)};
        if (language==='es'){console.log('Hola ' + firstname + ' ' + lastname)}
    }
}

var greetEnglish = makeGreeting('en');
var greetDanish = makeGreeting('dk');
var greetSpanish = makeGreeting('es');

greetEnglish('John', 'Doe');
greetDanish('Henrik', 'Høltzer');
greetSpanish('Pablo', 'Fuentes');


var x = (language,firstname,lastname) => 
    (language==="en") ? console.log('Hello ' + firstname + ' ' + lastname): 
    (language==="dk") ? console.log('Hej ' + firstname + ' ' + lastname): 
    (language==="es") ? console.log('Hola ' + firstname + ' ' + lastname):
    console.log("Error");

//x("en","john", "Doe");
//x("dk","john", "Doe");
//x("es","john", "Doe");



var greetv3 = (language) => {
    return function(firstname, lastname){
    (language=="en") ? console.log('Hello ' + firstname + ' ' + lastname): 
    (language==="dk") ? console.log('Hej ' + firstname + ' ' + lastname): 
    (language==="es") ? console.log('Hola ' + firstname + ' ' + lastname):
    console.log("Error");
}};

greetv3("en")("not","sure");
var tonymontana = greetv3("es");
tonymontana('Tony','Montana');