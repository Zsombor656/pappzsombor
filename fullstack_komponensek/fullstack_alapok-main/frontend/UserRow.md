## 3. `UserRow.jsx`

### Feladata:
A `UserRow.jsx` komponens felelős egy felhasználó adatainak megjelenítéséért a táblázat egy sorában. Ez a komponens kezeli a szerkesztést és törlést.

### Kód:
```jsx
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

    const handleUpdate = () => {
        onUpdateUser(user.id, editedName, editedEmail);
    };

    return (
        <tr>
            <td>{user.id}</td>
            <td>
                {isEditing ? (
                    <input
                        type="text"
                        value={editedName}
                        onChange={(e) => setEditedName(e.target.value)}
                    />
                ) : (
                    user.name
                )}
            </td>
            <td>
                {isEditing ? (
                    <input
                        type="email"
                        value={editedEmail}
                        onChange={(e) => setEditedEmail(e.target.value)}
                    />
                ) : (
                    user.email
                )}
            </td>
            <td>{user.created_at}</td>
            <td>
                {isEditing ? (
                    <button onClick={handleUpdate}>Mentés</button>
                ) : (
                    <>
                        <button onClick={() => onEditStart(user)}>Szerkesztés</button>
                        <button onClick={() => onDeleteUser(user.id)}>Törlés</button>
                    </>
                )}
            </td>
        </tr>
    );
}

export default UserRow;
```

### Magyarázat:
- **Szerkesztés**:
  - Ha a sor szerkesztés alatt áll (`editingId === user.id`), akkor input mezőket jelenít meg a név és email szerkesztéséhez.
  - A `handleUpdate` függvény frissíti a felhasználó adatait.
- **Törlés**:
  - A `Törlés` gomb meghívja az `onDeleteUser` függvényt, amely törli a felhasználót.
- **Normál megjelenítés**:
  - Ha a sor nem szerkesztés alatt áll, akkor a felhasználó adatai szövegként jelennek meg.

---

### Összefoglalás

- **`UserForm.jsx`**: Új felhasználók hozzáadására szolgál.
- **`UserTable.jsx`**: A felhasználók listáját jeleníti meg táblázat formájában.
- **`UserRow.jsx`**: Egy felhasználó adatait és műveleteit kezeli a táblázat egy sorában.

Ezek a komponensek együttműködve biztosítják a felhasználókezelő alkalmazás működését.