export const Api = () => {

    const URL_BASE = 'http://localhost:55612/api/';

    function Get(state, endPoint) {
        debugger;

        const url = `${URL_BASE}${endPoint}`;

        fetch(url)
            .then(response => response.json())
            .then(responseJSON => {
                this.setState({
                    data: responseJSON.data,
                    errorMessage: responseJSON.errorMessage,
                    statusCode: responseJSON.statusCode
                });

            }).catch(error => {
                console.log(`Erro: ${error}`);
                this.setState(...this.state, { errorMessage: error });

            }).finally(() => {
                console.log(`Request finalizado.`);
            });
    }

}