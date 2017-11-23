const performRequest = (method, url, body) => {
    const headers = new Headers({
        'Content-Type': 'application/json',
        Accept: 'application/json'
    })

    return fetch(url, {
        method,
        headers,
        body: body ? JSON.stringify(body) : undefined,
        credentials: 'include'
    }).then((response) => {
        if (response.status === 204) {
            return {
                status: response.status,
                ok: response.ok,
                data: undefined
            }
        }

        if (response.status === 400) {
            alert('Bad request!')
            throw new Error()
        }

        return response.json().catch(() => {
            return {}
        }).then(data => {
            return {
                status: response.status,
                ok: response.ok,
                data
            }
        })
    })
}

const get = url => performRequest('GET', url)

const post = (url, body) => performRequest('POST', url, body)

const put = (url, body) => performRequest('PUT', url, body)

const _delete = url => performRequest('DELETE', url)

export default { get, post, put, _delete }
