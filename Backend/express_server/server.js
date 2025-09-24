const express = require("express");
const app = express();
const PORT = 3000;

// Middleware – hogy JSON-t tudjon kezelni
app.use(express.json());

// Alap route
app.get("/", (req, res) => {
  res.send("Hello, Express!");
});

// Szerver indítása
app.listen(PORT, () => {
  console.log(`Szerver fut a http://localhost:${PORT} címen`);
});