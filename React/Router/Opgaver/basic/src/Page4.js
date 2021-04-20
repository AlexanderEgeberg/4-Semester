
      
  import React from 'react'

      
  import { useParams } from "react-router-dom";

      

      
  const Page4 = () => {

      
    let {id} = useParams();

      
    

      
    return (

      
    <div>

      
      <h2>Page 4 is a subpage for Page2!</h2>

      
      <h4>Id: {id} (passed as route params from Page2)</h4>

      
    </div>

      
    )

      
    }

      
  

      
  export default Page4