import React, { Component } from 'react';
import { connect } from 'react-redux'
import { fetchMovies } from '../actions';
import { Link } from 'react-router-dom';
import { Button } from 'react-bootstrap';


class Search extends Component {
    state = {
        searchCriteria: ''
    };

    onFormSubmit = (event) => {
        event.preventDefault();
         this.props.fetchMovies(this.state.searchCriteria);

    }

    render() {
        return (
            <form onSubmit={this.onFormSubmit} role="search">
                <div className=" input-group">
                    <input type="text" value={this.state.searchCriteria} onChange={ (e) => this.setState({searchCriteria: e.target.value})}/>
                        <Button className="btn btn-default" onClick={this.onFormSubmit}>
                            <Link to='/MovieList'>
                                <span style={{color: "white"}}>Click me!</span>
                            </Link>
                        </Button>
                </div>
            </form>
        )
    }

}

const mapStateToProps = state => {
    return { movie: state.movie };
}

export default connect(mapStateToProps, {fetchMovies})(Search);
