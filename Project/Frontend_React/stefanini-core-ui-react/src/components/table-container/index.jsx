import React from 'react';
//import '../table-container.css';

/* Table */
import { withStyles } from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import Paper from '@material-ui/core/Paper';

class TableContainerCustom extends React.Component {

    render() {
        return (
            <TableContainer component={Paper}>
                <Table aria-label="simple table">
                    <TableHead>
                        <TableRow>
                            
                            {this.props.headersTableRow && this.props.headersTableRow.map((item) => (

                                <React.Fragment key={item}>
                                    <StyledTableCell>{item}</StyledTableCell>
                                </React.Fragment>
                            ))}
                            <StyledTableCell>Ação</StyledTableCell>

                        </TableRow>
                    </TableHead>
                    <TableBody>

                        {this.props.valuesTableRow && !this.props.errorMessage &&
                            this.props.valuesTableRow.map((item, index) => (

                                <StyledTableRow key={index} hover='true'>

                                    {Object.values(item).map((value) => (
                                        <StyledTableCell>{value}</StyledTableCell>
                                    ))}
                                    
                                    <StyledTableCell>Editar | Excluir</StyledTableCell>
                                </StyledTableRow>
                            ))}

                        {(this.props.errorMessage &&
                            <div className="divErrorMessageList">
                                {this.props.errorMessage}
                            </div>
                        )}

                    </TableBody>
                </Table>
            </TableContainer >
        );
    }
}

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

export default TableContainerCustom;
