import React from 'react';

const MoviePoster = props => {
    if (props.movie){
        console.log(props.movie.poster_path)
         return ( 
            <div className="movieposter">
                <h3>Poster:</h3>
                <div><img className="img-responsive img-rounded" src={'https://image.tmdb.org/t/p/w185_and_h278_bestv2'+ props.movie.poster_path}></img></div>
               
            </div>
        );
    }
    return null;
};

export default MoviePoster;