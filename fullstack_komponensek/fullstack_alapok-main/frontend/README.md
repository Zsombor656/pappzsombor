# React + Vite

This template provides a minimal setup to get React working in Vite with HMR and some ESLint rules.

Currently, two official plugins are available:

- [@vitejs/plugin-react](https://github.com/vitejs/vite-plugin-react/blob/main/packages/plugin-react) uses [Babel](https://babeljs.io/) for Fast Refresh
- [@vitejs/plugin-react-swc](https://github.com/vitejs/vite-plugin-react/blob/main/packages/plugin-react-swc) uses [SWC](https://swc.rs/) for Fast Refresh

## React Compiler

The React Compiler is not enabled on this template. To add it, see [this documentation](https://react.dev/learn/react-compiler/installation).

## Expanding the ESLint configuration

If you are developing a production application, we recommend using TypeScript with type-aware lint rules enabled. Check out the [TS template](https://github.com/vitejs/vite/tree/main/packages/create-vite/template-react-ts) for information on how to integrate TypeScript and [`typescript-eslint`](https://typescript-eslint.io) in your project.

# Felhasználókezelő (Full-Stack CRUD)

Ez a projekt egy React alapú felhasználókezelő alkalmazás, amely lehetővé teszi a felhasználók hozzáadását, megtekintését, szerkesztését és törlését. Az alkalmazás a backenddel HTTP kéréseken keresztül kommunikál az Axios segítségével.

---

## Fő komponens: `App.jsx`

Az `App.jsx` fájl a projekt fő komponense, amely a CRUD műveletek kezeléséért felelős. Az alábbiakban részletesen bemutatjuk a működését.

### Importálások
```jsx
import React, { useState, useEffect } from 'react';
import axios from 'axios';
import '../App.css';
import UserForm from './UserForm';
import UserTable from './UserTable';
import UserRow from './UserRow';
```
- **React**: A React könyvtárat használjuk a komponensek létrehozásához.
- **useState**: Állapotkezelésre szolgál, például a felhasználók listájának tárolására.
- **useEffect**: Oldalbetöltéskor vagy állapotváltozáskor futó műveletekhez használjuk.
- **axios**: HTTP kérések küldésére (GET, POST, DELETE, PATCH).
- **CSS fájl**: Az alkalmazás stílusait tartalmazza.
- **UserForm, UserTable, UserRow**: Más komponensek, amelyek az alkalmazás különböző részeit kezelik.

---

### Állapotok
```jsx
const [users, setUsers] = useState([]);
const [loading, setLoading] = useState(true);
const [error, setError] = useState(null);
const [editingId, setEditingId] = useState(null);
const [editedName, setEditedName] = useState('');
const [editedEmail, setEditedEmail] = useState('');
```
- **users**: A felhasználók listáját tárolja.
- **loading**: Jelzi, hogy az adatok betöltése folyamatban van-e.
- **error**: Hibák tárolására szolgál, például ha nem sikerül betölteni az adatokat.
- **editingId**: Az éppen szerkesztett felhasználó ID-jét tárolja.
- **editedName, editedEmail**: A szerkesztett felhasználó nevét és email címét tárolja.

---

### Adatok betöltése
```jsx
const fetchData = async () => {
    setLoading(true);
    try {
        const response = await axios.get('http://localhost:3001/api/users');
        setUsers(response.data);
        setError(null);
    } catch (err) {
        setError("Nem sikerült betölteni az adatokat.");
    } finally {
        setLoading(false);
    }
};

useEffect(() => {
    fetchData();
}, []);
```
- **fetchData**: Az `axios.get` segítségével lekéri a felhasználók listáját a backendről.
- **useEffect**: Az `fetchData` függvényt az oldal betöltésekor futtatja.

---

### Felhasználó hozzáadása
```jsx
const handleAddUser = async (name, email) => {
    try {
        await axios.post('http://localhost:3001/api/users', { name, email });
        fetchData();
    } catch {
        setError("Hiba történt a felhasználó hozzáadása közben.");
    }
};
```
- **handleAddUser**: Új felhasználót ad hozzá az adatbázishoz az `axios.post` segítségével.
- Sikeres hozzáadás után újra betölti az adatokat a `fetchData` függvénnyel.

---

### Felhasználó törlése
```jsx
const handleDeleteUser = async (id) => {
    if (window.confirm(`Biztosan törölni szeretnéd a(z) ${id} ID-jű felhasználót?`)) {
        try {
            await axios.delete(`http://localhost:3001/api/users/${id}`);
            fetchData();
        } catch {
            setError("Nem sikerült törölni a felhasználót.");
        }
    }
};
```
- **handleDeleteUser**: Egy felhasználót töröl az adatbázisból az `axios.delete` segítségével.
- A törlés előtt megerősítést kér a felhasználótól (`window.confirm`).

---

### Felhasználó szerkesztése
```jsx
const handleEditStart = (user) => {
    setEditingId(user.id);
    setEditedName(user.name);
    setEditedEmail(user.email);
};
```
- **handleEditStart**: Beállítja a szerkesztéshez szükséges állapotokat (ID, név, email).

---

### Felhasználó frissítése
```jsx
const handleUpdateUser = async (id, name, email) => {
    try {
        await axios.patch(`http://localhost:3001/api/users/${id}`, { name, email });
        setEditingId(null);
        fetchData();
    } catch {
        setError("Nem sikerült módosítani a felhasználót.");
    }
};
```
- **handleUpdateUser**: Frissíti a felhasználó adatait az `axios.patch` segítségével.
- Sikeres frissítés után újra betölti az adatokat.

---

### Renderelés
```jsx
return (
    <div className="App">
        <h1>Felhasználókezelő (Full-Stack CRUD)</h1>
        {loading && <p>Adatok betöltése...</p>}
        {error && <p className="error">{error}</p>}
        <UserForm onAddUser={handleAddUser} />
        <UserTable
            users={users}
            editingId={editingId}
            editedName={editedName}
            editedEmail={editedEmail}
            onDeleteUser={handleDeleteUser}
            onEditStart={handleEditStart}
            onUpdateUser={handleUpdateUser}
            setEditedName={setEditedName}
            setEditedEmail={setEditedEmail}
        />
    </div>
);
```
- **`<h1>`**: Az alkalmazás címe.
- **`loading` és `error`**: Ha az adatok betöltése folyamatban van, vagy hiba történt, megjeleníti az üzeneteket.
- **`<UserForm>`**: A felhasználó hozzáadására szolgáló komponens.
- **`<UserTable>`**: A felhasználók listáját megjelenítő komponens, amely kezeli a törlést, szerkesztést és frissítést.

---

### Összefoglalás
Az `App.jsx` egy React komponens, amely:
- Betölti az adatokat a backendről.
- Lehetővé teszi új felhasználók hozzáadását, meglévők törlését, szerkesztését és frissítését.
- Más komponenseket használ az alkalmazás különböző részeinek kezelésére.

Ez a fájl a teljes alkalmazás logikáját tartalmazza, és a CRUD műveletek kezelésére szolgál. Az állapotkezelés és az `axios` segítségével kommunikál a backenddel.

