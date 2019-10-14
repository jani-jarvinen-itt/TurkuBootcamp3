import React from 'react';

class Nappi extends React.Component {

    render() {

        let cssMääritys = "btn btn-info";
        if (this.props.väri != undefined) {
            cssMääritys = "btn btn-" + this.props.väri;
        }

        let tyyli = { marginLeft: 20 };

        return <button style={tyyli} className={cssMääritys}>
            {this.props.teksti}
            </button>
    }

}

export default Nappi;
