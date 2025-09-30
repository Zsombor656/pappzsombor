import React from 'react';
import { Link } from 'react-router-dom';
import '../NavBar.css';

function NavBar() {
    return (
        <nav className="navbar">
            <div className="navbar-logo">Felhasználókezelő</div>
            <ul className="navbar-links">
                <li><Link to="/">Új felhasználó hozzáadása</Link></li>
                <li><Link to="/users">Felhasználók listája</Link></li>
            </ul>
        </nav>
    );
}

export default NavBar;