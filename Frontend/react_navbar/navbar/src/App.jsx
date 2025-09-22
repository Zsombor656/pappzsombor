import { BrowserRouter, Route, Routes } from "react-router-dom";
import Home  from './Home'
import About from './About'
import Contacts from './Contacts'
import './navbar.css'

function App() {

  return (
    <>
      <div>
        <BrowserRouter>
          <Routes>
            <Route path="/" element={<Home/>}/>
           <Route path="/About" element={<About/>}/>
           <Route path="/Contacts" element={<Contacts/>}/>
          </Routes>
        </BrowserRouter>
      </div>
    </>
  )
}

export default App;
