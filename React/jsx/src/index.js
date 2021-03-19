//Import the React and ReactDom lib
import React from 'react';
import ReactDOM from 'react-dom';

//Create a react function component
/*
const App = () => {
return <div><h1>Hello world!</h1></div>;
};
*/

const App = () => {
  const helloText = 'Hello World!'
  return <div style={{ backgroundColor: 'green'}}><h1 style={{ color: 'white'}}>{helloText}</h1></div>;
};


//Take the react component and show it on the screen
ReactDOM.render(<App />, document.getElementById('root'));