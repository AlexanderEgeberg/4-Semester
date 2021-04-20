import React, { Component } from 'react';
import DriverList from './DriverList';
import RaceList from './RaceList';
import ResultList from './ResultList';
import Header from './Header';


class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <Header />
          <DriverList />
          <RaceList />
          <ResultList />
        </header>
      </div>
    );
  }
}

export default App;
