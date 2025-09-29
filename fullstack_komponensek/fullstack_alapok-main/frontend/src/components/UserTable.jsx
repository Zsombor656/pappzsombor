
import React from 'react';
import UserRow from './UserRow';

function UserTable({
    users,
    editingId,
    editedName,
    editedEmail,
    onDeleteUser,
    onEditStart,
    onUpdateUser,
    setEditedName,
    setEditedEmail,
}) {
    return (
        <table className="user-table">
            <thead>
                <tr>
                    <th>#ID</th>
                    <th>Név</th>
                    <th>Email</th>
                    <th>Regisztráció</th>
                    <th>Műveletek</th>
                </tr>
            </thead>
            <tbody>
                {users.length > 0 ? (
                    users.map((user) => (
                        <UserRow
                            key={user.id}
                            user={user}
                            editingId={editingId}
                            editedName={editedName}
                            editedEmail={editedEmail}
                            onDeleteUser={onDeleteUser}
                            onEditStart={onEditStart}
                            onUpdateUser={onUpdateUser}
                            setEditedName={setEditedName}
                            setEditedEmail={setEditedEmail}
                        />
                    ))
                ) : (
                    <tr>
                        <td colSpan="5">Nincsenek felhasználók.</td>
                    </tr>
                )}
            </tbody>
        </table>
    );
}

export default UserTable;