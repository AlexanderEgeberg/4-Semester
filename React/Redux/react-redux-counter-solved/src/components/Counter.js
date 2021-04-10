import React from 'react';
import { connect } from 'react-redux';
import { increment, decrement } from '../actions';

const Counter = (props) => {
    return (
        <div>
            <button 
                className="ui button primary"
                onClick={props.increment}
            >
                Increment
            </button>
            <button 
                className="ui button primary"
                onClick={props.decrement}
            >
                Decrement  
            </button>
            Current count: <span>{props.countProp}</span>
        </div>
    );
};

const mapStateToProps = (state) => {
    return {countProp : state.count};
};


export default connect(mapStateToProps, {increment, decrement})(Counter);