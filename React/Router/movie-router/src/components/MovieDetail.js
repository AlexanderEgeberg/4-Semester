
import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';
import './MovieDetail.css';

const MovieDetail = ({ movie }) => {
    console.log("Test");
    if (movie){
    return (    
        <div className="container">
            <div>
                <div className="row">
                    <div className="col-md-4">
                        <img alt="Poster" className="img-fluid rounded poster" src={require(`../${movie.Poster}`)}></img>
                    </div>
                    <div className="col-md-5">
                        <h1>Movie:</h1>
                        <b>Title:</b> {movie.Title}<b></b>
                        <b>Year:</b> {movie.Year}<br></br>
                        <b>Genre:</b> {movie.Genre}<br></br>
                        <b>Actors:</b> {movie.Actors}<br></br>
                        <br></br><br></br>
                        <h4>Plot:</h4> {movie.Plot}<br></br>
                        <br></br>
                        <p>
                            <button className = "badge badge-dark"> 
                                <Link to="/">Back</Link>
                            </button>
                        </p>
                    </div>
                    <div className="col-md-3">
                    </div>
                </div>
            </div>
        </div>
    );
    }
    return null;
  }



const mapStateToProps = (state) => {
    return { movie : state.selectedMovie };
}


export default connect(mapStateToProps)(MovieDetail);
