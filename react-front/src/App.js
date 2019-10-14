import React from 'react';
import logo from './logo.svg';
import './App.css';
import OmaKomponentti from './OmaKomponentti';
import Nappi from './Nappi';

function App() {
  return (
    <div className="App">
      <Nappi teksti="Oma Nappi" />
      <Nappi teksti="Lataa tiedot" />
      <Nappi teksti="Tallenna" />
      <Nappi teksti="Peruuta" />
      <OmaKomponentti />
    </div>
  );
}

export default App;
