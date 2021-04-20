import axios from 'axios';



export default axios.create({baseURL:'http://api.themoviedb.org/3/search/movie?query='});