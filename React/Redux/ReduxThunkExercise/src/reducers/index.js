import { combineReducers } from 'redux';
import driversReducer from './driversReducer';
import racesReducer from './racesReducer';
import resultsReducer from './resultsReducer';

export default combineReducers ({
    drivers: driversReducer,
    races: racesReducer,
    results: resultsReducer
});