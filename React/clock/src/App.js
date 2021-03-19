import React, { Component } from 'react';
import Message from './message';
import Clock from './Clock';

class App extends Component {
  render() {
    return (
      <div className="App">
      <Message xd="Local time:"/>
      <Clock />

   </div>
    );
  }
}
export default App;