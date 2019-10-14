import React from 'react';

class Laskin extends React.Component {

    nappiaKlikattu() {
        console.log("Laske-nappia klikattu!");
    }

    luku1Muuttui(event) {
        console.log("luku1Muuttui-metodissa");
        this.setState({ luku1: event.target.value});
    }

    luku2Muuttui(event) {
        console.log("luku2Muuttui-metodissa");
        this.setState({ luku2: event.target.value});
    }

    render() {
        return <div>
            <h1>Lomake-testi</h1>
            <p> <input type="text" onChange={this.luku1Muuttui} /> </p>
            <p> <input type="text" onChange={this.luku2Muuttui} /> </p>
            <p> <button onClick={this.nappiaKlikattu}>Laske</button> </p>
        </div>;
    }

}

export default Laskin;
