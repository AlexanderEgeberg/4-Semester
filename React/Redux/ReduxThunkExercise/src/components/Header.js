import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import F1Img from '../assets/F1.jpg';
import './Header.css';

class Header extends Component {
  
  
  render() {
    return (
        
          <div>
          
            <div class="navbar navbar-expand-lg" >
                <ui className="nav navbar-nav ml-auto">
                   <li className="nav-item nav-link"> <Link to='/' >Drivers</Link></li>
                   <li className="nav-item nav-link"> <Link to='/' >Races</Link></li>
                   <li className="nav-item nav-link"> <Link to='/' >Results</Link></li>
                </ui>
            </div>
            <div className="jumbotron">
            
            <h1>React-Redux-Thunk-Axios-Router Formula 1 <img alt="F1" className ="img-fluid rounded" src={F1Img} style={{width:150, height:150}}></img></h1>  
               <h5> This small React-App demonstrates the use of Redux-Thunk</h5>
                </div>
                </div>
        
    );
  }
}

export default Header;