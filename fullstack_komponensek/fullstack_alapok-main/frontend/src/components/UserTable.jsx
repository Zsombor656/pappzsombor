import React from 'react';
import UserRow from './UserRow';

function UserTable({ users, onDeleteUser, onUpdateUser }) {
    return (
        <div>
            <h2>Felhasználók Listája</h2>
            <table style={{ width: '100%', borderCollapse: 'collapse' }}>
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
                        users.map(user => (
                            <UserRow 
                                key={user.id} 
                                user={user} 
                                onDeleteUser={onDeleteUser} 
                                onUpdateUser={onUpdateUser} 
                            />
                        ))
                    ) : (
                        <tr>
                            <td colSpan="5" style={{ textAlign: 'center' }}>Nincsenek felhasználók az adatbázisban.</td>
                        </tr>
                    )}
                </tbody>
            </table>
        </div>
    );
}

export default UserTable;