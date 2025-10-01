import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import './css/App.css';
import UserForm from './components/UserForm';
import UserTable from './components/UserTable';
import NavBar from './components/NavBar';

function App() {
    const [users, setUsers] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);
    const [editingId, setEditingId] = useState(null);
    const [editedName, setEditedName] = useState('');
    const [editedEmail, setEditedEmail] = useState('');

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

    const handleAddUser = async (name, email) => {
        try {
            await axios.post('http://localhost:3001/api/users', { name, email });
            fetchData();
        } catch {
            setError("Hiba történt a felhasználó hozzáadása közben.");
        }
    };

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

    const handleEditStart = (user) => {
        setEditingId(user.id);
        setEditedName(user.name);
        setEditedEmail(user.email);
    };

    const handleUpdateUser = async (id, name, email) => {
        try {
            await axios.patch(`http://localhost:3001/api/users/${id}`, { name, email });
            setEditingId(null);
            fetchData();
        } catch {
            setError("Nem sikerült módosítani a felhasználót.");
        }
    };

    const LoginPage = () => (
        <div className="login-page">
            <h1>Felhasználó hozzáadása</h1>
            <UserForm onAddUser={handleAddUser} />
        </div>
    );

    const UsersPage = () => (
        <div className="users-page">
            <h1>Felhasználókezelő (Full-Stack CRUD)</h1>
            {loading && <p>Adatok betöltése...</p>}
            {error && <p className="error">{error}</p>}
            
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

    return (
        <Router>
            <NavBar />
            <Routes>
                <Route path="/" element={<LoginPage />} />
                <Route path="/users" element={<UsersPage />} />
            </Routes>
        </Router>
    );
}

export default App;