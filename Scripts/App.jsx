import './css/site.css';
import 'bootstrap';

import * as React from 'react';
import * as ReactDOM from 'react-dom';
import { BrowserRouter, Route } from 'react-router-dom';

import Home from './components/Home'

ReactDOM.render(
    <BrowserRouter>
        <xd />
    </BrowserRouter>
    , document.getElementById('app')
)

const xd = () => {
    return <div>asdasdasdasd</div>
}