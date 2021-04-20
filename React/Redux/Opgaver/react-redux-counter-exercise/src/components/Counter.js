import React from 'react';
import { connect } from 'react-redux'
import { increment, decrement } from '../actions';

const Counter = () => {
    return (
        <div>
            <button 
                className="ui button primary"
                
            >
                Increment
            </button>
            <button 
                className="ui button primary"
                
            >
                Decrement  
            </button>
            Current count: <span>0</span>
        </div>
    );
};

const MapStateToProps = (state) => {
    return {countProp : state.count};
};

export default connect(MapStateToProps, {increment, decrement})(Counter);
