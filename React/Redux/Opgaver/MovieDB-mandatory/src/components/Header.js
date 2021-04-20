import React, { Component } from 'react';
import Search from './Search';
import {Link } from 'react-router-dom';


class Header extends Component {


  render() {
    return(
        <nav className="navbar navbar-light bg-light sticky-top ">
            <Link to='/'>Home</Link>
            <Link to='/About'>About</Link>
            <Search />
        </nav>
    );
  }
}

export default Header