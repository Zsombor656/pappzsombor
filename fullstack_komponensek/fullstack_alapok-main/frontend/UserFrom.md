# Komponensek magyarázata

Ez a dokumentáció bemutatja a `UserForm.jsx`, `UserTable.jsx`, és `UserRow.jsx` komponensek működését, amelyek a felhasználókezelő alkalmazás részei.

---

## 1. `UserForm.jsx`

### Feladata:
A `UserForm.jsx` komponens felelős új felhasználók hozzáadásáért. Ez egy űrlapot jelenít meg, amelyben a felhasználó megadhatja a nevét és email címét.

### Kód:
```jsx
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
        <form onSubmit={handleSubmit} id="addForm">
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
            <button id="hozzaadBtn" type="submit">Hozzáadás</button>
        </form>
    );
}

export default UserForm;
```
### Magyarázat:
- **Állapotok**:
  - `name`: A felhasználó neve.
  - `email`: A felhasználó email címe.
- **`handleSubmit`**:
  - Ellenőrzi, hogy a név és email mezők ki vannak-e töltve.
  - Meghívja az `onAddUser` függvényt, amelyet a `App.jsx` komponens ad át.
- **Űrlap**:
  - Két input mezőt és egy gombot tartalmaz.

---