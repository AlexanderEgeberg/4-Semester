import React, { Component } from 'react';
import { connect } from 'react-redux';
import {Redirect} from 'react-router-dom';
import "../css/MovieList.css"



class MovieList extends Component {

    renderList() {
        if (!Array.isArray(this.props.movie) || !this.props.movie.length){
            return(<Redirect to="/" />)
        }
        else {
            return this.props.movie.map(movie => {
                return  (
                    <div key={movie.id} className="card" style={{width: "18rem"}}>
                        <img className="card-img-top" src={'https://image.tmdb.org/t/p/w185_and_h278_bestv2' + movie.poster_path} alt="Movie" />
                        <div className="card-body">
                            <h5 className="card-title">{movie.title}</h5>
                            <p className="card-text">{movie.overview}</p>
                            <p>Score: <span>{movie.vote_average}</span></p>
                        </div>
                    </div>
                )  
            })
        }
    }

    render() {
        return (
        <div className="Movies">
            {this.renderList()}
        </div>
        )
    }
}

const mapStateToProps = state => {
    return { movie: state.movie };
}
export default connect(mapStateToProps)(MovieList);

