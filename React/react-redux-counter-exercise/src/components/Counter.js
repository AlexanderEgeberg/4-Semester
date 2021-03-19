import React from 'react';

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


