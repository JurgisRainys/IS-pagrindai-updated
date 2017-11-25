import React from 'react'
import { BrowserRouter, Route } from 'react-router-dom'

import Register from './components/Register/Register.jsx'
import RegistrationSuccess from './components/Register/RegistrationSuccess.jsx'

export default class RoutesContainer extends React.Component {
    render() {
        return (
            <BrowserRouter>
                <div className='width100-height100'>
                    <Route exact path='/' component={Register} />
                    <Route path='/xd' component={RegistrationSuccess} />
                </div>
            </BrowserRouter>    
        )
    }
}