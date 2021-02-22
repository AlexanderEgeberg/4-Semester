promise = new Promise((resolve, reject)  => {
    resolve(); // reject();
});

promise
    .then(()=> setTimeout(function(){console.log("Im finish")},3000))         //callback, udføres ved resolved
    .then(()=>console.log('jeg blev også kaldt'))  
    .catch(() => console.log('uh oh!!'))         //callback, udføres ved reject
