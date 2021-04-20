
  
import React from 'react'

  
import {Route, Switch, Link, useRouteMatch} from 'react-router-dom'

  
import Page3 from './Page3'

  
import Page4 from './Page4'

  

  
const Page2 = () => {

  
  let { path, url } = useRouteMatch();

  

  
  return (

  
  <div>

  
    <h1>Page2 for React-Router Basic!</h1>

  

  
    <Link to={`${url}/page4`}>Page4</Link>

  
    <Switch>

  
        <Route exact path={path} component={Page3}/>

  
        <Route path={`${path}/:id`} component={Page4}/>

  
    </Switch>

  
  </div>

  
)

  
}

  

  
export default Page2