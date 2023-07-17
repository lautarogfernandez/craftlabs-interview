import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

function App() {


  const [products, setProducts] = useState([])
  const apiUrl = "https://localhost:5001/Products";

  fetch(apiUrl)
    .then(async function (response) {
      if (response.ok) {
        const data = await response.json()
        console.log(data);
        setProducts(data)
      } else {
        console.log('Respuesta de red OK pero respuesta HTTP no OK');
      }
    })
    .catch(function (error) {
      console.log('Hubo un problema con la petición Fetch:' + error.message);
    });

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>

      <div style={{ backgroundColor: 'blue' }}>
        <ul>
          {products.map(p => <li>{p.name}</li>)}
        </ul>
      </div>

    </div>
  );
}

export default App;
