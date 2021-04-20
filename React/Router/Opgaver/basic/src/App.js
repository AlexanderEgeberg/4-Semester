import React from 'react';
import { Route, Link } from 'react-router-dom';
import Home from './home';
import Page2 from './Page2';

const App = () => (

  <div>

    <Link to='/'>Home</Link> <br></br>
    <Link to='/page2'>Page2</Link>
    <Route exact path='/' component={Home}/>
    <Route path='/page2' component={Page2}/>
  </div>

)

  
export default App