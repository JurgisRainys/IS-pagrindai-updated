import React from 'react'
import { BrowserRouter, Route } from 'react-router-dom'

import Register from './components/Register/Register.jsx'

export default class RoutesContainer extends React.Component {
    render() {
        return (
            <BrowserRouter>
                <Route path='' component={Register} />
            </BrowserRouter>    
        )
    }
}