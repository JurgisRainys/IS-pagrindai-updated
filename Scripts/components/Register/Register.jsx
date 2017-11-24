import React from 'react'
import api from '../../utils/api';

class Register extends React.Component {
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

    xd (e) {
        e.preventDefault()

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

        let registrationSuccessful = false;

        if (email && password && firstName && lastName && phone) {
            api.post(`/api/Users/register`, registrationInfo)
                .then(response => {
                    if (response.ok) {
                        registrationSuccessful = true;

                    } else {
                        console.log("erroras Register.jsx komponente")
                    }
                    btn.value = 'Registruoti'
                    btn.className = 'registration-btn-idle'
                })
        }

        if (registrationSuccessful) {
            // redirectinsim, veliau implementuota bus
        }
    }

    render () {
        return (
            <div className="registration-content-container">
                <h1>REGISTRACIJA</h1>
                <form className="registration-form" onSubmit={this.xd}>
                    <ul>
                        <li><input type='text' name='email' placeholder="El. paštas" /></li>
                        <li><input type='text' name='password' placeholder="Slaptažodis" /></li>
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

export default Register