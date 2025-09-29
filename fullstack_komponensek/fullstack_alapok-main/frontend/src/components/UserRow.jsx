import React, { useState } from 'react';

function UserRow({ user, onDeleteUser, onUpdateUser }) {
    const [isEditing, setIsEditing] = useState(false);
    const [editedName, setEditedName] = useState(user.name);
    const [editedEmail, setEditedEmail] = useState(user.email);

    const handleSave = () => {
        onUpdateUser(user.id, editedName, editedEmail);
        setIsEditing(false);
    };

    const handleCancel = () => {
        setIsEditing(false);
        setEditedName(user.name);
        setEditedEmail(user.email);
    };

    return (
        <tr>
            <td>{user.id}</td>
            {isEditing ? (
                <>
                    <td><input value={editedName} onChange={e => setEditedName(e.target.value)} /></td>
                    <td><input value={editedEmail} onChange={e => setEditedEmail(e.target.value)} /></td>
                </>
            ) : (
                <>
                    <td>{user.name}</td>
                    <td>{user.email}</td>
                </>
            )}
            <td>{new Date(user.created_at).toLocaleDateString()}</td>
            <td>
                {isEditing ? (
                    <>
                        <button onClick={handleSave}>Mentés</button>
                        <button onClick={handleCancel}>Mégse</button>
                    </>
                ) : (
                    <>
                        <button onClick={() => setIsEditing(true)}>Szerkesztés</button>
                        <button onClick={() => onDeleteUser(user.id)}>Törlés</button>
                    </>
                )}
            </td>
        </tr>
    );
}

export default UserRow;