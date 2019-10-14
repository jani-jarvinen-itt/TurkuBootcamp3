import React from 'react';

class Nappi extends React.Component {

    render() {

        return <button className="btn btn-info">
            {this.props.teksti}
            </button>
    }

}

export default Nappi;
