import React from 'react';
import { Button } from '@material-ui/core';
import TableContainerCustom from '../../../components/table-container';

/* Breadcrumb */
import Typography from '@material-ui/core/Typography';
import Breadcrumbs from '@material-ui/core/Breadcrumbs';
import { Link as LinkBreadcrumb } from '@material-ui/core';

//import { Api } from '../../../utils/requests-api';

class TaskListPage extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            data: [],
            errorMessage: '',
            statusCode: ''
        };

        this.fetchTasks = this.fetchTasks.bind(this);
    }

    componentDidMount() {
        this.fetchTasks();
    }

    fetchTasks = () => {

        //Api.Get(this.state, 'Tasks');

        const endPoint = 'http://localhost:55612/api/Tasks';

        fetch(endPoint)
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

    render() {
        const headersTableRow = ['Id', 'Nome', 'Descrição'];

        const stateData = this.state.data || null;
        const tasksArray = stateData.tasks || null;

        let valuesTableRow = [];

        if (tasksArray) {
            tasksArray.map((item, index) => {
                let newObj = {};
                newObj.id = item["id"];
                newObj.name = item["name"];
                newObj.description = item["description"];
                valuesTableRow.push(newObj);
            })
        }

        return (
            <div>
                <Breadcrumbs aria-label="breadcrumb">
                    <LinkBreadcrumb color="inherit" href="/">Home</LinkBreadcrumb>
                    <Typography color="textPrimary">Funcionalidades</Typography>
                </Breadcrumbs>

                <br />
                <Button variant="contained" color="primary">Novo</Button>
                <br />
                <br />

                <TableContainerCustom
                    headersTableRow={headersTableRow}
                    valuesTableRow={valuesTableRow}
                    totalRecords={this.state.totalRecords}
                    errorMessage={this.state.errorMessage}
                />
            </div >
        )
    }
}

export default TaskListPage;