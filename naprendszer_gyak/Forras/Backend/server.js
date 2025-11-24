const express = require("express");
const app = express();
const cors = require("cors");
const mysql = require("mysql");

app.use(cors());

const db = mysql.createPool({
    host: "127.0.0.1",
    user: "root",
    port: "3307",
    password: "",
    database: "naprendszer",
});

app.get("/", (req, res) => {
    res.send("Fut a backend!");
    });

app.listen(3001, () => {
    console.log("Fut a szerver a 3001-es porton");
});

//elso feladat
app.get("/bolygok", (req, res) => {
    const sql = "SELECT * FROM bolygok";
    db.query(sql, (err, result) => {
        if (err) {
            console.log(err);
        } else {
            res.send(result);
        }
    });
});

//masodik feladat

app.delete('/torles/:id', (req, res) => {
    const id = req.params.id;

    db.query('DELETE FROM bolygok WHERE id = ?', [id], (err, result) => {
        if (err) {
            return res.status(500).send('Hiba történt a törlés közben!');
        }

        if (result.affectedRows === 0) {
            return res.status(404).send('Nincs ilyen bolygó az adatbázisban!');
        }

        res.status(200).send('Bolygó sikeresen törölve!');
    });
});

app.listen(3000, () => console.log('Fut a http://localhost:3000 címen'));

//harmadik feladat