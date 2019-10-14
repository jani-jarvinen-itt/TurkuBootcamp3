import React from 'react';

class Laskin extends React.Component {

    constructor(props) {
        super(props);

        console.log("Konstruktorissa...");

        this.state = { luku1: "", luku2: "" };

        this.luku1Muuttui = this.luku1Muuttui.bind(this);
        this.luku2Muuttui = this.luku2Muuttui.bind(this);
        this.nappiaKlikattu = this.nappiaKlikattu.bind(this);
    }

    nappiaKlikattu() {
        console.log("Laske-nappia klikattu!");
        console.log("Tila nyt:");
        console.log(this.state);

        let summa = parseInt(this.state.luku1) + parseInt(this.state.luku2);
        alert("Summa on: " + summa);
    }

    luku1Muuttui(event) {
        console.log("luku1Muuttui-metodissa");
        this.setState({ luku1: event.target.value });
    }

    luku2Muuttui(event) {
        console.log("luku2Muuttui-metodissa");
        this.setState({ luku2: event.target.value });
    }

    render() {
        return <div>
            <h1>Lomake-testi</h1>
            <p> <input type="number" onChange={this.luku1Muuttui} /> </p>
            <p> <input type="number" onChange={this.luku2Muuttui} /> </p>
            <p> <button onClick={this.nappiaKlikattu}>Laske</button> </p>
        </div>;
    }

}

export default Laskin;
