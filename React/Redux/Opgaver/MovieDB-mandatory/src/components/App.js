import React, { Component } from 'react';
import MovieList from './MovieList';
import Header from './Header';
import { Route} from 'react-router-dom';
import Home from './Home';
import About from './About';
import Footer from './Footer';

class App extends Component {


  render() {
    return(
      <div>
        <Header />

        <Route exact path='/' component={Home}/>
        <Route path='/About' component={About}/>
        <Route path='/MovieList' component={MovieList}/>
        <Footer />
      </div>

    );
  }
}

export default App