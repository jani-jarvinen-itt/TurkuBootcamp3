import React from 'react';

class OmaKomponentti extends React.Component {

    constructor(props) {
        console.log("OmaKomponentti.constructor()");
        
        super(props);
        this.state = { asiakkaat:[] };
    }

    componentDidMount() {
        console.log("OmaKomponentti.componentDidMount()");

        let reactKomponentti = this;
        fetch('https://localhost:44391/api/customers/')
            .then(response => response.json())
            .then(json => {
                console.log("Asiakas-data ladattu.");

                reactKomponentti.setState({ asiakkaat: json });
            });

        console.log("Fetch-kutsu tehty");
    }

    render() {
        console.log("OmaKomponentti.render()");

        // sivutus
        let alkuIndeksi = 50;
        let loppuIndeksi = 60;

        let lkm = this.state.asiakkaat.length;
        var taulukko = [];
        for (let index = 0; index < lkm; index++) {
            let asiakas = this.state.asiakkaat[index];

            // sivutus
            if (index < alkuIndeksi) {
                continue;
            }
            if (index > loppuIndeksi) {
                continue;
            }

            taulukko.push(<tr>
                <td>{asiakas.customerId}</td>
                <td>{asiakas.companyName}</td>
                <td>{asiakas.contactName}</td>
                <td>{asiakas.country}</td>
                <td>{asiakas.phone}</td>
            </tr>);
        }

        return <div>
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>Asiakas-Id</th>
                        <th>Yrityksen nimi</th>
                        <th>Kontaktihenkilö</th>
                        <th>Maa</th>
                        <th>Puhelin</th>
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
