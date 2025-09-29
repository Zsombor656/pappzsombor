import React, { useState } from 'react';

function UserForm({ onAddUser }) {
    const [name, setName] = useState('');
    const [email, setEmail] = useState('');

    const handleSubmit = (e) => {
        e.preventDefault();
        if (!name || !email) {
            alert("A név és az email megadása kötelező!");
            return;
        }
        onAddUser(name, email);
        setName('');
        setEmail('');
    };

    return (
        <form onSubmit={handleSubmit} className="user-form">
            <input
                type="text"
                placeholder="Név"
                value={name}
                onChange={(e) => setName(e.target.value)}
            />
            <input
                type="email"
                placeholder="Email"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
            />
            <button type="submit">Hozzáadás</button>
        </form>
    );
}

export default UserForm;