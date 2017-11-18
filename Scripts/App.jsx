import * as React from 'react';
import * as ReactDOM from 'react-dom';
import { BrowserRouter, Route } from 'react-router-dom';

import Home from './components/Home.jsx'
import TestForDb from './components/TestForDb.jsx'
import Register from './components/Register/Register.jsx'

ReactDOM.render(
    <BrowserRouter>
        <Route path='' component={Register} />
    </BrowserRouter>
    , document.getElementById('app')
)