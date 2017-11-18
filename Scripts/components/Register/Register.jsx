import React from 'react'

class Register extends React.Component {
    render() {
        return (
            <div className="registration-content-container">
                <h1>REGISTRACIJA</h1>
                <form className="registration-form">
                    <ul>
                        <li><input type='text' name='email' placeholder="El. paštas" /></li>
                        <li><input type='text' name='password' placeholder="Slaptažodis" /></li>
                        <li>PAPILDOMA INFORMACIJA</li>
                        <li><input type='text' name='first-name' placeholder="Vardas" /></li>
                        <li><input type='text' name='last-name' placeholder="Pavardė" /></li>
                        <li><input type='text' name='phone' placeholder="Tel. numeris" /></li>
                        <li id="registration-submit-btn"><input value="Registruotis" type="button" /></li>
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