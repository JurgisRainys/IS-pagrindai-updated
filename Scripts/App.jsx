import * as React from 'react';
import * as ReactDOM from 'react-dom';
import { AppContainer } from 'react-hot-loader'

import RoutesContainer from './RoutesContainer.jsx'

const render = (ComponentToRender) => {
    ReactDOM.render(
        <AppContainer>
            <ComponentToRender />
        </AppContainer>,
        document.getElementById('app')
    )
}

render(RoutesContainer)

if (module.hot) {
    module.hot.accept('./RoutesContainer.jsx', () => {
        const ChangedRoutesContainer = require('./RoutesContainer.jsx').default;
        render(ChangedRoutesContainer)
    })
}