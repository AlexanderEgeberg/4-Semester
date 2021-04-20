import { combineReducers } from 'redux';
import movieReducer from './movieReducer';
//import more here




export default combineReducers( {
    movie: movieReducer,
    //add more here
});