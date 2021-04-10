import React from 'react';
import { connect } from 'react-redux';

const MoviePoster = ({ movie }) => {
    if (movie){
         return ( 
            <div className="movieposter">
                <h3>Poster:</h3>
                <div><img className="poster" alt="Poster" src={require(`../${movie.Poster}`)}></img> </div>
            </div>
        );
    }
    return null;
};


const mapStateToProps = (state) => {
    return { movie : state.selectedMovie };
}


export default connect(mapStateToProps)(MoviePoster);
