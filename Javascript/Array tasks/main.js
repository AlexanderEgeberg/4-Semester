
let names = ["Henrik", "JAMshid","AndERS","EBBe","pER","MicHAel","PETEr"];


names.forEach((name, index, array) => {
    if (name.toLocaleLowerCase() == "henrik".toLowerCase() || name.toLowerCase() == "per".toLowerCase()){
        var newName = name.toUpperCase();
        array[index] = newName;
    }
    else {
        var newName = name.toLowerCase();
        array[index] = newName;
    }
})

//console.log(names);

let cars = [
    {brand: 'VW', model: 'Passat', fuel: "diesel", owner_tax: 5550},
    {brand: 'VW', model: 'Passat', fuel: "gasoline", owner_tax: 460},
    {brand: 'VW', model: 'Passat', fuel: "hybrid", owner_tax: 150},
    {brand: 'BMW', model: '320i', fuel: "diesel", owner_tax: 4280},
    {brand: 'BMW', model: '320i', fuel: "gasoline", owner_tax: 430},
    {brand: 'BMW', model: '320i', fuel: "hybrid", owner_tax: 210},
    {brand: 'Tesla', model: 'S', fuel: "electric", owner_tax: 0},
]

var increaseOwnerTax = function(cars,fuel,taxPct){
    cars.forEach((value, index, array) => {
        if(value.fuel == fuel) {
            var new_tax = (array[index].owner_tax * (taxPct / 100)) + array[index].owner_tax;
            array[index].owner_tax = new_tax;
        }
    });
}

/* 
increaseOwnerTax(cars, 'diesel',50);
increaseOwnerTax(cars, 'hybrid',5);
 */
//console.log(cars);


var carModels = cars.map(x => x.model)
//console.log(carModels);


var carBrands = cars.map(x => ({ brand: x.brand}));  
//console.log(carBrands);

var drivers = `[
    {
    "driverId": "grosjean",
    "permanentNumber": "8",
    "code": "GRO",
    "url": "http://en.wikipedia.org/wiki/Romain_Grosjean",
    "givenName": "Romain",
    "familyName": "Grosjean",
    "dateOfBirth": "1986-04-17",
    "nationality": "French"
    },
    {
    "driverId": "hamilton",
    "permanentNumber": "44",
    "code": "HAM",
    "url": "http://en.wikipedia.org/wiki/Lewis_Hamilton",
    "givenName": "Lewis",
    "familyName": "Hamilton",
    "dateOfBirth": "1985-01-07",
    "nationality": "British"
    },
    {
    "driverId": "hulkenberg",
    "permanentNumber": "27",
    "code": "HUL",
    "url": "http://en.wikipedia.org/wiki/Nico_H%C3%BClkenberg",
    "givenName": "Nico",
    "familyName": "Hülkenberg",
    "dateOfBirth": "1987-08-19",
    "nationality": "German"
    },
    {
    "driverId": "kevin_magnussen",
    "permanentNumber": "20",
    "code": "MAG",
    "url": "http://en.wikipedia.org/wiki/Kevin_Magnussen",
    "givenName": "Kevin",
    "familyName": "Magnussen",
    "dateOfBirth": "1992-10-05",
    "nationality": "Danish"
    }    
]`;

newdrivers = JSON.parse(drivers)
var myDrivers = newdrivers.map(x => ({ Kode: x.code, Fornavn: x.givenName, Efternavn: x.familyName}));
//console.log(myDrivers);

var green_hybrid_cars = cars.filter(x => x.fuel =="hybrid" && x.owner_tax < 200);
//console.log(green_hybrid_cars);

var fuelCriterium = function(car,fuel) {
    return car.fuel == fuel ? true : false;
}

var gas_cars = cars.filter( x => fuelCriterium(x,"gasoline"))
//console.log(gas_cars);

var trips = [{distance : 48}, {distance : 12}, {distance : 6}];

var totalDistance = trips.reduce(function (a, b) {
    return {distance: a.distance + b.distance}; // returns object with property x
  })

//console.log(totalDistance);

var desk = [
    {type: 'sitting'},
    {type: 'standing'},
    {type: 'sitting'},
    {type: 'sitting'},
    {type: 'standing'}
  ];
  
  var deskTypes = desk.reduce((acc, desk) => {
      if (desk.type === "sitting") acc.sitting++;
      if (desk.type === "standing") acc.standing++;
      return acc;
  }, {sitting : 0, standing : 0});
  
console.log(deskTypes);
