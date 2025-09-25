// ezeket a beépített MI segített megcsinálni
const express = require("express");
const app = express();
const cors = require("cors");// Cors segít a frontend és a backend közötti kommunikációban
const mysql = require("mysql");
const bodyParser = require('body-parser');// body-parser segít a bejövő kérések body elemzésében
app.use(bodyParser.json());
const port= 3000
app.use(cors());

// Adatbázis kapcsolat létrehozása 
const db = mysql.createConnection({
    user: "root",
    host: "127.0.0.1",
    port: 3307,
    password: "",
    database: "fogado",
    });
// Kapcsolódás az adatbázishoz
app.get("/", (req, res) => {
    res.send("Fut a backend!");
    })
    app.listen(port, () => {
        console.log(`Szerver fut a ${port}-as porton`);
      });

// a feladat
app.get('/szobak', (req, res) => {
    const sql = 'SELECT sznev,agy FROM szobak;';
    db.query(sql, (err, results) => {
        if (err) {
            return res.status(500).json({ error: err.message });
        }
        res.json(results);
    }
    );
});
//az apikat a beépített mi csináltakivéve az sql részt
//b feladat
app.get('/kihasznaltsag', (req, res) => {
    const sql = `
      SELECT szobak.sznev, COUNT(foglalasok.vendeg) AS vendegek, SUM(foglalasok.fo) AS vendegejszakak 
    FROM szobak INNER JOIN foglalasok ON szobak.szazon = foglalasok.szoba
    GROUP BY szobak.szazon, szobak.sznev
    ORDER BY vendegejszakak ASC, vendegek ASC;
    `;
    db.query(sql, (err, results) => {
      if (err) {
        return res.status(500).json({ error: err.message });
      }
      res.json(results);
    });
  });
// c feladatotra nem jutott időm
