const express = require('express')
const app = express()
const port= 3000


app.get('/', (req, res) => {
    res.send('Hello, világ!');
  });
  

  app.listen(port, () => {
    console.log(`Szerver fut a ${port}-as porton`);
  });
  