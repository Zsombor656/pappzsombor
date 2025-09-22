import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';

function NavbarA() {
    return (
      <>
      
        <Navbar bg="dark" data-bs-theme="dark">
          <Container>
            
            <Nav className="me-auto">
              <Nav.Link href="/">Home</Nav.Link>
              <Nav.Link href="/About">About</Nav.Link>
              <Nav.Link href="/Contacts">Contacts</Nav.Link>
            </Nav>
          </Container>
        </Navbar>
        
      </>
    );
  }
  export default NavbarA;