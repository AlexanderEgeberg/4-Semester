import React from 'react';


class About extends React.Component {
    render () {
        console.log("About");
        return <img alt="Under Construction" className="responsive rounded" src={require('../assets/Image/underconstruction.gif')}></img>
    }
};


export default About;
