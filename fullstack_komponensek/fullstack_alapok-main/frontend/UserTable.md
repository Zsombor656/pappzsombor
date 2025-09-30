## 2. `UserTable.jsx`

### Feladata:
A `UserTable.jsx` komponens felelős a felhasználók listájának megjelenítéséért. Ez a komponens tartalmazza a táblázatot, amelyben minden felhasználó adatai láthatók.

### Kód:
```jsx
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
        <table>
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
                {users.map((user) => (
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
                ))}
            </tbody>
        </table>
    );
}

export default UserTable;
```

### Magyarázat:
- **Táblázat**:
  - A táblázat fejlécében láthatók az oszlopok nevei: ID, Név, Email, Regisztráció, Műveletek.
- **`users.map`**:
  - A felhasználók listáját iterálja, és minden felhasználóhoz létrehoz egy `UserRow` komponenst.
- **`UserRow`**:
  - A táblázat egy sorát jeleníti meg, amely tartalmazza a felhasználó adatait és a műveletek gombjait.

---