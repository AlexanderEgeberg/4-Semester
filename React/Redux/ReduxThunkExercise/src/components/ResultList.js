import React from 'react';
import { connect } from 'react-redux';
import { fetchResult } from '../actions';


class ResultList extends React.Component {
    componentDidMount(){
        this.props.fetchResult(2019, 1);
    }

    renderList() {
        return this.props.results.map(result => {
            return (
                <div className="item" key={result.round}>
                    RaceResults
                   <br></br>   
                </div>
            )
        })
    }

    render() {
        return <div>{this.renderList()}</div>;
    }
}

const mapStateToProps = state => {
    return { results: state.results };
}
export default connect(mapStateToProps, {fetchResult})(ResultList);

