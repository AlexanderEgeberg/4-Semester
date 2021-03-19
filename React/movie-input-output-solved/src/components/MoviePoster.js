import React from 'react';

const MoviePoster = props => {
    if (props.movie){
         return ( 
            <div className="movieposter">
                <h3>Poster:</h3>
                <div><img className="poster" alt="Poster" src={require(`../${props.movie.Poster}`)}></img> </div>
            </div>
        );
    }
    return null;
};

export default MoviePoster;