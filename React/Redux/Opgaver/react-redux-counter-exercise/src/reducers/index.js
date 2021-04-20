import { combineReducers } from 'redux';

const countReducer = (count=0, action) => {
    if (action.type === 'INCREMENT') { return count + 1; }
    if (action.type === 'DECREMENT') { return count - 1; }
    return count;
};

export default combineReducers({
    count: countReducer
});