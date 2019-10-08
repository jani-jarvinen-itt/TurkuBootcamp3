import React from 'react';

class OmaKomponentti extends React.Component {
    render() {

        var luvut = [];
        for (let index = 1; index <= 10; index++) {
            luvut.push(<p>{index}</p>);            
        }

        var lisäKoodia = <p>Tässä on tavallista tekstiä.</p>;

        return <div>
            <h1>Tämä on oma komponenttini!</h1>
            <p>Testi</p>
            {lisäKoodia}
            {luvut}
        </div>;
    }
}

export default OmaKomponentti;
