import * as React from 'react';
import { BrowserRouter, Route } from 'react-router-dom';
import UserList from './components/UserList';


function App() {
  return (
    <BrowserRouter>
        <div>
          <Route exact path='/' component={UserList}></Route>
        </div>
        
    </BrowserRouter>

  );
}

export default App;
