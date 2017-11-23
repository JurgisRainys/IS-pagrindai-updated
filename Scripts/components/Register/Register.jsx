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
        e.target.btn.value = 'Registruojama'

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

        api.post(`/api/Users/register`, registrationInfo)
        e.target.btn.value = 'Registruoti'
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
                        <li id="registration-submit-btn"><input value="Registruotis" name="btn" type="submit" /></li>
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