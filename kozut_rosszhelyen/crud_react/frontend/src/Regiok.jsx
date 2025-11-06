import      React from 'react';
import { useState, useEffect } from 'react';    
import axios from 'axios';

const Regiok = () => {   
   
    
    const [regiok, setRegiok] = useState([]);
    useEffect(() => { 
        const fetchAllKozutak =(async () => { 
            const result = await axios.get('http://localhost:3001/regiok');
            setRegiok(result.data);    
        }) 
        fetchAllKozutak();
        } , []);             

    return (    
        <div>
            <h1>Regiok</h1>
            <div className="regiok">
                {regiok.map((regio) => (
                    <div className='regiok' key={regio.Rid}>
                        <h2 className="text-left color-primary">{regio.Rid}: {regio.regionev}</h2>
                        <h3>{regio.regio_tipusa}</h3>
                    </div>
                ))}  
                </div>         
        </div>                      
    )
}                                   



export default Regiok