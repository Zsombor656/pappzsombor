const express = require("express");
const app = express();
const cors = require("cors");
const mysql = require("mysql");
const bodyParser = require('body-parser');
app.use(bodyParser.json());
const port= 3000
app.use(cors());

// Adatbázis kapcsolat létrehozása
const db = mysql.createConnection({
    user: "root",
    host: "127.0.0.1",
    port: 3307,
    password: "",
    database: "kozutak",
    });
    // Gyökér útvonal, tesztelésre
    app.get("/", (req, res) => {
    res.send("Fut a backend!");
    })
    app.listen(port, () => {
        console.log(`Szerver fut a ${port}-as porton`);
      });
// Régiók listázása
app.get("/regiok", (req, res) => {
  const sql = "SELECT * FROM `regiok` ";
  db.query(sql, (err, result) => {
  if (err) return res.json(err);
  return res.json(result)
  })
 })
 app.get("/barmi", (req, res) => {
  const sql = "SELECT * FROM `regiok` where Rid=4";
  db.query(sql, (err, result) => {
  if (err) return res.json(err);
  return res.json(result)
  })
 })
 
 app.get("/barmi", (req, res) => {
  const sql = "SELECT * FROM `regiok` where regionev Like'B%'";
  db.query(sql, (err, result) => {
  if (err) return res.json(err);
  return res.json(result)
  })
 })

 app.get("/barmi", (req, res) => {
  const sql = "SELECT * FROM `regiok` where regio_tipusa='főváros'";
  db.query(sql, (err, result) => {
  if (err) return res.json(err);
  return res.json(result)
  })
 })