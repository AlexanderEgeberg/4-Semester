import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import MovieImg from '../assets/Image/movie_black2.jpg';

class Header extends Component {
  
  
  render() {
    return (
        <header>
          <div className="jumbotron">
            <div class="navbar navbar-expand-lg" >
                <nav className="nav navbar-nav">
                    <Link to='/' className="nav-item nav-link">Movies</Link>
                    <Link to='/Admin' className="nav-item nav-link">Admin</Link>
                    <Link to='/About' className="nav-item nav-link">About</Link>
                    <Link to='/Login' className="nav-item nav-link">Login</Link>
                </nav>
            </div>
            <br></br>
            <h1>React-Redux-Router Movies  <img alt="Movie" className ="img-fluid rounded" src={MovieImg} style={{width:70, height:70}}></img></h1>  
                This small React-App demonstrates the use of React-Router
          </div> 
        </header>
    );
  }
}

export default Header;