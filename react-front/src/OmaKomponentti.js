import React from 'react';

class OmaKomponentti extends React.Component {

    constructor(props) {
        console.log("OmaKomponentti.constructor()");
        
        super(props);
        this.state = { asiakkaat:[] };
    }

    componentDidMount() {
        console.log("OmaKomponentti.componentDidMount()");

        fetch('https://localhost:44391/api/customers/')
            .then(response => response.json())
            .then(json => console.log(json))

        console.log("Fetch-kutsu tehty");
    }

    render() {
        console.log("OmaKomponentti.render()");

        var taulukko = [];
        for (let index = 1; index <= 10; index++) {
            taulukko.push(<tr>
                <td>{index}-1</td>
                <td>{index}-2</td>
                <td>{index}-3</td>
            </tr>);
        }

        return <div>
            <table class="table table-striped">
                <thead>
                    <tr>
                        <th>Sarake 1</th>
                        <th>Sarake 2</th>
                        <th>Sarake 3</th>
                    </tr>
                </thead>
                <tbody>
                    {taulukko}
                </tbody>
            </table>
        </div>;
    }
}

export default OmaKomponentti;
