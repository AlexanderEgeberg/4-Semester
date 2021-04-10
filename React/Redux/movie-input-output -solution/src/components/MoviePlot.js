import React from 'react';
import { connect } from 'react-redux';

const MoviePlot = ({ movie }) => {
    if (movie){
        return ( 
            <div className="movieplot">
                <h3>Plot: </h3>
                <div>{movie.Plot}</div>
            </div>
         );
    }
    return null;
};

const mapStateToProps = (state) => {
    return { movie : state.selectedMovie };
}


export default connect(mapStateToProps)(MoviePlot);
