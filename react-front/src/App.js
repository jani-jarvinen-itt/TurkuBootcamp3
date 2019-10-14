import React from 'react';
// import logo from './logo.svg';
import './App.css';
import OmaKomponentti from './OmaKomponentti';
import Nappi from './Nappi';
import Laskin from './Laskin';

function App() {
  return (
    <div className="App">
      <Nappi teksti="Oma Nappi" väri="info" />
     <p>&nbsp;</p>
     <Laskin />
     <p>&nbsp;</p>
      <OmaKomponentti />
    </div>
  );
}

export default App;
