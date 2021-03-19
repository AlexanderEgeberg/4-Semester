import React, { Component } from 'react';
import MovieImg from '../assets/Image/movie_img.png';
import SearchBar from './SearchBar';
import MovieList from './MovieList';
import MoviePoster from './MoviePoster';
import MoviePlot from './MoviePlot';
import axios from 'axios';


class App extends Component {
  
  state = {
    movies: null,
    selectedMovie: null
  };

  
  onSearchSubmit = async (term) =>{
    const response = await axios.get('http://api.themoviedb.org/3/search/movie?query=' + term + '&api_key=81c50c197b83129dd4fc387ca6c8c323')
    this.setState({movies: response.data.results});
    this.setState({selectedMovie: null});
  }

  onSelectedMovieCallBack = (movie) => {
      this.setState({selectedMovie : movie});
  }
  
  render() {
    return (
      <div className="App">
        <div className="jumbotron">
          <h1>React Movies <img alt="Movie" src={MovieImg}></img> </h1>  
           This small App demonstrates communication between child-components using Props/State and CallBack
        </div> 

        <div className="row">
          <div className="col-sm-1"></div>
          <div className="col-sm-3">
              <SearchBar onSearchMovie={this.onSearchSubmit}/>
              <br/>
        </div>
        </div>
        <div className="row">
          <div className="col-sm-1"></div>
          <div className="col-sm-3">

              <MovieList SearchMovies={this.state.movies} onSelectedMovie={this.onSelectedMovieCallBack}/>
          </div>
          <div className="col-sm-5">
              <MoviePoster movie={this.state.selectedMovie}/>
              <br/>
              <MoviePlot movie={this.state.selectedMovie}/>
          </div>
          <div className="col-sm-2"></div>
        </div>
       
      </div>
    );
  }
}

export default App;
