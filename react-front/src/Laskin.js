import React from 'react';

class Laskin extends React.Component {

    nappiaKlikattu() {
        console.log("Laske-nappia klikattu!");
    }

    render() {
        return <div>
            <h1>Lomake-testi</h1>
            <p> <input type="text" /> </p>
            <p> <input type="text" /> </p>
            <p> <button onClick={this.nappiaKlikattu}>Laske</button> </p>
        </div>;
    }

}

export default Laskin;
