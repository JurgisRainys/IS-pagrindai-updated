import React from 'react'
import { withRouter, Redirect } from 'react-router-dom'

import api from '../../utils/api';

class Register extends React.Component {
    constructor(props) {
        super(props)

        this.handleRegistration = this.handleRegistration.bind(this)
    }

    componentDidMount() {
        api.get(`/api/Users`)
            .then((response) => {
                if (response.ok) {
                    this.setState({ xd: response.data })
                } else {
                    console.log("error in Register.jsx xddd")
                }
            })
    }

    handleRegistration (e) {
        e.preventDefault()          // kad nereloadintu puslapis submitinus forma

        let btn = e.target.btn;
        btn.value = 'Registruojama'
        btn.className = 'registration-btn-registering'

        let email = e.target.email.value
        let password = e.target.password.value
        let firstName = e.target.firstName.value
        let lastName = e.target.lastName.value
        let phone = e.target.phone.value

        let registrationInfo = {
            email,
            password,
            firstName,
            lastName,
            phone
        }

        if (email && password && firstName && lastName && phone) {  //jei laukai ne tusti
            api.post(`/api/Users/register`, registrationInfo)       //siunciam i UsersControlleri registracijos info, metodas POST
                .then(response => {
                    console.log(response)
                    if (response.ok) {
                        console.log("registracija sekminga")

                        this.props.history.push('/xd')  //jei sekminga redirectinam
                    } else {
                        console.log("erroras Register.jsx komponente")
                    }
                    btn.value = 'Registruoti'
                    btn.className = 'registration-btn-idle'
                })
        } else {
            btn.value = 'Registruoti'
            btn.className = 'registration-btn-idle'
        }
    }

    render () {
        return (
            <div className="registration-content-container">
                <h1>REGISTRACIJA</h1>
                <form className="registration-form" onSubmit={this.handleRegistration}>
                    <ul>
                        <li><input type='text' name='email' placeholder="El. paštas" /></li>
                        <li><input type='password' name='password' placeholder="Slaptažodis" /></li>
                        <li>PAPILDOMA INFORMACIJA</li>
                        <li><input type='text' name='firstName' placeholder="Vardas" /></li>
                        <li><input type='text' name='lastName' placeholder="Pavardė" /></li>
                        <li><input type='text' name='phone' placeholder="Tel. numeris" /></li>
                        <li id="registration-submit-btn"><input className='registration-btn-idle' value="Registruotis" name="btn" type="submit" /></li>
                    </ul>
                </form>
                <footer>
                    Visos teisės priklauso © Skelbimai.lt
                </footer>
            </div>
        )
    }
}

export default withRouter(Register)