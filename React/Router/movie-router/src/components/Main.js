import React, { Component } from 'react';
import { Switch, Route } from 'react-router-dom';
import Movies from './Movies';
import About from './About';
import MovieDetails from './MovieDetail';
import UnderConstruction from './UnderConstruction';

class Main extends Component {

    render() {
      console.log("Main");
      return (
            <main className = "main row">
              <div className = "col-1"></div>
              <div className = "col-8">
                <Switch>
                    <Route exact path='/' component={Movies}/>
                    <Route path='/About'  component={About}/>
                    <Route path='/Login'  component={UnderConstruction}/>
                    <Route path='/Admin'  component={UnderConstruction}/>
                    <Route path='/MovieDetails'  component={MovieDetails}/>
                </Switch>
                </div>
                <div className = "col-3"></div>
            </main>
      );
    }
  }
  
  export default Main;

    