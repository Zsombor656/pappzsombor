import React from 'react';

function UserRow({
    user,
    editingId,
    editedName,
    editedEmail,
    onDeleteUser,
    onEditStart,
    onUpdateUser,
    setEditedName,
    setEditedEmail,
}) {
    const isEditing = editingId === user.id;
    return (
        <tr>
            <td class='tableCell'>{user.id}</td>
            {isEditing ? (
                <>
                    <td>
                        <input
                            type="text"
                            value={editedName}
                            onChange={(e) => setEditedName(e.target.value)}
                        />
                    </td>
                    <td>
                        <input
                            type="email"
                            value={editedEmail}
                            onChange={(e) => setEditedEmail(e.target.value)}
                        />
                    </td>
                </>
            ) : (
                <>
                     <td class='tableCell'>{user.name}</td>
                     <td class='tableCell'>{user.email}</td>
                </>
            )}
            <td class='tableCell'>{new Date(user.created_at).toLocaleDateString()}</td>
            <td  class='tableCell'>
                {isEditing ? (
                    <>
                        <button onClick={() => onUpdateUser(user.id, editedName, editedEmail)}>Mentés</button>
                        <button onClick={() => setEditedName(user.name) || setEditedEmail(user.email)}>Mégse</button>
                    </>
                ) : (
                    <>
                        <button class='editButton' onClick={() => onEditStart(user)}>Szerkesztés</button>
                        <button class='deleteButton' onClick={() => onDeleteUser(user.id)}>Törlés</button>
                    </>
                )}
            </td>
        </tr>
    );
}

export default UserRow;