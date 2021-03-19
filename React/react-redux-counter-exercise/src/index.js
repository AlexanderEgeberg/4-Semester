import React from 'react';
import ReactDOM from 'react-dom';

import { createStore } from 'redux';

import App from './components/App';
import countReducer from './reducers';

const store = {createStore(countReducer)};

ReactDOM.render(<App />, document.getElementById('root'));


