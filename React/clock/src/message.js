import React, { Component } from 'react';

class Message extends Component {
    render(props) {
      return (
        <div className="Message">
          <h1>{this.props.xd}</h1>
        </div>
      );
    }
  }

export default Message;