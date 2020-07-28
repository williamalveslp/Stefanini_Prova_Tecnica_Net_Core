import React from 'react';
import { Button } from '@material-ui/core';
import '../list/task-list-page.css';

/* Table */
import { withStyles } from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import Paper from '@material-ui/core/Paper';

/* Breadcrumb */
import Typography from '@material-ui/core/Typography';
import Breadcrumbs from '@material-ui/core/Breadcrumbs';
import { Link as LinkBreadcrumb } from '@material-ui/core';

/* Router*/
//import { Link as LinkRouterDom } from 'react-router-dom';

const StyledTableCell = withStyles((theme) => ({
    head: {
        backgroundColor: '#482880',//theme.palette.common.black,
        color: theme.palette.common.white,
    },
    body: {
        fontSize: 14,
    },
}))(TableCell);

const StyledTableRow = withStyles((theme) => ({
    root: {
        '&:nth-of-type(odd)': {
            backgroundColor: theme.palette.action.hover,
        },
    },
}))(TableRow);

class TaskListPage extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            tasks: [],
            totalRecords: 0,
            errorMessage: '',
            statusCode: ''
        };

        this.loadTasksList = this.loadTasksList.bind(this);
    }

    componentDidMount() {
        this.loadTasksList();
    }

    loadTasksList = () => {

        const endPoint = 'http://localhost:55612/api/Tasks';

        fetch(endPoint)
            .then(response => response.json())
            .then(responseJSON => {
                this.setState({
                    tasks: responseJSON.tasks,
                    totalRecords: responseJSON.totalRecords,
                    errorMessage: responseJSON.errorMessage,
                    statusCode: responseJSON.statusCode
                });

            }).catch(error => {
                console.log(`Erro: ${error}`);
                alert(error);
            });
    }

    render() {
        
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

                <TableContainer component={Paper}>
                    <Table aria-label="simple table">
                        <TableHead>
                            <TableRow>
                                <StyledTableCell>Id</StyledTableCell>
                                <StyledTableCell>Nome</StyledTableCell>
                                <StyledTableCell>Ação</StyledTableCell>
                            </TableRow>
                        </TableHead>
                        <TableBody>

                            {this.state.tasks && !this.state.errorMessage &&
                                this.state.tasks.map((item) => (

                                    <StyledTableRow key={item.id} >
                                        <StyledTableCell component="th" scope="row">{item.id} </StyledTableCell>
                                        <StyledTableCell>{item.name}</StyledTableCell>
                                        <StyledTableCell>Editar | Excluir</StyledTableCell>
                                    </StyledTableRow>
                                ))}

                            {(this.state.errorMessage &&
                                <div className="divErrorMessageList">
                                    <b><p>{this.state.errorMessage}</p></b>
                                </div>
                            )}

                        </TableBody>
                    </Table>
                </TableContainer>
            </div >
        )
    }
}

export default TaskListPage;