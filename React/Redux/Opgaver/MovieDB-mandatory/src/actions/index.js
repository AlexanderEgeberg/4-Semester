import moviedb from '../apis/moviedb';

export const fetchMovies= (input) => async dispatch => {

    const response = await moviedb.get(input + '&api_key=81c50c197b83129dd4fc387ca6c8c323');
    console.log(response.data.results)
    dispatch({type: 'FETCH_MOVIES', payload: response.data.results})
};