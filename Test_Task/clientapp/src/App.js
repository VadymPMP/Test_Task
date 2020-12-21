import * as React from 'react';
import { BrowserRouter, Route } from 'react-router-dom';
import DataList from './components/DataList';


function App() {
  return (
    <BrowserRouter>
        <div>
          <Route exact path='/' component={DataList}></Route>
        </div>
        
    </BrowserRouter>

  );
}

export default App;
