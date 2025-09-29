import React, { useState, useEffect } from 'react';
import axios from 'axios';
import UserForm from './components/UserForm';
import UserTable from './components/UserTable';
import './App.css';

function App() {
    const [users, setUsers] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    const fetchData = async () => {
        setLoading(true);
        try {
            const response = await axios.get('http://localhost:3001/api/users');
            setUsers(response.data);
            setError(null);
        } catch (err) {
            console.error("Hiba az adatok lekérésekor:", err);
            setError("Nem sikerült betölteni az adatokat. Ellenőrizze, hogy a backend szerver fut-e a 3001-es porton.");
        } finally {
            setLoading(false);
        }
    };

    useEffect(() => {
        fetchData();
    }, []);

    const handleAddUser = async (name, email) => {
        try {
            await axios.post('http://localhost:3001/api/users', { name, email });
            fetchData();
        } catch (err) {
            console.error('Hiba az adatok küldésekor:', err);
            setError("Hiba történt a felhasználó hozzáadása közben.");
        }
    };

    const handleDeleteUser = async (id) => {
        try {
            await axios.delete(`http://localhost:3001/api/users/${id}`);
            fetchData();
        } catch (err) {
            console.error("Hiba a törléskor:", err);
            setError("Nem sikerült törölni a felhasználót.");
        }
    };

    const handleUpdateUser = async (id, name, email) => {
        try {
            await axios.patch(`http://localhost:3001/api/users/${id}`, { name, email });
            fetchData();
        } catch (err) {
            console.error("Hiba a módosításkor:", err);
            setError("Nem sikerült módosítani a felhasználót.");
        }
    };

    if (loading) {
        return <div className="App"><p>Adatok betöltése...</p></div>;
    }
    if (error) {
        return <div className="App"><p style={{ color: 'red' }}>{error}</p></div>;
    }

    return (
        <div className="App">
            <h1>Felhasználókezelő (Full-Stack CRUD)</h1>
            <UserForm onAddUser={handleAddUser} />
            <UserTable 
                users={users} 
                onDeleteUser={handleDeleteUser} 
                onUpdateUser={handleUpdateUser} 
            />
        </div>
    );
}

export default App;
