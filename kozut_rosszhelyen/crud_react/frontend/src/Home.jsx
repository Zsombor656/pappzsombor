import React from "react";
import { Link } from "react-router-dom";
import Button from 'react-bootstrap/Button';
import Col from 'react-bootstrap/Col';
import Form from 'react-bootstrap/Form';
import InputGroup from 'react-bootstrap/InputGroup';
import Row from 'react-bootstrap/Row';
const Home = () => {
  return (
    <div className="container-fluid">
       <div className="row">
        <div className="col-md-12">
          <h1 className="text-center">Közutak</h1>
        </div>
      </div>
 
<nav class="navbar bg-body-tertiary">
  <div class="container-fluid">
    <div class="row">
      <div class="col-md-6">
          <a class="navbar-brand" href="http://localhost:3001/regiok">Régiók</a>
          <a class="navbar-brand" href="http://localhost:3001/regiok_8">8. régió</a>
          <a class="navbar-brand" href="http://localhost:3001/regiok/id"> az id helyére írj be egy érvényes régió azonosítóját</a>

       </div>
    </div>

  </div>
</nav>
</div>
    
  );
};

export default Home;