import React from 'react';

class OmaKomponentti extends React.Component {
    render() {

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
